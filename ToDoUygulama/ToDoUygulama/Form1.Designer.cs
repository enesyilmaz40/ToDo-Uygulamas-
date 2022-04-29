namespace ToDoUygulama
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
            this.components = new System.ComponentModel.Container();
            this.pnlIslemListesi = new System.Windows.Forms.Panel();
            this.grpBoxIslemListe = new System.Windows.Forms.GroupBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnKayitListe = new System.Windows.Forms.Button();
            this.btnUygulamaKapat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblZaman = new System.Windows.Forms.Label();
            this.tm_zamanla = new System.Windows.Forms.Timer(this.components);
            this.pctbox = new System.Windows.Forms.PictureBox();
            this.pnlIslemListesi.SuspendLayout();
            this.grpBoxIslemListe.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIslemListesi
            // 
            this.pnlIslemListesi.Controls.Add(this.pctbox);
            this.pnlIslemListesi.Controls.Add(this.grpBoxIslemListe);
            this.pnlIslemListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIslemListesi.Location = new System.Drawing.Point(0, 0);
            this.pnlIslemListesi.Name = "pnlIslemListesi";
            this.pnlIslemListesi.Size = new System.Drawing.Size(200, 512);
            this.pnlIslemListesi.TabIndex = 1;
            // 
            // grpBoxIslemListe
            // 
            this.grpBoxIslemListe.Controls.Add(this.btnUygulamaKapat);
            this.grpBoxIslemListe.Controls.Add(this.btnKayitListe);
            this.grpBoxIslemListe.Controls.Add(this.btnYeniKayit);
            this.grpBoxIslemListe.Location = new System.Drawing.Point(3, 66);
            this.grpBoxIslemListe.Name = "grpBoxIslemListe";
            this.grpBoxIslemListe.Size = new System.Drawing.Size(194, 116);
            this.grpBoxIslemListe.TabIndex = 3;
            this.grpBoxIslemListe.TabStop = false;
            this.grpBoxIslemListe.Text = "İşlem Listesi";
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(41, 19);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(115, 23);
            this.btnYeniKayit.TabIndex = 4;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnKayitListe
            // 
            this.btnKayitListe.Location = new System.Drawing.Point(41, 48);
            this.btnKayitListe.Name = "btnKayitListe";
            this.btnKayitListe.Size = new System.Drawing.Size(115, 23);
            this.btnKayitListe.TabIndex = 4;
            this.btnKayitListe.Text = "Kayıt Listele";
            this.btnKayitListe.UseVisualStyleBackColor = true;
            this.btnKayitListe.Click += new System.EventHandler(this.btnKayitListe_Click);
            // 
            // btnUygulamaKapat
            // 
            this.btnUygulamaKapat.Location = new System.Drawing.Point(41, 77);
            this.btnUygulamaKapat.Name = "btnUygulamaKapat";
            this.btnUygulamaKapat.Size = new System.Drawing.Size(115, 23);
            this.btnUygulamaKapat.TabIndex = 4;
            this.btnUygulamaKapat.Text = "Uygulama Kapat";
            this.btnUygulamaKapat.UseVisualStyleBackColor = true;
            this.btnUygulamaKapat.Click += new System.EventHandler(this.btnUygulamaKapat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblZaman);
            this.panel1.Location = new System.Drawing.Point(903, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 47);
            this.panel1.TabIndex = 2;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(75, 13);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(165, 25);
            this.lblZaman.TabIndex = 0;
            this.lblZaman.Text = "13.02.2019 20:08";
            // 
            // pctbox
            // 
            this.pctbox.Image = global::ToDoUygulama.Properties.Resources.icons8_todo_list_48px;
            this.pctbox.Location = new System.Drawing.Point(75, 12);
            this.pctbox.Name = "pctbox";
            this.pctbox.Size = new System.Drawing.Size(48, 48);
            this.pctbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox.TabIndex = 4;
            this.pctbox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlIslemListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Todo-Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlIslemListesi.ResumeLayout(false);
            this.grpBoxIslemListe.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIslemListesi;
        private System.Windows.Forms.GroupBox grpBoxIslemListe;
        private System.Windows.Forms.Button btnUygulamaKapat;
        private System.Windows.Forms.Button btnKayitListe;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer tm_zamanla;
        private System.Windows.Forms.PictureBox pctbox;
    }
}

