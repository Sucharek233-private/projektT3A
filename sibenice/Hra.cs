
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using static ReaLTaiizor.Controls.HopeTabPage;


namespace sibenice
{
    public partial class Hra : Form {
        public Hra() {
            InitializeComponent();

            BuildKeyboard(qwertz: false, includeDiacritics: true);

            var material = MaterialSkinManager.Instance;

            // Light/Dark theme
            //material.Theme = MaterialSkinManager.Themes.DARK;

            // Set the primary/accent/text shades that your MaterialButton will use
            material.ColorScheme = new MaterialColorScheme(
                MaterialPrimary.Green500,
                MaterialPrimary.Green700,
                MaterialPrimary.Green100,
                MaterialAccent.Green200,
                MaterialTextShade.WHITE
            );
        }

        private TableLayoutPanel keyboardTable;

        private void BuildKeyboard(bool qwertz = true, bool includeDiacritics = true) {
            // Remove old keyboard if rebuilding
            if (keyboardTable != null) {
                this.Controls.Remove(keyboardTable);
                keyboardTable.Dispose();
            }

            keyboardTable = klavesnice;
            keyboardTable.RowCount = includeDiacritics ? 4 : 3;
            keyboardTable.ColumnCount = 15;

            // Create equal columns
            keyboardTable.ColumnStyles.Clear();
            for (int i = 0; i < keyboardTable.ColumnCount; i++)
                keyboardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / keyboardTable.ColumnCount));

            keyboardTable.RowStyles.Clear();
            int rows = keyboardTable.RowCount;
            for (int r = 0; r < rows; r++)
                keyboardTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));

            // Define rows
            string row1 = qwertz ? "Q W E R T Z U I O P" : "Q W E R T Y U I O P";
            string row2 = "A S D F G H J K L";
            string row3 = qwertz ? "Y X C V B N M" : "Z X C V B N M";

            // Optional Czech diacritics
            string diacritics = "Á È Ï É Ì Í Ò Ó Ø Š  Ú Ù Ý Ž";

            // Build rows with a helper
            AddRow(row1.Split(' '), rowIndex: 0, startCol: 2);
            AddRow(row2.Split(' '), rowIndex: 1, startCol: 3);
            AddRow(row3.Split(' '), rowIndex: 2, startCol: 4);

            if (includeDiacritics)
                AddRow(diacritics.Split(' '), rowIndex: 3, startCol: 0);
        }

        private void AddRow(string[] keys, int rowIndex, int startCol) {
            int c = startCol;

            foreach (var key in keys) {
                var btn = CreateKeyButton(key);
                btn.Click += OnKeyClick;
                keyboardTable.Controls.Add(btn, c, rowIndex);
                // Span 1 column by default
                c++;
            }
        }

        private ReaLTaiizor.Controls.MaterialButton CreateKeyButton(string text) {
            var btn = new ReaLTaiizor.Controls.MaterialButton {
                Text = text,
                Dock = DockStyle.Fill,
                Margin = new Padding(2),
                FlatStyle = FlatStyle.Standard,
                Tag = text
            };

            // Optional: consistent sizing for readability
            btn.MinimumSize = new Size(36, 36);
            btn.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Point);

            return btn;
        }

        // Handle guesses
        private void OnKeyClick(object? sender, EventArgs e) {
            if (sender is ReaLTaiizor.Controls.MaterialButton btn) {
                string guess = btn.Tag.ToString()!;

                // Disable after use
                btn.Enabled = false;

                // TODO: Call your game logic here:
                // bool correct = game.TryGuess(guess[0]); // adjust for multi-char like "Á"
                // Update UI accordingly (masked word, hangman state, etc.)

                // Example visuals (replace with your logic):
                //Console.WriteLine($"Guessed: {guess}");
                //label_Main.Text = guess;
            }
        }


        private void Hra_Load(object sender, EventArgs e) {

        }
    }
}
