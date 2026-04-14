namespace sibenice {
    partial class MainMenu {
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
            label_Main = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            materialButton_Play = new ReaLTaiizor.Controls.MaterialButton();
            materialButton_Exit = new ReaLTaiizor.Controls.MaterialButton();
            materialButton_Napoveda = new ReaLTaiizor.Controls.MaterialButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label_Main
            // 
            label_Main.Dock = DockStyle.Fill;
            label_Main.Font = new Font("Papyrus", 50F);
            label_Main.Location = new Point(3, 0);
            label_Main.Name = "label_Main";
            label_Main.Size = new Size(331, 110);
            label_Main.TabIndex = 0;
            label_Main.Text = "Šibenice";
            label_Main.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(materialButton_Play, 0, 0);
            tableLayoutPanel1.Controls.Add(materialButton_Exit, 0, 2);
            tableLayoutPanel1.Controls.Add(materialButton_Napoveda, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 110);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(337, 163);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // materialButton_Play
            // 
            materialButton_Play.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton_Play.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton_Play.Depth = 0;
            materialButton_Play.Dock = DockStyle.Fill;
            materialButton_Play.HighEmphasis = true;
            materialButton_Play.Icon = null;
            materialButton_Play.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton_Play.Location = new Point(4, 6);
            materialButton_Play.Margin = new Padding(4, 6, 4, 6);
            materialButton_Play.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton_Play.Name = "materialButton_Play";
            materialButton_Play.NoAccentTextColor = Color.Empty;
            materialButton_Play.Size = new Size(329, 42);
            materialButton_Play.TabIndex = 5;
            materialButton_Play.Text = "Hrát";
            materialButton_Play.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton_Play.UseAccentColor = false;
            materialButton_Play.UseVisualStyleBackColor = true;
            materialButton_Play.Click += materialButton_Play_Click;
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
            materialButton_Exit.Location = new Point(4, 114);
            materialButton_Exit.Margin = new Padding(4, 6, 4, 6);
            materialButton_Exit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton_Exit.Name = "materialButton_Exit";
            materialButton_Exit.NoAccentTextColor = Color.Empty;
            materialButton_Exit.Size = new Size(329, 43);
            materialButton_Exit.TabIndex = 4;
            materialButton_Exit.Text = "Ukončit";
            materialButton_Exit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton_Exit.UseAccentColor = false;
            materialButton_Exit.UseVisualStyleBackColor = true;
            materialButton_Exit.Click += materialButton_Exit_Click;
            // 
            // materialButton_Napoveda
            // 
            materialButton_Napoveda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton_Napoveda.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton_Napoveda.Depth = 0;
            materialButton_Napoveda.Dock = DockStyle.Fill;
            materialButton_Napoveda.HighEmphasis = true;
            materialButton_Napoveda.Icon = null;
            materialButton_Napoveda.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton_Napoveda.Location = new Point(4, 60);
            materialButton_Napoveda.Margin = new Padding(4, 6, 4, 6);
            materialButton_Napoveda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton_Napoveda.Name = "materialButton_Napoveda";
            materialButton_Napoveda.NoAccentTextColor = Color.Empty;
            materialButton_Napoveda.Size = new Size(329, 42);
            materialButton_Napoveda.TabIndex = 3;
            materialButton_Napoveda.Text = "Nápověda";
            materialButton_Napoveda.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton_Napoveda.UseAccentColor = false;
            materialButton_Napoveda.UseVisualStyleBackColor = true;
            materialButton_Napoveda.Click += materialButton_Napoveda_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label_Main, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(337, 273);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(343, 300);
            Controls.Add(tableLayoutPanel2);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(261, 61);
            Name = "MainMenu";
            Padding = new Padding(3, 24, 3, 3);
            ShowIcon = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Šibenice";
            TransparencyKey = Color.Fuchsia;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label_Main;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialButton materialButton_Play;
        private ReaLTaiizor.Controls.MaterialButton materialButton_Exit;
        private ReaLTaiizor.Controls.MaterialButton materialButton_Napoveda;
        private TableLayoutPanel tableLayoutPanel2;
    }
}