using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorKarsılastırmaDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // is ve as parametreleri
            object O1 = "Burak";
            bool veriTipi = O1 is int;   // O1 objesi integer mi diye bakıyoruz.
            object O2 = "MBurak";
            string veriTipi2 = O2 as string; // O2 objesini veriTipi2'ye stringe çevirip ata

            //foreach döngüsü kullanımı ve kullanma şekli

            string [] Isımler = { "burak", "mehmet", "hasan" };
            foreach (string item in Isımler)
            {
                Console.WriteLine(item);
            }

            // do-while döngüsü :
            // do-while döngüsü ne olursa olsun bir kere çalışır.
            do
            {
                Console.WriteLine("burak");
            } while (1==2);  // bu örnekte 1, 2'ye eşit olmadığı için çalışmayacak ama do while oldugu için 1 kere burak yazdırıp bitirecek.

            

            Console.ReadLine();
        }
    }
}
