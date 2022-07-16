using System;

namespace DenemeProje
{

class Program
    {

        static void Main(string[] args)
        {

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 30000;
            long izlenmesayisi = 30000000000000;
            double faizorani = 1.15;
            bool sistemegirisyapmismi = true;
            double dolardun = 17.50;
            double dolarbugun = 17.75;

            if (dolardun > dolarbugun)
            {
                Console.WriteLine("Azalış butonu");
            }

            else if (dolarbugun > dolardun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Değiştir butonu");
            }

            if (sistemegirisyapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }

    }


}


