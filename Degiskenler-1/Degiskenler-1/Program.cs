using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Degiskenler :

            bool boolean = false; // true & false
            byte bayt = 8; // 0-255
            char karekter = 'a';
            char karekterIki = 'A';
            char karekterUc = '2';
            decimal desimal = 33.92321321321M; // baya büyük virgüllü
            double ondalıkSayi = 1.203d; // 64 bit çok büyük sayılar
            float ondalıkSayiIki = 2.2222f; // 32 bit  büyük sayılar
            int tamSayi = 5; // 32 bit büyük buda baya 
            long tamSayi2 = 10; // 64 bit buda çok büyük sayılar 
            sbyte isaretliByte = 127; // işaretli byte -128 - 127 
            short isaretliTamSayi = 23232 ;
            uint isaretsizTamSayi = 10; // 0dan büyük degerler verilir.
            ulong isaretsizTamSayi2 = 22222222222; // 0 dan büyük değerler verilir.
            ushort isaretsizTamsayi3 = 23232;//0 dan büyük tam sayılar verilir.


            Console.WriteLine("boolean deger =" + boolean);
            Console.WriteLine("bayt deger = " + bayt);
            Console.WriteLine("karekter 1= " + karekter + " karekter2 =" + karekterIki + " karekter3 =" + karekterUc);
            Console.WriteLine("desimal sayi =" + desimal);
            Console.WriteLine("double sayi= " + ondalıkSayi + " float sayi = " + ondalıkSayiIki);
            Console.WriteLine("int sayi =" + tamSayi + " long sayi = " + tamSayi2);
            Console.WriteLine("isaretli byte = " + isaretliByte);
            Console.WriteLine("isaretli short sayi = " + isaretliTamSayi);
            Console.WriteLine("isaretsiz uint sayi = " + isaretsizTamSayi2 + " isaretsiz ulong sayi =" + isaretsizTamSayi +
                " isaretsiz ushort sayi =" + isaretsizTamsayi3);

            //Degiskenlerin alabileceği minumum ve maximum değerlerini bulmak için :
            //min.Value && max.Value kullanılabilir.

            int minDeger = int.MinValue;
            int maxDeger = int.MaxValue;
            Console.WriteLine("Min Deger =" + minDeger);
            Console.WriteLine("Max Deger =" + maxDeger);

            // Sabit değer atama :
            
            const int sabitSayi = 20; // burada sabitSayi program boyunca 20 dir, başka bir yerde değiştirilemez.

            // Tür dönüşümleri :

            int sayi;
            sayi = 255;

            // bilinçli tür dönüşümü : 
            byte sayi2;
            sayi2 = (byte)sayi;

            // bilinçsiz tür dönüşümü : 
            double sayi3;
            sayi3 = sayi; // burada herhangi bir hata almayız çünkü double türü integer türünüde kapsar
                          // sayi = sayi3; // burada hata verdi çünkü integer double türünü kapsamıyor double daha büyük

            // Checked ve Uncheked işlemleri :
            // Checked bir hata olduğu zaman hata bildirimi verir , Unchecked vermez 

            unchecked
            {
                int sayi5 = 1233;
                sayi2 = (byte)sayi5; // burada hata vermeyecektir çünkü hata vermemesini söyledik
            }
            
            checked
            {
                int sayi4 = 512;
                sayi2 = (byte)sayi4; // burada hata verecektir çünkü checked ile hata vermesini söyledik
            }

            // object  veri tipi : Object veri tipi .netframeworktaki değişkenlerin atasıdır.

            object temelTip;
            // kutulama : boxing - unboxing işlemleri
            temelTip = sayi2; // boxing
            sayi3 = (int)temelTip; //unboxing 
            */
            string kullanıcıdanGelenDeger = string.Empty;
            Console.WriteLine("lütfen adınızı girin");
            kullanıcıdanGelenDeger = Console.ReadLine();
            //Console.WriteLine(kullanıcıdanGelenDeger);

            
            int sayi2 = int.Parse
                (kullanıcıdanGelenDeger);
            int toplam = sayi2 + 10;
            Console.WriteLine(toplam);
















            Console.ReadLine();

            
        }
    }
}