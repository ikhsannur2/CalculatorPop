namespace CalculatorPop
{
    partial class FrmAnak
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
            this.btnProses = new System.Windows.Forms.Button();
            this.Operasi = new System.Windows.Forms.Label();
            this.NilaiA = new System.Windows.Forms.Label();
            this.NilaiB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbOperasi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(262, 254);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(105, 35);
            this.btnProses.TabIndex = 0;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // Operasi
            // 
            this.Operasi.AutoSize = true;
            this.Operasi.Location = new System.Drawing.Point(136, 73);
            this.Operasi.Name = "Operasi";
            this.Operasi.Size = new System.Drawing.Size(64, 20);
            this.Operasi.TabIndex = 1;
            this.Operasi.Text = "Operasi";
            // 
            // NilaiA
            // 
            this.NilaiA.AutoSize = true;
            this.NilaiA.Location = new System.Drawing.Point(136, 130);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(53, 20);
            this.NilaiA.TabIndex = 2;
            this.NilaiA.Text = "Nilai A";
            // 
            // NilaiB
            // 
            this.NilaiB.AutoSize = true;
            this.NilaiB.Location = new System.Drawing.Point(140, 182);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(53, 20);
            this.NilaiB.TabIndex = 3;
            this.NilaiB.Text = "Nilai B";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 26);
            this.textBox2.TabIndex = 5;
            // 
            // cmbOperasi
            // 
            this.cmbOperasi.FormattingEnabled = true;
            this.cmbOperasi.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.cmbOperasi.Location = new System.Drawing.Point(251, 73);
            this.cmbOperasi.Name = "cmbOperasi";
            this.cmbOperasi.Size = new System.Drawing.Size(132, 28);
            this.cmbOperasi.TabIndex = 6;
            // 
            // FrmAnak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 358);
            this.Controls.Add(this.cmbOperasi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.Operasi);
            this.Controls.Add(this.btnProses);
            this.Name = "FrmAnak";
            this.Text = "FrmAnak";
            this.Load += new System.EventHandler(this.FrmAnak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label Operasi;
        private System.Windows.Forms.Label NilaiA;
        private System.Windows.Forms.Label NilaiB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbOperasi;
    }
}