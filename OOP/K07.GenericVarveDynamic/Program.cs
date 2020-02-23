using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K07.GenericVarveDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //dynamic degisken = 1;
            //degisken = "yavuz";
            //degisken = 12312.312123;
            //degisken = 'a';

            //var degisken2 = 1;



            //Console.WriteLine(nameof(degisken));

            //Musteri<int, string> musteri = new Musteri<int, string>();

            //Console.WriteLine(musteri.Kaydet("yavuz"));
            //Console.WriteLine(musteri.Kaydet(1));

            PersonelIslem personelIslem = new PersonelIslem();
            personelIslem.DetayGetir();
            personelIslem.Sil();

            MusteriIslem musteriIslem = new MusteriIslem();
            musteriIslem.DetayGetir();
            musteriIslem.Sil();

            Console.ReadKey();
        }
    }


    //class Musteri<T,M>
    //{
    //    //int guid
    //    public T No { get; set; }
    //    //string
    //    public M Isim { get; set; }

    //    public Yavuz Kaydet<Yavuz>(Yavuz yavuz)
    //    {
    //        return yavuz;
    //    }
    //}

    //EntityFramework, Nhibernate, Dapper
    //db.Add(musteri);

    //Repository Design Pattern : Dont Repeat Yourself
    // Generic Repository Design Pattern


    class Musteri
    {
        public int No { get; set; }
        public string Isim { get; set; }
    }

  

    class Personel
    {
        public int No { get; set; }
        public string Isim { get; set; }
    }

    class MusteriIslem : Islem<Musteri>
    {

    }

    class PersonelIslem : Islem<Personel>
    {
       
    }

    class Islem<Tablo>
        where Tablo : class, new()
    {
       public void DetayGetir()
        {
            Tablo tablo = new Tablo();
            Console.WriteLine(tablo.ToString()+" detayı getirildi");
        }

       public void Sil()
        {
            Tablo tablo = new Tablo();
            Console.WriteLine(tablo.ToString() + " silindi");
        }
    }
}
