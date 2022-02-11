using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _KitapDukkani
{
    class Kitap
    {
        public string KitapAdi { get; set; }
        public string KitapTuru { get; set; }
        public int KitapSayfaSayisi { get; set; }
        public decimal KitapFiyat { get; set; }
        public Yazar KitapYazar { get; set; }
    
    
    }
}
