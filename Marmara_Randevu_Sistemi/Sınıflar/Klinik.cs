using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmara_Randevu_Sistemi
{
    public class Klinik
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public Hastane Hastane { get; set; }
    }
}
