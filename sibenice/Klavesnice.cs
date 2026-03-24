using ReaLTaiizor.Colors;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sibenice {
    internal class Klavesnice {
        private TableLayoutPanel klavesnice;
        private Hra hra;

        public void pripravitKlavesnici(Hra hraRef, TableLayoutPanel klavesniceContainer) {
            hra = hraRef;
            klavesnice = klavesniceContainer;
            BuildKeyboard();

            var material = MaterialSkinManager.Instance;

            //material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new MaterialColorScheme(
                MaterialPrimary.Green500,
                MaterialPrimary.Green700,
                MaterialPrimary.Green100,
                MaterialAccent.Green200,
                MaterialTextShade.WHITE
            );
        }

        private void BuildKeyboard() {
            // Velikost klavesnice
            klavesnice.RowCount = 3;
            klavesnice.ColumnCount = 15;

            // vytvoreni sloupcu a radku
            klavesnice.ColumnStyles.Clear();
            for (int i = 0; i < klavesnice.ColumnCount; i++)
                klavesnice.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 100.0f / klavesnice.ColumnCount)
                );

            klavesnice.RowStyles.Clear();
            for (int i = 0; i < klavesnice.RowCount; i++)
                klavesnice.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 100.0f / klavesnice.RowCount)
                );

            // Radky
            AddRow("A Á B C Č D Ď E É Ě F G H I".Split(' '), 0);
            AddRow("Í J K L M N Ň O Ó P Q R Ř S".Split(' '), 1);
            AddRow("Š T Ť U Ú Ů V W X Y Ý Z Ž".  Split(' '), 2);
        }

        private void AddRow(string[] keys, int rowIndex) {
            int column = 0;

            foreach (var key in keys) {
                var btn = CreateKeyButton(key);
                btn.Click += OnKeyClick;
                klavesnice.Controls.Add(btn, column, rowIndex);
                // Span 1 column by default
                column++;
            }
        }

        private ReaLTaiizor.Controls.MaterialButton CreateKeyButton(string text) {
            var btn = new ReaLTaiizor.Controls.MaterialButton {
                Text = text,
                Margin = new Padding(2),
            };

            // Optional: consistent sizing for readability
            btn.MinimumSize = new Size(30, 30);

            return btn;
        }

        // Handle guesses
        private void OnKeyClick(object? sender, EventArgs e) {
            if (sender is ReaLTaiizor.Controls.MaterialButton btn) {
                string guess = btn.Text.ToString()!;

                // Disable after use
                btn.Enabled = false;

                hra.KeyClicked(guess);
            }
        }
    }
}
