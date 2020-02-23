using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K03.ArrayListveList
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] adlar = new string[] {"yavuz","selim" };

            //ArrayList liste = new ArrayList();

            //liste.Add("yavuz");
            //liste.Add(1);
            //liste.Add('a');
            //liste.Add(123.2131);

            //liste.Add("selim");

            //ArrayList liste2 = new ArrayList();
            //liste2.Add("yavuz2");
            //liste2.Add("selim2");
            //liste2.Add(2);

            //Aynı
            //liste.AddRange(new ArrayList() { "yavuz2", "selim2", 2 });
            //liste.AddRange(liste2);



            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}




            //senaryo 
            // musteri nesnemi bir listede tutmak istiyorum. 

            List<string> isimler = new List<string>();
            isimler.Add("isim");
            List<int> sayilar = new List<int>() {1,2,3,4,5,6,7 };

            List<Musteri> musteriListesi = new List<Musteri>();
            
            //Dictionary Hashtable Queue

            //sayilar.Remove(2);
            //sayilar.RemoveAt(2);

            int toplam= sayilar.Sum();
            double ortalama= sayilar.Average();
            Console.WriteLine("sayilarin toplamı:"+ toplam);
            Console.WriteLine("sayilarin ortalaması:"+ortalama);

            Console.ReadKey();
        }

        class Musteri
        {
            public int MusteriNo { get; set; }
            public string MusteriIsim { get; set; }
        }

        class MusteriIslem
        {
            ArrayList musteriListesi = new ArrayList();

            public void MusteriKaydet(Musteri musteri)
            {
                musteriListesi.Add(musteri);
            }
        }
    }
}
