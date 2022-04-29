using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoUygulama.DataBase;
using ToDoUygulama.Entities;

namespace ToDoUygulama.businessService
{
    public class kullaniciService
    {
        public kullanici KullaniciKontrol(string kullaniciAdi,string sifre)
        {
            return SanalDataBase.kullaniciTablo.Where(i=>i.kullaniciAdi==kullaniciAdi && i.kullaniciSifre==sifre).FirstOrDefault();
        }
    }
}
