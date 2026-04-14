using ReaLTaiizor.Forms;

namespace sibenice {
    public partial class Napoveda : MaterialForm {
        private Postavicka postavicka;

        private int pokusy = 0;
        private int maxPokusy = 10;
        private System.Windows.Forms.Timer animTimer;

        public Napoveda() {
            InitializeComponent();

            postavicka = new Postavicka();

            animTimer = new System.Windows.Forms.Timer();
            animTimer.Interval = 1000; // 500 ms
            animTimer.Tick += AnimTimer_Tick;
            animTimer.Start();
        }

        private void AnimTimer_Tick(object sender, EventArgs e) {
            pokusy++;

            if (pokusy > maxPokusy) // počet částí postavy
                pokusy = 0;

            materialCard_Postavicka.Invalidate(); // překreslit
        }

        private void materialCard_Postavicka_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Point velikost = new Point(materialCard_Postavicka.Width, materialCard_Postavicka.Height);
            postavicka.Paint(g, pokusy, velikost);
        }

        private void materialButton_Close_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
