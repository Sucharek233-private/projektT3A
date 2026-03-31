
namespace sibenice
{
    public partial class Hra : Form {
        private Klavesnice klavesnice;
        private string hadaneSlovo = "";

        private char[] odhalenaPismena;

        public Hra() {
            InitializeComponent();

            klavesnice = new Klavesnice();
            //klavesnice.pripravitKlavesnici(this, klavesniceContainer);
        }

        public void InitGame() {
            
        }

        public void ResetGame() {
            klavesnice.RebuildKeyboard();
        }

        public void UpdateWord(string newWord) {
            hadaneSlovo = newWord.ToUpper();
            odhalenaPismena = new string('_', hadaneSlovo.Length).ToCharArray();
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
            }

            //if (!odhalenaPismena.Contains('_')) {
            //    MessageBox.Show("d");
            //}
        }

        private void GenerateWordLabel() {
            hadaneSlovoLabel.Text = string.Join(" ", odhalenaPismena);
        }

        private void Hra_Load(object sender, EventArgs e) {
            klavesnice.pripravitKlavesnici(this, klavesniceContainer);
            GenerateWordLabel();
        }
    }
}
