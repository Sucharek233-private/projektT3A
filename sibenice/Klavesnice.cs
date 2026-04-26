using ReaLTaiizor.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace sibenice {
    internal class Klavesnice {
        private TableLayoutPanel klavesnice;
        private Hra hra;

        public Klavesnice(Hra hraRef, TableLayoutPanel klavesniceContainer) {
            hra = hraRef;
            klavesnice = klavesniceContainer;
            PostavitKlavesnici();
        }

        private void PostavitKlavesnici() {
            // Velikost klávesnice
            klavesnice.RowCount = 3;
            klavesnice.ColumnCount = 14;

            // Vytvoření sloupců a řádků
            klavesnice.ColumnStyles.Clear();
            for (int i = 0; i < klavesnice.ColumnCount; i++) {
                klavesnice.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 100f)
                );
            }

            klavesnice.RowStyles.Clear();
            for (int i = 0; i < klavesnice.RowCount; i++) {
                klavesnice.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 100f)
                );
            }

            // Řádky klávesnice
            PridatRadekKlaves("A Á B C Č D Ď E É Ě F G H I".Split(' '), 0);
            PridatRadekKlaves("Í J K L M N Ň O Ó P Q R Ř S".Split(' '), 1);
            PridatRadekKlaves("Š T Ť U Ú Ů V W X Y Ý Z Ž"  .Split(' '), 2);
        }

        private void PridatRadekKlaves(string[] keys, int rowIndex) {
            for (int column = 0; column < keys.Length; column++) {
                string key = keys[column];

                MaterialButton btn = new() {
                    Text = key,
                    Margin = new Padding(2),
                    Dock = DockStyle.Fill
                };

                btn.Click += OnKeyClick;
                klavesnice.Controls.Add(btn, column, rowIndex);
            }
        }

        private void OnKeyClick(object? sender, EventArgs e) {
            if (sender is MaterialButton btn) {
                string guess = btn.Text;
                btn.Enabled = false;
                hra.KeyClicked(guess);
            }
        }
    }
}
