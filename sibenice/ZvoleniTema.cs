using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ReaLTaiizor.Manager.MaterialSkinManager;
using ReaLTaiizor.Forms;

namespace sibenice {
    public partial class ZvoleniTema : MaterialForm {
        private Slova slova;
        private Hra hra;

        private bool loaded = false;

        public ZvoleniTema() {
            InitializeComponent();

            slova = new Slova();
            hra = new Hra();
        }
        private void ZvoleniTema_Load(object sender, EventArgs e) {
            if (loaded) {
                return;
            }

            slova.LoadWords();

            temaContainer.ColumnCount = 1;
            temaContainer.RowCount = slova.temata.Count;

            temaContainer.ColumnStyles.Clear();
            temaContainer.RowStyles.Clear();

            // Mame pouze jeden sloupec
            temaContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));

            for (int i = 0; i < temaContainer.RowCount; i++) {
                temaContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100f)); // roztazeni radku na celou sirku
            }

            int r = 0;
            slova.temata.ForEach(tema => {
                var btn = new ReaLTaiizor.Controls.MaterialButton {
                    Text = tema,
                    Margin = new Padding(3),
                    Dock = DockStyle.Fill
                };
                btn.Click += LoadTema;
                temaContainer.Controls.Add(btn, 0, r);
                r++;
            });

            // aktualizace velikosti okna podle poctu tlacitek
            int velikostTlacitek = 40;
            int velikostOstatni = 100;
            this.ClientSize = new Size(this.ClientSize.Width, temaContainer.RowCount * velikostTlacitek + velikostOstatni);

            loaded = true;
        }

        private void LoadTema(object sender, EventArgs e) {
            string tema = (sender as ReaLTaiizor.Controls.MaterialButton)?.Text ?? "fallback";
            string slovo = slova.GetWordForTema(tema);
            //label_Main.Text = slovo;

            hra = new Hra();
            hra.UpdateWord(slovo, tema);
            hra.ShowDialog();
        }
    }
}
