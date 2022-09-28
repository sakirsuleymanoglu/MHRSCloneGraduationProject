using System;

namespace Marmara_Randevu_Sistemi
{
    public class Kisi
    {
        public int Id { get; set; }
        public string KimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public DateTime DogumYili { get; set; }
        public string DogumYeri { get; set; }
        public string BabaAd { get; set; }
        public string AnneAd { get; set; }
        public string TelefonNo { get; set; }
        public string Eposta { get; set; }
        public string Parola { get; set; }
        public Guvenlik Guvevlik { get; set; }
        public string Cevap { get; set; }
    }
}
