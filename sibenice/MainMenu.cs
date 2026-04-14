using ReaLTaiizor.Forms;

namespace sibenice {
    public partial class MainMenu : MaterialForm {
        private ZvoleniTema zvoleniTema;
        private Napoveda napoveda;

        public MainMenu() {
            InitializeComponent();

            zvoleniTema = new ZvoleniTema();
            napoveda = new Napoveda();
        }

        private void MainMenu_Load(object sender, EventArgs e) {

        }

        private void materialButton_Play_Click(object sender, EventArgs e) {
            zvoleniTema.ShowDialog();
        }

        private void materialButton_Napoveda_Click(object sender, EventArgs e) {
            napoveda.ShowDialog();
        }

        private void materialButton_Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

    }
}
