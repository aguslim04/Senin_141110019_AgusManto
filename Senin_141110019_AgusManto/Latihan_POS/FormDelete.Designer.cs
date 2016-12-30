namespace Latihan_POS
{
    partial class FormDelete
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
            this.Jenis = new System.Windows.Forms.Label();
            this.Kode = new System.Windows.Forms.Label();
            this.txtKodeHapus = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Jenis
            // 
            this.Jenis.AutoSize = true;
            this.Jenis.Location = new System.Drawing.Point(32, 67);
            this.Jenis.Name = "Jenis";
            this.Jenis.Size = new System.Drawing.Size(31, 13);
            this.Jenis.TabIndex = 7;
            this.Jenis.Text = "Type";
            // 
            // Kode
            // 
            this.Kode.AutoSize = true;
            this.Kode.Location = new System.Drawing.Point(31, 33);
            this.Kode.Name = "Kode";
            this.Kode.Size = new System.Drawing.Size(32, 13);
            this.Kode.TabIndex = 6;
            this.Kode.Text = "Kode";
            // 
            // txtKodeHapus
            // 
            this.txtKodeHapus.Location = new System.Drawing.Point(97, 30);
            this.txtKodeHapus.Name = "txtKodeHapus";
            this.txtKodeHapus.Size = new System.Drawing.Size(163, 20);
            this.txtKodeHapus.TabIndex = 8;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(97, 64);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(163, 21);
            this.cmbType.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hapus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 154);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtKodeHapus);
            this.Controls.Add(this.Jenis);
            this.Controls.Add(this.Kode);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            this.Load += new System.EventHandler(this.FormDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Jenis;
        private System.Windows.Forms.Label Kode;
        private System.Windows.Forms.TextBox txtKodeHapus;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}