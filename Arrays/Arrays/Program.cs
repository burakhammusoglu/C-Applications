using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //Kullanıcı dizinin boyutunu ve elemanlarını giricek ve dizinin toplamı ve ortalaması hesaplanacak
            Console.Write("Dizinin Boyutunu Girin : ");
            string kullanıcıDiziBoyut = string.Empty;
            string kullanıcıDiziDeger = string.Empty;
            kullanıcıDiziBoyut = Console.ReadLine();
            int diziBoyut = int.Parse(kullanıcıDiziBoyut);
            int diziElaman = 0;
            int diziOrtalaması = 0;
            int diziToplamı = 0;
            
            
            int[] dizi = new int[diziBoyut];
            for(int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("Dizinin " + i + ". elamnı girin");
                kullanıcıDiziDeger = Console.ReadLine();
                diziElaman = int.Parse(kullanıcıDiziDeger);
                dizi[i] = diziElaman;
    
            }
            for(int j = 0; j < dizi.Length; j++)
            {
                diziToplamı = diziToplamı + dizi[j];

            }
            diziOrtalaması = diziToplamı / dizi.Length;

            Console.WriteLine("Dizi toplamı : " + diziToplamı);
            Console.WriteLine("Dizi ortalaması : " + diziOrtalaması);
            #endregion
            #region //10 elemanlı bir dizi oluşturalım ve buna random sayı atayalım(1-10) ilgili diziyi ve hangi sayıdan kaç tane oldugunu ekrana yazdır
            int[] dizi2 = new int[10];
            int kacAdet = 0;
            Random rnd = new Random();
            for(int i = 0; i < dizi.Length; i++)
            {
                dizi2[i] = rnd.Next(1, 10);
            }
            foreach(int item in dizi2)
            {
                Console.WriteLine(item);
                if (item == 4)
                    kacAdet++;
            }
            Console.WriteLine("kac adet 4 :" + kacAdet);
            #endregion

            Console.ReadLine();


        }
    }
}
