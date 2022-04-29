namespace ToDoUygulama
{
    partial class yeniKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKisaAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDerece = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(102, 27);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(247, 20);
            this.txtBaslik.TabIndex = 0;
            this.txtBaslik.Enter += new System.EventHandler(this.txtBaslik_Enter);
            this.txtBaslik.Leave += new System.EventHandler(this.txtBaslik_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kısa Açıklama";
            // 
            // txtKisaAciklama
            // 
            this.txtKisaAciklama.Location = new System.Drawing.Point(102, 53);
            this.txtKisaAciklama.Multiline = true;
            this.txtKisaAciklama.Name = "txtKisaAciklama";
            this.txtKisaAciklama.Size = new System.Drawing.Size(247, 84);
            this.txtKisaAciklama.TabIndex = 1;
            this.txtKisaAciklama.Enter += new System.EventHandler(this.txtBaslik_Enter);
            this.txtKisaAciklama.Leave += new System.EventHandler(this.txtBaslik_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Önem Derecesi";
            // 
            // txtDerece
            // 
            this.txtDerece.Location = new System.Drawing.Point(102, 238);
            this.txtDerece.Name = "txtDerece";
            this.txtDerece.Size = new System.Drawing.Size(247, 20);
            this.txtDerece.TabIndex = 3;
            this.txtDerece.Enter += new System.EventHandler(this.txtBaslik_Enter);
            this.txtDerece.Leave += new System.EventHandler(this.txtBaslik_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(102, 143);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(247, 84);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.Enter += new System.EventHandler(this.txtBaslik_Enter);
            this.txtAciklama.Leave += new System.EventHandler(this.txtBaslik_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durum";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanamadı",
            "İptal Edildi",
            "Ertelendi"});
            this.cmbDurum.Location = new System.Drawing.Point(102, 267);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(247, 21);
            this.cmbDurum.TabIndex = 4;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(102, 294);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(247, 37);
            this.btnYeniKayit.TabIndex = 5;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // yeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 335);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDerece);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKisaAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yeniKayit";
            this.Text = "Todo-Yeni Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKisaAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDerece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button btnYeniKayit;
    }
}