using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe","Yılmaz","İK");
            Calisan calisan1 = new Calisan("Deniz","Arda","İK");
            Calisan calisan2 = new Calisan("Muhammed","Salih","İK");

            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100,200));
            Console.WriteLine("Cıkarma işlemi sonucu: {0}", Islemler.Cıkar(400,50));


            

        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;
        private string Soyisim;
        private string Deparman;

        static Calisan(){
            calisanSayisi = 0;
        }

        public Calisan(string ısim, string soyisim, string deparman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Deparman = deparman;
            calisanSayisi++;
        }

    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cıkar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }    
}