using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListsOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ornek bir arraylist tanımla ve kullanıcı istediği işlemi yapsın.
            ArrayList array = new ArrayList();
            array.Add("burak");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin");
            Console.WriteLine("1-Listeye eklemek için");
            Console.WriteLine("2-Değerleri listele");
            Console.WriteLine("3-Değer ara");
            Console.WriteLine("4-Değer düzenle");
            Console.WriteLine("5-Değer sil");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
            string kullanıcıSecim = Console.ReadLine();
            
            switch (kullanıcıSecim)
            {
                case "1":
                    Console.WriteLine("Eklemek istediğiniz değeri yazınız:");
                    string kullanıcıEkle = Console.ReadLine();
                    array.Add(kullanıcıEkle);
                    Console.WriteLine("Eklemek istediğiniz değer başarıyla eklendi");
                    System.Threading.Thread.Sleep(2000);
                        break;
                case "2":
                    for(int i = 0; i < array.Count; i++)
                    {
                        Console.WriteLine(i + ". Değer" + array[i]);
                    }
                    Console.WriteLine("bir tuşa basın");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Aramak istediğiniz değeri girin:");
                    string kullanıcıAra = Console.ReadLine();
                    bool varMı = array.Contains(kullanıcıAra);
                    if (varMı == true)
                    {
                        int indexDeger = array.IndexOf(kullanıcıAra);
                        Console.WriteLine("Değer listede mevcut ve index değeri :" +indexDeger);
                    }
                    else Console.WriteLine("Değer listede mevcut değil");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Listeyi normal sıralamak için 1 " +
                        "ters sıralamak için 2'ye basın");
                    string kullanıcıSırala = Console.ReadLine();
                    if (kullanıcıSırala == "1")
                    {
                        array.Sort();
                        for(int j = 0; j < array.Count; j++)
                        {
                            Console.WriteLine("Listenin sıralı hali :" + array);
                        }

                    }
                    else
                    {
                        array.Reverse();
                        for(int k = 0; k < array.Count; k++)
                        {
                            Console.WriteLine("Listenın ters sıralanmış hali :" + array);
                        }
                    }
                    Console.ReadLine();

                    break;
                case "5":
                    Console.WriteLine("Silenecek değeri girin:");
                    string kullanıcıSil = Console.ReadLine();
                    array.Remove(kullanıcıSil);
                    break;
                default:
                    break;



            }while (kullanıcıSecim != "6") ;

        }
    }
}
