namespace sibenice {
    partial class Napoveda {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tableLayoutPanel1 = new TableLayoutPanel();
            materialCard_Text = new ReaLTaiizor.Controls.MaterialCard();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard_Postavicka = new ReaLTaiizor.Controls.MaterialCard();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialButton_Close = new ReaLTaiizor.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            materialCard_Text.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(materialCard_Text, 0, 0);
            tableLayoutPanel1.Controls.Add(materialCard_Postavicka, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(588, 227);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // materialCard_Text
            // 
            materialCard_Text.BackColor = Color.FromArgb(255, 255, 255);
            materialCard_Text.Controls.Add(materialLabel1);
            materialCard_Text.Depth = 0;
            materialCard_Text.Dock = DockStyle.Fill;
            materialCard_Text.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard_Text.Location = new Point(14, 14);
            materialCard_Text.Margin = new Padding(14);
            materialCard_Text.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard_Text.Name = "materialCard_Text";
            materialCard_Text.Padding = new Padding(14);
            materialCard_Text.Size = new Size(266, 199);
            materialCard_Text.TabIndex = 0;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Fill;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(14, 14);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(238, 171);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Cílem hry je uhodnout slovo.\r\n\r\n• Klikni na písmeno\r\n• Pokud je ve slově, odhalí se\r\n• Pokud ne, přibude část postavy\r\n\r\nUhodni slovo dřív, než bude panáček kompletní!";
            // 
            // materialCard_Postavicka
            // 
            materialCard_Postavicka.BackColor = Color.FromArgb(255, 255, 255);
            materialCard_Postavicka.Depth = 0;
            materialCard_Postavicka.Dock = DockStyle.Fill;
            materialCard_Postavicka.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard_Postavicka.Location = new Point(308, 14);
            materialCard_Postavicka.Margin = new Padding(14);
            materialCard_Postavicka.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard_Postavicka.Name = "materialCard_Postavicka";
            materialCard_Postavicka.Padding = new Padding(14);
            materialCard_Postavicka.Size = new Size(266, 199);
            materialCard_Postavicka.TabIndex = 1;
            materialCard_Postavicka.Paint += materialCard_Postavicka_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(materialButton_Close, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 64);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(594, 263);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // materialButton_Close
            // 
            materialButton_Close.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton_Close.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton_Close.Depth = 0;
            materialButton_Close.Dock = DockStyle.Fill;
            materialButton_Close.HighEmphasis = true;
            materialButton_Close.Icon = null;
            materialButton_Close.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton_Close.Location = new Point(2, 234);
            materialButton_Close.Margin = new Padding(2, 1, 2, 4);
            materialButton_Close.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton_Close.Name = "materialButton_Close";
            materialButton_Close.NoAccentTextColor = Color.Empty;
            materialButton_Close.Size = new Size(590, 25);
            materialButton_Close.TabIndex = 1;
            materialButton_Close.Text = "Zavřít";
            materialButton_Close.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton_Close.UseAccentColor = false;
            materialButton_Close.UseVisualStyleBackColor = true;
            materialButton_Close.Click += materialButton_Close_Click;
            // 
            // Napoveda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 330);
            Controls.Add(tableLayoutPanel2);
            Name = "Napoveda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nápověda";
            tableLayoutPanel1.ResumeLayout(false);
            materialCard_Text.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialCard materialCard_Text;
        private ReaLTaiizor.Controls.MaterialCard materialCard_Postavicka;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialButton materialButton_Close;
    }
}