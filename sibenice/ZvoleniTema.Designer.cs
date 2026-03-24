namespace sibenice {
    partial class ZvoleniTema {
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
            temaContainer = new TableLayoutPanel();
            SuspendLayout();
            // 
            // label_Main
            // 
            label_Main.Dock = DockStyle.Top;
            label_Main.Font = new Font("Papyrus", 20F);
            label_Main.Location = new Point(0, 0);
            label_Main.Name = "label_Main";
            label_Main.Size = new Size(290, 44);
            label_Main.TabIndex = 0;
            label_Main.Text = "Témata";
            label_Main.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // temaContainer
            // 
            temaContainer.ColumnCount = 1;
            temaContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            temaContainer.Dock = DockStyle.Fill;
            temaContainer.Location = new Point(0, 44);
            temaContainer.Name = "temaContainer";
            temaContainer.RowCount = 1;
            temaContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            temaContainer.Size = new Size(290, 336);
            temaContainer.TabIndex = 1;
            // 
            // ZvoleniTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 380);
            Controls.Add(temaContainer);
            Controls.Add(label_Main);
            Name = "ZvoleniTema";
            Text = "ZvoleniTema";
            Load += ZvoleniTema_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label_Main;
        private TableLayoutPanel temaContainer;
    }
}