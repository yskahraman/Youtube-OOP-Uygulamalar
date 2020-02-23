using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K06.ThisPartialveAbstract
{
    class Program
    {
        static void Main(string[] args)
        {

            //Deneme deneme = new Deneme();

            //Console.ReadKey();
            //deneme.No = 5;

            //Console.WriteLine();

            Musteri musteri = new Musteri();
            musteri.No = 1;
            musteri.Isim = "Yavuz";
            musteri.Tarife = new BolDk();
            musteri.Tarife.FiyatHesapla(musteri.Isim);

            Musteri musteri2 = new Musteri();
            musteri2.No = 2;
            musteri2.Isim = "Ahmet";
            musteri2.Tarife = new BolGb();
            musteri2.Tarife.FiyatHesapla(musteri2.Isim);


            Console.ReadKey();
        }
    }

    abstract class Tarife
    {
        public abstract int Fiyat { get; set; }
        public abstract void FiyatHesapla(string isim);
    }

    class BolDk : Tarife
    {
        public override int Fiyat { get; set; } = 15;

        public override void FiyatHesapla(string isim)
        {
            Console.WriteLine($"Sayın {isim} aylık ödemeniz gereken ücret {Fiyat*2}");
        }
    }


    class BolGb : Tarife
    {
        public override int Fiyat { get; set; } = 20;

        public override void FiyatHesapla(string isim)
        {
            Console.WriteLine($"Sayın {isim} aylık ödemeniz gereken ücret {Fiyat * 2}");
        }
    }


    class Musteri
    {
        public int No { get; set; }
        public string Isim { get; set; }

        public Tarife Tarife { get; set; }
    }

    //interface IDeneme
    //{
    //    int No { get; set; }
    //}

    // yapıcısı var mı?
    //abstract class ADeneme
    //{
    //    public ADeneme()
    //    {
    //        Console.WriteLine("Yapıcım calisti");
    //    }
    //   public abstract int No { get; set; }
    //}

    //class Deneme : IDeneme
    //{
    //    public int No { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //}

    //class Deneme : ADeneme
    //{
    //    public override int No { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //}

    //partial class Musteri
    //{
    //    //public Musteri(int No, string Isim)
    //    //{

    //    //    this.No = No;
    //    //    this.Isim = Isim;
    //    //}

    //    public int No { get; set; } 
    //    public string Isim { get; set; }
    //}


    //partial class Musteri
    //{
    //    public string TelefonI { get; set; }
    //    public string Email { get; set; }
    //}
}
