using System;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 sayıdan büyük olan bulma
            int sayi1 = 10;
            int sayi2 = 20;
            if (sayi1 > sayi2)
            {
                Console.WriteLine("sayi1 büyük");
            }
            else
            {
                Console.WriteLine("sayi2 büyük");
            }
            Console.Clear();
            

            // kullanıcı girişli sayıların büyük olanı bulma
            string girilenDeger = string.Empty;
            string girilenDeger2 = string.Empty;
            Console.WriteLine("1. sayıyı girin");
            girilenDeger = Console.ReadLine();
            Console.WriteLine("2. sayıyı girin");
            girilenDeger2 = Console.ReadLine();
            sayi1 = Convert.ToInt32(girilenDeger);
            sayi2 = Convert.ToInt32(girilenDeger2);
            if (sayi1 > sayi2)
            {
                Console.WriteLine("sayı 1 büyük");

            }
            else
            {
                Console.WriteLine("sayı 2 büyük");
            }
            Console.Clear();


            // girilen vize ve final notlarına göre ögrnin dersten geçip geçmediğini hesaplayan program.
            float vize=0.0f;
            float final=0.0f;
            float notOrt = 0.0f;
            Console.WriteLine("Vize notunu girin");
            girilenDeger = Console.ReadLine();
            vize = int.Parse(girilenDeger);
            Console.WriteLine("Final notunu girin");
            girilenDeger2 = Console.ReadLine();
            final = int.Parse(girilenDeger2);

            notOrt = (vize * 0.4f) + (final * 0.6f);
            if (notOrt > 0)
            {
                if (notOrt > 85 && notOrt < 100) Console.WriteLine("AA");
                else if (notOrt > 70 && notOrt < 85) Console.WriteLine("BA");
                else if (notOrt > 60 && notOrt < 70) Console.WriteLine("BB");
                else if (notOrt > 50 && notOrt < 60) Console.WriteLine("CC");
                else if (notOrt > 35 && notOrt < 50) Console.WriteLine("DD");
                else if (notOrt < 35) Console.WriteLine("FF");
            }
            Console.Clear();

            // girilen tamsayının pozitif,negatif veya 0 oldugun bulan program
            int sayiNe;
            sayiNe = int.Parse(girilenDeger);
            if (sayiNe == 0) Console.WriteLine("Sayi Sıfırdır");
            else if (sayiNe < 0) Console.WriteLine("Sayi Sıfırdan Küçüktür");
            else if (sayiNe > 0) Console.WriteLine("Sayı Sıfırdan Büyüktür");

            Console.ReadLine();
        }
    }
}
