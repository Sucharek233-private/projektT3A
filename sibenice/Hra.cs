
namespace sibenice
{
    public partial class Hra : Form {
        private Klavesnice klavesnice;
        private string hadaneSlovo = "";
        private string tema = "";

        private int maxPokusy = 10;
        private int aktualniPokusy = 0;

        private char[] odhalenaPismena;
        private List<char> spatnaPismena = new List<char>();

        public Hra() {
            InitializeComponent();

            klavesnice = new Klavesnice();
            //klavesnice.pripravitKlavesnici(this, klavesniceContainer);
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

        public void KeyClicked(string key) {
            MessageBox.Show($"Stisknuto: {key}");

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

            //if (!odhalenaPismena.Contains('_')) {
            //    MessageBox.Show("d");
            //}

            UpdateInfo();
        }

        private void GenerateWordLabel() {
            hadaneSlovoLabel.Text = string.Join(" ", odhalenaPismena);
        }

        private void UpdateInfo() {
            informace_.Text =
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
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // pøíklad: 1. pokus – základna
            if (aktualniPokusy >= 1)
                g.DrawLine(Pens.Black, 10, 180, 100, 180);

            // 2. pokus – sloup
            if (aktualniPokusy >= 2)
                g.DrawLine(Pens.Black, 55, 180, 55, 20);

            // 3. pokus – horní trám
            if (aktualniPokusy >= 3)
                g.DrawLine(Pens.Black, 55, 20, 130, 20);

            // 4. pokus – provaz
            if (aktualniPokusy >= 4)
                g.DrawLine(Pens.Black, 130, 20, 130, 50);

            // 5. pokus – hlava
            if (aktualniPokusy >= 5)
                g.DrawEllipse(Pens.Black, 115, 50, 30, 30);

            // 6. pokus – tìlo
            if (aktualniPokusy >= 6)
                g.DrawLine(Pens.Black, 130, 80, 130, 130);

            // 7. pokus – levá ruka
            if (aktualniPokusy >= 7)
                g.DrawLine(Pens.Black, 130, 90, 110, 110);

            // 8. pokus – pravá ruka
            if (aktualniPokusy >= 8)
                g.DrawLine(Pens.Black, 130, 90, 150, 110);

            // 9. pokus – levá noha
            if (aktualniPokusy >= 9)
                g.DrawLine(Pens.Black, 130, 130, 110, 160);

            // 10. pokus – pravá noha
            if (aktualniPokusy >= 10)
                g.DrawLine(Pens.Black, 130, 130, 150, 160);
        }
    }
}
