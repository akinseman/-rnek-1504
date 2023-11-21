namespace örnek_1504
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbatlar = new System.Windows.Forms.ListBox();
            this.btnaranan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtatlar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbatlar
            // 
            this.lbatlar.FormattingEnabled = true;
            this.lbatlar.Items.AddRange(new object[] {
            "semanur",
            "esma",
            "semanur",
            "esma",
            "aycan",
            "aycan",
            "sıla",
            "sıla",
            "semanur",
            "esmanur",
            "esmanur",
            "musa",
            "musa",
            "kenan",
            "kena",
            "musa",
            "kenan",
            ""});
            this.lbatlar.Location = new System.Drawing.Point(12, 5);
            this.lbatlar.Name = "lbatlar";
            this.lbatlar.Size = new System.Drawing.Size(190, 433);
            this.lbatlar.TabIndex = 0;
            this.lbatlar.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnaranan
            // 
            this.btnaranan.Location = new System.Drawing.Point(216, 12);
            this.btnaranan.Name = "btnaranan";
            this.btnaranan.Size = new System.Drawing.Size(75, 50);
            this.btnaranan.TabIndex = 1;
            this.btnaranan.Text = "aranan";
            this.btnaranan.UseVisualStyleBackColor = true;
            this.btnaranan.Click += new System.EventHandler(this.btnaranan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "......kişivar";
            // 
            // txtatlar
            // 
            this.txtatlar.Location = new System.Drawing.Point(208, 97);
            this.txtatlar.Name = "txtatlar";
            this.txtatlar.Size = new System.Drawing.Size(100, 20);
            this.txtatlar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.txtatlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaranan);
            this.Controls.Add(this.lbatlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbatlar;
        private System.Windows.Forms.Button btnaranan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtatlar;
    }
}

