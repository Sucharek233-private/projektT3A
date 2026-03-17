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
            label_Main = new Label();
            sibeniceInfo = new TableLayoutPanel();
            sibenicePanacek = new FlowLayoutPanel();
            informace = new FlowLayoutPanel();
            slovoContainer = new FlowLayoutPanel();
            klavesnice = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            materialButton_GiveUp = new ReaLTaiizor.Controls.MaterialButton();
            materialButton_Exit = new ReaLTaiizor.Controls.MaterialButton();
            tableLayoutPanel2.SuspendLayout();
            sibeniceInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label_Main, 0, 0);
            tableLayoutPanel2.Controls.Add(sibeniceInfo, 0, 1);
            tableLayoutPanel2.Controls.Add(slovoContainer, 0, 2);
            tableLayoutPanel2.Controls.Add(klavesnice, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Size = new Size(635, 337);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label_Main
            // 
            label_Main.AutoSize = true;
            label_Main.Dock = DockStyle.Fill;
            label_Main.Font = new Font("Papyrus", 20F);
            label_Main.Location = new Point(3, 0);
            label_Main.Name = "label_Main";
            label_Main.Size = new Size(629, 33);
            label_Main.TabIndex = 0;
            label_Main.Text = "Šibenice";
            label_Main.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sibeniceInfo
            // 
            sibeniceInfo.ColumnCount = 2;
            sibeniceInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sibeniceInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sibeniceInfo.Controls.Add(sibenicePanacek, 0, 0);
            sibeniceInfo.Controls.Add(informace, 1, 0);
            sibeniceInfo.Dock = DockStyle.Fill;
            sibeniceInfo.Location = new Point(3, 36);
            sibeniceInfo.Name = "sibeniceInfo";
            sibeniceInfo.RowCount = 1;
            sibeniceInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            sibeniceInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sibeniceInfo.Size = new Size(629, 128);
            sibeniceInfo.TabIndex = 1;
            // 
            // sibenicePanacek
            // 
            sibenicePanacek.Dock = DockStyle.Fill;
            sibenicePanacek.Location = new Point(0, 0);
            sibenicePanacek.Margin = new Padding(0);
            sibenicePanacek.Name = "sibenicePanacek";
            sibenicePanacek.Size = new Size(314, 128);
            sibenicePanacek.TabIndex = 0;
            // 
            // informace
            // 
            informace.Dock = DockStyle.Fill;
            informace.Location = new Point(314, 0);
            informace.Margin = new Padding(0);
            informace.Name = "informace";
            informace.Size = new Size(315, 128);
            informace.TabIndex = 1;
            // 
            // slovoContainer
            // 
            slovoContainer.Dock = DockStyle.Fill;
            slovoContainer.Location = new Point(0, 167);
            slovoContainer.Margin = new Padding(0);
            slovoContainer.Name = "slovoContainer";
            slovoContainer.Size = new Size(635, 50);
            slovoContainer.TabIndex = 3;
            // 
            // klavesnice
            // 
            klavesnice.ColumnCount = 1;
            klavesnice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            klavesnice.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            klavesnice.Dock = DockStyle.Fill;
            klavesnice.Location = new Point(3, 220);
            klavesnice.Name = "klavesnice";
            klavesnice.RowCount = 1;
            klavesnice.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            klavesnice.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            klavesnice.Size = new Size(629, 114);
            klavesnice.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(materialButton_GiveUp, 0, 0);
            tableLayoutPanel1.Controls.Add(materialButton_Exit, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 337);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(635, 37);
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
            materialButton_GiveUp.Size = new Size(309, 25);
            materialButton_GiveUp.TabIndex = 0;
            materialButton_GiveUp.Text = "Vzdát se";
            materialButton_GiveUp.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton_GiveUp.UseAccentColor = false;
            materialButton_GiveUp.UseVisualStyleBackColor = true;
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
            materialButton_Exit.Location = new Point(321, 6);
            materialButton_Exit.Margin = new Padding(4, 6, 4, 6);
            materialButton_Exit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton_Exit.Name = "materialButton_Exit";
            materialButton_Exit.NoAccentTextColor = Color.Empty;
            materialButton_Exit.Size = new Size(310, 25);
            materialButton_Exit.TabIndex = 0;
            materialButton_Exit.Text = "Ukončit";
            materialButton_Exit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton_Exit.UseAccentColor = false;
            materialButton_Exit.UseVisualStyleBackColor = true;
            // 
            // Hra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 374);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Hra";
            Text = "Form1";
            Load += Hra_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            sibeniceInfo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel sibeniceInfo;
        private FlowLayoutPanel slovoContainer;
        private FlowLayoutPanel sibenicePanacek;
        private FlowLayoutPanel informace;
        private ReaLTaiizor.Controls.MaterialButton materialButton_GiveUp;
        private ReaLTaiizor.Controls.MaterialButton materialButton_Exit;
        private Label label_Main;
        private TableLayoutPanel klavesnice;
    }
}
