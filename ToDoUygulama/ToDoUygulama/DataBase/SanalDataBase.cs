using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoUygulama.Entities;

namespace ToDoUygulama.DataBase
{
    public static class SanalDataBase
    {
        public static List<kullanici> kullaniciTablo;
        public static List<todo> todoTablo;

        static SanalDataBase()
        {
            kullaniciTablo = new List<kullanici>();
            kullaniciTablo.Add(new kullanici()
            {
                id = Guid.NewGuid(),
                kullaniciAdi = "test1",
                kullaniciSifre="1",

            });
            todoTablo = new List<todo>();
          
        }
        
    }
}
