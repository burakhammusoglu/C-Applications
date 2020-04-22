using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayListApps
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Konu Anlatımı :
            /*Array List : Dinamik olarak büyüyüp küçülen,farklı değişken türlerini ve nesneleri depolayabilen koleksiyon tabanlı bir sınıftır.
            Diziler tanımlanırken tipi ve büyüklüğü belirtilmelidir ama arraylistte bu yoktur her tipten eleman alır ve boyutu eleman eklendikçe
            artar veya çıkartıldıkça azalır.
            */

            ArrayList liste = new ArrayList(); // Arraylist oluşumu
            ArrayList liste2 = new ArrayList();
            
            liste.Add("burak"); // Eleman ekleme
            liste.Add("5");
            liste.Add(5);
            liste.Add("Silme");
            liste.Remove("Silme"); // Elaman silme

            Console.WriteLine(liste[2]); // Listedeki verilere indis numaraları ile erişebiliriz 

            foreach(object item in liste) // Liste elemanlarını yazdırabiliriz
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(liste.Count); // Listenin içindeki toplam eleman sayısını int türünde gösteririr
            liste2.AddRange(liste);   // Listeyi bir başka listeye kopyalıyoruz 
            /* Diğer kullanılan önemli metodlar :
             Sort : Listedeki elemanları sıralar 
             Reverse : Listeyi ters çevirir 
             Clear : Tüm listeyi siler 
             BinarySearch : Liste içerisinde parametre olarak verilen değerin bulunup bulunmadığını arar. 
             Bulunursa indis numarasını döndürür, bulamazsa negatif bir değer döndürür. 
             BinarySearch ile arama yapmak için öncelikle listenin sıralanması gerekir.
             Copy To :Tüm listeyi ya da bir bölümünü diğer bir listeye kopyalar
             */


            Console.ReadLine();


            #endregion
            #region ArrayList Yardımcı Komutları :
            bool Kontrol1 = liste.Contains("Merve"); // Liste içinde böyle bir eleman var mı? Varsa true yoksa false değer döner.
            int indexDeger = liste.IndexOf("5"); // değerin index değerini getirir.
            liste.Clear(); // listeyi sil
            liste.TrimToSize(); // ilgili listenin boyutunu yeniden ayarla.Sildikten sonra kullanabiliriz.3
            // Silme:
            liste.Remove("sdsd"); // şu değeri sil
            liste.RemoveRange(2,2); // 2. indisten başlayarak 2 tane eleman sil
            liste.RemoveAt(2); // 2. indisteki değeri siler



            #endregion

        }
    }
}
