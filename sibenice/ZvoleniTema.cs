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

namespace sibenice {
    public partial class ZvoleniTema : Form {
        private Slova slova;

        public ZvoleniTema() {
            InitializeComponent();

            slova = new Slova();
        }
        private void ZvoleniTema_Load(object sender, EventArgs e) {
            slova.LoadWords();

            temaContainer.ColumnCount = 1;
            temaContainer.RowCount = slova.temata.Count;

            temaContainer.ColumnStyles.Clear();
            temaContainer.RowStyles.Clear();

            temaContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));

            for (int i = 0; i < temaContainer.RowCount; i++) {
                temaContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / temaContainer.RowCount));
            }

            int r = 0;
            slova.temata.ForEach(tema => {
                var btn = new ReaLTaiizor.Controls.MaterialButton {
                    Text = tema,
                    Dock = DockStyle.Fill
                };
                btn.Click += (s, ev) => {
                    var hraForm = new Hra();
                    hraForm.Show();
                    this.Close();
                };
                temaContainer.Controls.Add(btn, 0, r);
                r++;
            });

        }
    }
}
