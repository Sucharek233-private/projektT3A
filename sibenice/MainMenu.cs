using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

namespace sibenice {
    public partial class MainMenu : MaterialForm {
        private ZvoleniTema zvoleniTema;
        public MainMenu() {
            InitializeComponent();

            zvoleniTema = new ZvoleniTema();
        }

        private void MainMenu_Load(object sender, EventArgs e) {

        }

        private void materialButton_Play_Click(object sender, EventArgs e) {
            zvoleniTema.ShowDialog();
        }
    }
}
