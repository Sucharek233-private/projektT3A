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
            label1 = new Label();
            sibeniceInfo = new TableLayoutPanel();
            klavesnice = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            slovoContainer = new FlowLayoutPanel();
            sibenicePanacek = new FlowLayoutPanel();
            informace = new FlowLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            sibeniceInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(sibeniceInfo, 0, 1);
            tableLayoutPanel2.Controls.Add(klavesnice, 0, 3);
            tableLayoutPanel2.Controls.Add(slovoContainer, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Size = new Size(645, 355);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Papyrus", 20F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(639, 35);
            label1.TabIndex = 0;
            label1.Text = "Šibenice";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sibeniceInfo
            // 
            sibeniceInfo.ColumnCount = 2;
            sibeniceInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sibeniceInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sibeniceInfo.Controls.Add(sibenicePanacek, 0, 0);
            sibeniceInfo.Controls.Add(informace, 1, 0);
            sibeniceInfo.Dock = DockStyle.Fill;
            sibeniceInfo.Location = new Point(3, 38);
            sibeniceInfo.Name = "sibeniceInfo";
            sibeniceInfo.RowCount = 1;
            sibeniceInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            sibeniceInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sibeniceInfo.Size = new Size(639, 136);
            sibeniceInfo.TabIndex = 1;
            // 
            // klavesnice
            // 
            klavesnice.Dock = DockStyle.Fill;
            klavesnice.Location = new Point(0, 230);
            klavesnice.Margin = new Padding(0);
            klavesnice.Name = "klavesnice";
            klavesnice.Size = new Size(645, 125);
            klavesnice.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 355);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(645, 37);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(316, 31);
            button1.TabIndex = 0;
            button1.Text = "Vzdát se";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(325, 3);
            button2.Name = "button2";
            button2.Size = new Size(317, 31);
            button2.TabIndex = 1;
            button2.Text = "Ukončit";
            button2.UseVisualStyleBackColor = true;
            // 
            // slovoContainer
            // 
            slovoContainer.Dock = DockStyle.Fill;
            slovoContainer.Location = new Point(0, 177);
            slovoContainer.Margin = new Padding(0);
            slovoContainer.Name = "slovoContainer";
            slovoContainer.Size = new Size(645, 53);
            slovoContainer.TabIndex = 3;
            // 
            // sibenicePanacek
            // 
            sibenicePanacek.Dock = DockStyle.Fill;
            sibenicePanacek.Location = new Point(0, 0);
            sibenicePanacek.Margin = new Padding(0);
            sibenicePanacek.Name = "sibenicePanacek";
            sibenicePanacek.Size = new Size(319, 136);
            sibenicePanacek.TabIndex = 0;
            // 
            // informace
            // 
            informace.Dock = DockStyle.Fill;
            informace.Location = new Point(319, 0);
            informace.Margin = new Padding(0);
            informace.Name = "informace";
            informace.Size = new Size(320, 136);
            informace.TabIndex = 1;
            // 
            // Hra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 392);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Hra";
            Text = "Form1";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            sibeniceInfo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TableLayoutPanel sibeniceInfo;
        private FlowLayoutPanel klavesnice;
        private FlowLayoutPanel slovoContainer;
        private FlowLayoutPanel sibenicePanacek;
        private FlowLayoutPanel informace;
    }
}
