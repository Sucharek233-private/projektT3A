
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace sibenice
{
    public partial class Hra : MaterialForm {
        private Klavesnice klavesnice;
        private Postavicka postavicka;

        private string hadaneSlovo = "";
        private string tema = "";

        private int maxPokusy = 10;
        private int aktualniPokusy = 0;

        private char[] odhalenaPismena;
        private List<char> spatnaPismena = new List<char>();

        public Hra() {
            InitializeComponent();

            klavesnice = new Klavesnice();
            postavicka = new Postavicka();
        }

        public void UpdateWord(string newWord, string newTema) {
            hadaneSlovo = newWord.ToUpper();
            tema = newTema;

            InitGame();
        }

        public void InitGame() {
            odhalenaPismena = new string('_', hadaneSlovo.Length).ToCharArray();
            spatnaPismena.Clear();
            aktualniPokusy = 0;

            GenerateWordLabel();
            UpdateInfo();
        }

        public void ResetGame() {
            klavesnice.RebuildKeyboard();
        }

        private void FinalDialog(string title, string message) {
            MaterialDialog dialog = new ReaLTaiizor.Controls.MaterialDialog(
                this,
                title,
                message,
                "OK",
                false,
                "Zavøít"
            );
            dialog.ShowDialog(this);
        }

        private bool YesNoDialog(string title, string message) {
            MaterialDialog dialog = new ReaLTaiizor.Controls.MaterialDialog(
                this,
                title,
                message,
                "Ano",
                true,
                "Ne"
            );

            DialogResult result = dialog.ShowDialog(this);
            return result == DialogResult.OK;
        }

        public void KeyClicked(string key) {
            char guess = key[0];
            bool found = false;

            for (int i = 0; i < hadaneSlovo.Length; i++) {
                if (hadaneSlovo[i] == guess) {
                    odhalenaPismena[i] = guess;
                    found = true;
                }
            }

            if (found) {
                GenerateWordLabel();
            } else {
                if (!spatnaPismena.Contains(guess)) {
                    spatnaPismena.Add(guess);
                    aktualniPokusy++;
                    sibenicePanacek.Invalidate();
                }
            }

            UpdateInfo();

            if (aktualniPokusy >= maxPokusy) {
                FinalDialog("Prohra", $"Prohrál jsi! Slovo bylo: {hadaneSlovo}");
                Close();
            } else if (!odhalenaPismena.Contains('_')) {
                FinalDialog("Vyhrál jsi!", $"Gratuluji, uhodl jsi slovo {hadaneSlovo}.");
                Close();
            }
        }

        private void GenerateWordLabel() {
            hadaneSlovoLabel.Text = string.Join(" ", odhalenaPismena);
        }

        private void UpdateInfo() {
            informace.Text =
                $"Téma: {tema}\n" +
                $"Špatná písmena: {string.Join(", ", spatnaPismena)}\n" +
                $"Pokusy: {aktualniPokusy} / {maxPokusy}";
        }

        private void Hra_Load(object sender, EventArgs e) {
            klavesnice.pripravitKlavesnici(this, klavesniceContainer);
            GenerateWordLabel();
        }

        private void sibenicePanacek_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            Point velikost = new Point(sibenicePanacek.Width, sibenicePanacek.Height);

            postavicka.Paint(g, aktualniPokusy, velikost);
        }

        private void materialButton_GiveUp_Click(object sender, EventArgs e) {
            bool result = YesNoDialog("Vzdát se", "Opravdu se chcete vzdát?");
            if (result) {
                FinalDialog("Prohra", $"Vzdal jses! Slovo bylo: {hadaneSlovo}");
                Close();
            }
        }

        private void materialButton_Exit_Click(object sender, EventArgs e) {
            bool result = YesNoDialog("Ukonèit hru", "Opravdu chcete ukonèit hru?");
            if (result) {
                Close();
            }
        }
    }
}
