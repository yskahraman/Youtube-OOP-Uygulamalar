using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K01.TemelMantik
{
    class Program
    {
        static void Main(string[] args)
        {
           //Musteri musteri= new Musteri();
            // internal, public, private
            Musteri[] musteriler = new Musteri[1000];
            for (int i = 0; i < 1000; i++)
            {
                Musteri musteri1 = new Musteri();
                musteri1.musteriNo = i;
                musteri1.musteriAd = "Ad" + i;

                musteriler[i] = musteri1;
            }


            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(musteriler[i].musteriNo+"-"+musteriler[i].musteriAd);
            }

            Musteri musteri = new Musteri();
            musteri.musteriAd = "Yavuz";
            musteri.musteriNo = 1;


            Console.WriteLine(musteri.musteriAd);
            Console.ReadKey();
        }
    }
    class Musteri
    {
        public Musteri()
        {
            Console.WriteLine("Ben müşteri classının yapicisiyim");
        }
       public int musteriNo;
       public string musteriAd;
    }
}
