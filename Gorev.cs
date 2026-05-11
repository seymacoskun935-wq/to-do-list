using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Gorev
    {
        public string Ad { get; set; }
        public bool Tamamlandi { get; set; }
        public DateTime Tarih { get; set; }
        
        public Gorev(string ad)
        {
            Ad = ad;
            Tamamlandi = false;
            Tarih = DateTime.Now;
        }
        
    }
}
