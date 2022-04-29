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
    public partial class yeniKayit : Form
    {
        public yeniKayit()
        {
            InitializeComponent();
        }

        private void txtBaslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txtBaslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            todoService todoService = new todoService();
            int Sonuc = todoService.KayitYeni(new Entities.todo()
            {
                 id=Guid.NewGuid(),
                 baslik=txtBaslik.Text,
                 kisaAciklama=txtKisaAciklama.Text,
                 aciklama=txtAciklama.Text,
                  durumAciklama = cmbDurum.SelectedItem.ToString(),
                  onemDerece = int.Parse(txtDerece.Text),
                  olusturmaTarih = DateTime.Now


            });
            if (Sonuc > 0)
            {
                MessageBox.Show("Kayıt Ekleme İşlemi Başarılı ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result=MessageBox.Show("Yeni Kayıt Ekleme İşlemine Devam Etmek İster misiniz","Soru",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if( result == DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if(item is TextBox)
                        {
                            ((TextBox)item).Text = String.Empty;
                        }
                    }
                }
                else
                {
                    Form kayitListe = Application.OpenForms["kayitListe"];
                    if(kayitListe == null)
                    {
                        kayitListe=new kayitListe();
                        kayitListe.MdiParent = Application.OpenForms["Form1"];
                        kayitListe.StartPosition = FormStartPosition.CenterScreen;
                        kayitListe.Show();
                        this.Close();

                    }
                    else
                    {
                        GroupBox Liste = (GroupBox)kayitListe.Controls["grpBoxListe"];
                        DataGridView grdListe =(DataGridView)Liste.Controls["grdListe"];
                        List<todo> GuncelListe = todoService.KayitListe();
                        grdListe.DataSource = null;
                        grdListe.DataSource = GuncelListe;
                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt Ekleme İşleminde Hata ","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
