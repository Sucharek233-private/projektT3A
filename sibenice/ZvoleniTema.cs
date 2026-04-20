using ReaLTaiizor.Forms;

namespace sibenice {
    public partial class ZvoleniTema : MaterialForm {
        private Slova slova;
        private Hra hra;

        public ZvoleniTema() {
            InitializeComponent();

            slova = new Slova();
            hra = new Hra();

            NacistTemata();
        }

        private void NacistTemata() {
            slova.LoadWords();

            temaContainer.ColumnCount = 1;
            temaContainer.RowCount = slova.temata.Count;

            temaContainer.ColumnStyles.Clear();
            temaContainer.RowStyles.Clear();

            // Máme pouze jeden sloupec => 100% šířky
            temaContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));

            for (int i = 0; i < temaContainer.RowCount; i++) {
                // Roztažení řádků na celou šířku
                temaContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
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
        }

        private void LoadTema(object sender, EventArgs e) {
            string tema = (sender as ReaLTaiizor.Controls.MaterialButton).Text;
            string slovo = slova.GetWordForTema(tema);

            hra = new Hra();
            hra.UpdateWord(slovo, tema);
            hra.ShowDialog();
        }
    }
}
