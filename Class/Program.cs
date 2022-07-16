using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yasi = 23;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Burak Taha Koca";
            kurs2.İzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Erkan Koca";
            kurs3.İzlenmeOrani = 70;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Mehmet Yılmaz";
            kurs4.İzlenmeOrani = 00;

            //Console.WriteLine(kurs2.Egitmen + " ve " + kurs3.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1 , kurs2 , kurs3 , kurs4};
            foreach ( var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            //Console.WriteLine("Hello World !");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }

}