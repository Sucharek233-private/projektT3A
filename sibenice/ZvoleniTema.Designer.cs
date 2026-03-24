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
            label1 = new Label();
            temaContainer = new TableLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Papyrus", 20F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 44);
            label1.TabIndex = 0;
            label1.Text = "Vyber Téma";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            Controls.Add(label1);
            Name = "ZvoleniTema";
            Text = "ZvoleniTema";
            Load += ZvoleniTema_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel temaContainer;
    }
}