using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoUygulama.businessService;
using ToDoUygulama.Entities;

namespace ToDoUygulama
{
    public partial class sistemGiris : Form
    {
        public sistemGiris()
        {
            InitializeComponent();
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T =(TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKullaniciAdi.Text) || !string.IsNullOrEmpty(txtSifre.Text))
            {
                kullaniciService kullaniciService = new kullaniciService();
                kullanici kontrolKullanici= kullaniciService.KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text);
                if (kontrolKullanici != null)
                {
                    Form anaForm = Application.OpenForms["Form1"];
                    Panel solPanel = (Panel)anaForm.Controls["pnlIslemListesi"];
                    GroupBox gbIslemListe = (GroupBox)solPanel.Controls["grpBoxIslemListe"];
                    foreach (Control item in gbIslemListe.Controls)
                    {
                        if(item is Button)
                        {
                            item.Enabled = true;
                        }
                    }
                    MessageBox.Show("Merhaba "+ kontrolKullanici.kullaniciAdi,"Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Giriş Bilgilerinizi Eksiksiz Olarak Giriniz.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
