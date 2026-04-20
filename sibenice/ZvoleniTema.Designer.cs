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
            temaContainer = new TableLayoutPanel();
            SuspendLayout();
            // 
            // temaContainer
            // 
            temaContainer.ColumnCount = 1;
            temaContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            temaContainer.Dock = DockStyle.Fill;
            temaContainer.Location = new Point(3, 64);
            temaContainer.Name = "temaContainer";
            temaContainer.RowCount = 1;
            temaContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            temaContainer.Size = new Size(298, 307);
            temaContainer.TabIndex = 1;
            // 
            // ZvoleniTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 374);
            Controls.Add(temaContainer);
            Name = "ZvoleniTema";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Témata";
            Shown += ZvoleniTema_Shown;
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel temaContainer;
    }
}