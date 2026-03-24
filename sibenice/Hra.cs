
namespace sibenice
{
    public partial class Hra : Form {
        public Hra() {
            InitializeComponent();

            Klavesnice cKlavesnice = new Klavesnice();

            cKlavesnice.pripravitKlavesnici(this, klavesniceContainer);
        }

        public void KeyClicked(string key) {
            MessageBox.Show($"Stisknuto: {key}");

        }

        private void Hra_Load(object sender, EventArgs e) {

        }
    }
}
