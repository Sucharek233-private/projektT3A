using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace sibenice
{
    public partial class Hra : MaterialForm {
        // Definice, proměnné
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

        // Funkce pro nastavení slova a tématu, inicializace hry
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

        // Dialogy pro konec hry a potvrzení
        private void FinalDialog(string title, string message) {
            MaterialDialog dialog = new MaterialDialog(
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
            MaterialDialog dialog = new MaterialDialog(
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

        // Hlavní logika hry - zpracování kliknutí na klávesu
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

        // Pomocné funkce pro aktualizaci zobrazení
        private void GenerateWordLabel() {
            hadaneSlovoLabel.Text = string.Join(" ", odhalenaPismena);
        }

        private void UpdateInfo() {
            string spatnaPismenaStr = string.Join(", ", spatnaPismena);
            informace.Text =
                $"Téma: {tema}\n" +
                $"Špatná písmena: {spatnaPismenaStr}\n" +
                $"Pokusy: {aktualniPokusy} / {maxPokusy}";
        }

        // Příprava klávesnice a načtení prvního slova při načtení formu
        private void Hra_Load(object sender, EventArgs e) {
            klavesnice.pripravitKlavesnici(this, klavesniceContainer);
            GenerateWordLabel();
        }

        // Vykreslení postavičky
        private void sibenicePanacek_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            Point velikost = new Point(sibenicePanacek.Width, sibenicePanacek.Height);

            postavicka.Paint(g, aktualniPokusy, velikost);
        }

        // Tlačítka pro vzdání se a ukončení hry
        private void materialButton_GiveUp_Click(object sender, EventArgs e) {
            bool result = YesNoDialog("Vzdát se", "Opravdu se chcete vzdát?");
            if (result) {
                FinalDialog("Prohra", $"Vzdal jses! Slovo bylo: {hadaneSlovo}");
                Close();
            }
        }

        private void materialButton_Exit_Click(object sender, EventArgs e) {
            bool result = YesNoDialog("Ukončit hru", "Opravdu chcete ukončit hru?");
            if (result) {
                Close();
            }
        }
    }
}
