namespace Marmara_Randevu_Sistemi
{
    public class Doktor
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Klinik Klinik { get; set; }

        public string AdSoyad
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }


}
