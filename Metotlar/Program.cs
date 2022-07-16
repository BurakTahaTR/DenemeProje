using System;

namespace Metotlar

{
    class Program
    {
      static void Main(string[] args)
        {
            string urunAdi = "Bilgisayar";
            double urunfiyat = 9999;
            string urunaciklama = "Güzel Bilgisayar";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Bilgisayar";
            urun1.Fiyati = 9999;
            urun1.Aciklama = "Güzel Bilgisayar";

            Urun urun2 = new Urun();
            urun2.Adi = "Oyun Konsolu";
            urun2.Fiyati = 4999;
            urun2.Aciklama = "Güzel Konsol";
            Urun[] urunler = new Urun[] {urun1,urun2};
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine("------------Metotlar---------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", 15, "Sarı Armut",5000); 
            sepetManager.Ekle2("Elma", 13, "Yeşil Elma",50);
            sepetManager.Ekle2("Çilek", 10, "Taze Çilek",15000);
        }
    }
    
}
    
