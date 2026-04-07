
using ReaLTaiizor.Forms;

using ReaLTaiizor.Manager;

namespace sibenice
{
    public partial class Hra : MaterialForm {
        private Klavesnice klavesnice;
        private Postavicka postavicka;
        private MaterialStyly materialStyly;

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
            materialStyly = new MaterialStyly();
            //klavesnice.pripravitKlavesnici(this, klavesniceContainer);

            MaterialSkinManager material = materialStyly.GreenTheme();
            material.AddFormToManage(this);

            hadaneSlovoLabel.Font = new Font("Roboto", 18);
            informace.Font = new Font("Roboto", 12);
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
            postavicka.InitParts();
        }

        public void ResetGame() {
            klavesnice.RebuildKeyboard();
        }

        private void FinalDialog(string title, string message) {
            var dialog = new ReaLTaiizor.Controls.MaterialDialog(
                this,
                title,
                message,
                "OK",
                false,
                "Zavøít"
            );
            dialog.ShowDialog(this);
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
                this.Close();
            } else if (!odhalenaPismena.Contains('_')) {
                FinalDialog("Vyhrál jsi!", "Gratuluji, uhodl jsi slovo.");
                this.Close();
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

            Point posunutiNaStred = new Point((sibenicePanacek.Width - 200) / 2, (sibenicePanacek.Height - 200) / 2);

            postavicka.Paint(g, aktualniPokusy, posunutiNaStred);
        }

        private void materialButton_Exit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
