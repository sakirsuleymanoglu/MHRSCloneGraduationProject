﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmara_Randevu_Sistemi
{
    public class Hastane
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public Ilce Ilce { get; set; }
        public string Adres { get; set; }
    }
}
