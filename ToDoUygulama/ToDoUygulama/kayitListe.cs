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
    
    public partial class kayitListe : Form
    {
        todoService todoService;
        public kayitListe()
        {
            InitializeComponent();
            todoService = new todoService();

        }

        private void kayitListe_Load(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe();
            
        }
        private List<todo> TumListe()
        {
            return todoService.KayitListe();
        }

        private void btnTumListe_Click(object sender, EventArgs e)
        {
            grdListe.DataSource=TumListe();
        }

        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(i=>i.durumAciklama =="Tamamlandı").ToList();
        }

        private void btnTamamlanamadi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(i => i.durumAciklama == "Tamamlanamadı").ToList();
        }

        private void btnIptalEdildi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(i => i.durumAciklama == "İptal Edildi").ToList();
        }
    }
}
