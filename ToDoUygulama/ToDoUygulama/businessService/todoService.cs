using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoUygulama.DataBase;
using ToDoUygulama.Entities;

namespace ToDoUygulama.businessService
{
    public class todoService
    {   
        public int KayitKontrol()
        {
            return SanalDataBase.todoTablo.Count;
        }
        public List<todo> KayitListe()
        {
            return SanalDataBase.todoTablo;
        }
        public int KayitYeni(todo data)
        {
            try
            {
                SanalDataBase.todoTablo.Add(data);
                return 1;
            }
            catch (Exception ex)
            {

                return 0;
            }

        }

    }
}
