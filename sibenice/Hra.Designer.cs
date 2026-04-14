namespace sibenice
{
    partial class Hra
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tableLayoutPanel2 = new TableLayoutPanel();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            hadaneSlovoLabel = new Label();
            sibeniceInfo = new TableLayoutPanel();
            sibenicePanacek = new ReaLTaiizor.Controls.MaterialCard();
            informace_card = new ReaLTaiizor.Controls.MaterialCard();
            informace = new Label();
            klavesniceContainer = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            materialButton_GiveUp = new ReaLTaiizor.Controls.MaterialButton();
            materialButton_Exit = new ReaLTaiizor.Controls.MaterialButton();
            tableLayoutPanel2.SuspendLayout();
            materialCard1.SuspendLayout();
            sibeniceInfo.SuspendLayout();
            informace_card.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(materialCard1, 0, 1);
            tableLayoutPanel2.Controls.Add(sibeniceInfo, 0, 0);
            tableLayoutPanel2.Controls.Add(klavesniceContainer, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 64);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.11111F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(629, 390);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(hadaneSlovoLabel);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 238);
            materialCard1.Margin = new Padding(17, 0, 17, 0);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(1);
            materialCard1.Size = new Size(595, 43);
            materialCard1.TabIndex = 0;
            // 
            // hadaneSlovoLabel
            // 
            hadaneSlovoLabel.Dock = DockStyle.Fill;
            hadaneSlovoLabel.Font = new Font("Microsoft Sans Serif", 18F);
            hadaneSlovoLabel.Location = new Point(1, 1);
            hadaneSlovoLabel.Name = "hadaneSlovoLabel";
            hadaneSlovoLabel.Size = new Size(593, 41);
            hadaneSlovoLabel.TabIndex = 5;
            hadaneSlovoLabel.Text = "_ L _ V _";
            hadaneSlovoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sibeniceInfo
            // 
            sibeniceInfo.ColumnCount = 2;
            sibeniceInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sibeniceInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sibeniceInfo.Controls.Add(sibenicePanacek, 0, 0);
            sibeniceInfo.Controls.Add(informace_card, 1, 0);
            sibeniceInfo.Dock = DockStyle.Fill;
            sibeniceInfo.Location = new Point(3, 3);
            sibeniceInfo.Name = "sibeniceInfo";
            sibeniceInfo.RowCount = 1;
            sibeniceInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            sibeniceInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sibeniceInfo.Size = new Size(623, 232);
            sibeniceInfo.TabIndex = 1;
            // 
            // sibenicePanacek
            // 
            sibenicePanacek.BackColor = Color.FromArgb(255, 255, 255);
            sibenicePanacek.Depth = 0;
            sibenicePanacek.Dock = DockStyle.Fill;
            sibenicePanacek.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sibenicePanacek.Location = new Point(14, 14);
            sibenicePanacek.Margin = new Padding(14);
            sibenicePanacek.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            sibenicePanacek.Name = "sibenicePanacek";
            sibenicePanacek.Padding = new Padding(14);
            sibenicePanacek.Size = new Size(283, 204);
            sibenicePanacek.TabIndex = 0;
            sibenicePanacek.Paint += sibenicePanacek_Paint;
            // 
            // informace_card
            // 
            informace_card.BackColor = Color.FromArgb(255, 255, 255);
            informace_card.Controls.Add(informace);
            informace_card.Depth = 0;
            informace_card.Dock = DockStyle.Fill;
            informace_card.ForeColor = Color.FromArgb(222, 0, 0, 0);
            informace_card.Location = new Point(325, 14);
            informace_card.Margin = new Padding(14);
            informace_card.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            informace_card.Name = "informace_card";
            informace_card.Padding = new Padding(14);
            informace_card.Size = new Size(284, 204);
            informace_card.TabIndex = 0;
            // 
            // informace
            // 
            informace.Dock = DockStyle.Fill;
            informace.Font = new Font("Microsoft Sans Serif", 12F);
            informace.Location = new Point(14, 14);
            informace.Name = "informace";
            informace.Size = new Size(256, 176);
            informace.TabIndex = 1;
            informace.Text = "Informace:";
            informace.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // klavesniceContainer
            // 
            klavesniceContainer.ColumnCount = 1;
            klavesniceContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            klavesniceContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            klavesniceContainer.Dock = DockStyle.Fill;
            klavesniceContainer.Location = new Point(3, 284);
            klavesniceContainer.Name = "klavesniceContainer";
            klavesniceContainer.RowCount = 1;
            klavesniceContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            klavesniceContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            klavesniceContainer.Size = new Size(623, 103);
            klavesniceContainer.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(materialButton_GiveUp, 0, 0);
            tableLayoutPanel1.Controls.Add(materialButton_Exit, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 454);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(629, 37);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // materialButton_GiveUp
            // 
            materialButton_GiveUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton_GiveUp.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton_GiveUp.Depth = 0;
            materialButton_GiveUp.Dock = DockStyle.Fill;
            materialButton_GiveUp.HighEmphasis = true;
            materialButton_GiveUp.Icon = null;
            materialButton_GiveUp.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton_GiveUp.Location = new Point(4, 6);
            materialButton_GiveUp.Margin = new Padding(4, 6, 4, 6);
            materialButton_GiveUp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton_GiveUp.Name = "materialButton_GiveUp";
            materialButton_GiveUp.NoAccentTextColor = Color.Empty;
            materialButton_GiveUp.Size = new Size(306, 25);
            materialButton_GiveUp.TabIndex = 0;
            materialButton_GiveUp.Text = "Vzdát se";
            materialButton_GiveUp.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton_GiveUp.UseAccentColor = false;
            materialButton_GiveUp.UseVisualStyleBackColor = true;
            materialButton_GiveUp.Click += materialButton_GiveUp_Click;
            // 
            // materialButton_Exit
            // 
            materialButton_Exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton_Exit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton_Exit.Depth = 0;
            materialButton_Exit.Dock = DockStyle.Fill;
            materialButton_Exit.HighEmphasis = true;
            materialButton_Exit.Icon = null;
            materialButton_Exit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton_Exit.Location = new Point(318, 6);
            materialButton_Exit.Margin = new Padding(4, 6, 4, 6);
            materialButton_Exit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton_Exit.Name = "materialButton_Exit";
            materialButton_Exit.NoAccentTextColor = Color.Empty;
            materialButton_Exit.Size = new Size(307, 25);
            materialButton_Exit.TabIndex = 0;
            materialButton_Exit.Text = "Ukončit";
            materialButton_Exit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton_Exit.UseAccentColor = false;
            materialButton_Exit.UseVisualStyleBackColor = true;
            materialButton_Exit.Click += materialButton_Exit_Click;
            // 
            // Hra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 494);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Hra";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Šibenice";
            Load += Hra_Load;
            tableLayoutPanel2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            sibeniceInfo.ResumeLayout(false);
            informace_card.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel sibeniceInfo;
        private ReaLTaiizor.Controls.MaterialButton materialButton_GiveUp;
        private ReaLTaiizor.Controls.MaterialButton materialButton_Exit;
        private TableLayoutPanel klavesniceContainer;
        private Label hadaneSlovoLabel;
        private Label informace;
        private ReaLTaiizor.Controls.MaterialCard informace_card;
        private ReaLTaiizor.Controls.MaterialCard sibenicePanacek;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
    }
}
