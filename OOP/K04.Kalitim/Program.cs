using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K04.Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            //musteri;
            musteri.Test();

      

            MagazaSahip magazaSahip = new MagazaSahip();
            magazaSahip.Test();

            Personel personel = new Personel();
            personel.Test();

            Yavuz yavuz = new Yavuz();
          
            

            Console.ReadKey();
        }
    }
    class Yavuz
    {

    }

  


    // protected veya public özelliklerinin bir başka classta kullanılabilir olması
    class Insan
    {
        public Insan()
        {
            Console.WriteLine("Insanin yapici metodu");
        }

        public virtual void Test()
        {
            Console.WriteLine("Test");
        }

        public int No { get; set; }
        public string Isim { get; set; }
    }

    class Musteri : Insan
    {
        public Musteri()
        {
            Console.WriteLine("Musterinin yapıcı metodu");
        }

        public override void Test()
        {
            Console.WriteLine("Musteri test");
        }
        //public int MusteriNo { get; set; }
        //public string MusteriIsim { get; set; }
    }

    class Personel : Insan
    {
        //public int PersonelNo { get; set; }
        //public string PersonelIsim { get; set; }
        public decimal PersonelMaas { get; set; }

        public override void Test()
        {
            Console.WriteLine("Personel Test");
        }

    }

    class MagazaSahip : Insan
    {
        //public int No { get; set; }
        //public int Isim { get; set; }
        public string TelefonI { get; set; }

        public override void Test()
        {
            Console.WriteLine("Mağaza sahibi test");
        }
    }
    

}
