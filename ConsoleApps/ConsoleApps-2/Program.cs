using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1-100 arası tek sayılar yazdıran prog
            int i = 0;
            

            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Clear();

            //1-100 arası çift sayıları yazdıran prog
            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Clear();
            

            // klavyeden girilen sayı kadar faktoriyel hesaplayan program.
            String girilenDeger = string.Empty;
            Console.WriteLine("Faktoriyelini almak istediğiniz sayıyı girin :");
            girilenDeger = Console.ReadLine();
            int girilenSayı = Convert.ToInt32(girilenDeger);
            
            int sonuc = 1;
            if(girilenSayı==1 || girilenSayı == 0)
            {
                Console.WriteLine("sonuc = 1");
            }
            else {
                for (int a = 1; a <= girilenSayı; a++)
                {
                    sonuc = sonuc * a;
                    Console.WriteLine("Sonuc =" + sonuc);
                }
            }
            



            Console.ReadLine();
        }
    }
}
