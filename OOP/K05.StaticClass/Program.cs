using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K05.StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //listem musteri ekleyip musteri sileyim




            Musteri eklenecekMusteri = new Musteri() { MusteriNo = 2, MusteriIsim = "Ahmet" };

            MusteriIslem.Kaydet(eklenecekMusteri);

            MusteriIslem.Listele();

            PersonelIcinGerekenler personelIcinGerekenler = new Personel();
            //Dependency Injection...

            personelIcinGerekenler.PersonelIsim = "Yavuz";

            Console.WriteLine(personelIcinGerekenler.PersonelIsim);

            PersonelIcinGerekenler personelIcinGerekenler2 = new Personel();
            personelIcinGerekenler2.PersonelIsim = "Ahmet";
            Console.WriteLine(personelIcinGerekenler2.PersonelIsim);

            Console.ReadKey();
        }
    }

    class Musteri
    {
        public int MusteriNo { get; set; }
        public string MusteriIsim { get; set; }

        public override string ToString()
        {
            return "MusteriNo:" + MusteriNo + " Musteri İsim :" + MusteriIsim;
        }
    }

    interface PersonelIcinGerekenler
    {
        int PersonelNo { get; set; }
        string PersonelIsim { get; set; }
        void MaasiniGoster();
    }

    //extends implements
    class Personel : PersonelIcinGerekenler
    {
        public int PersonelNo { get; set; }

        public string PersonelIsim { get ; set ; }

        public void MaasiniGoster()
        {
            throw new NotImplementedException();
        }

        //public int PersonelYas { get; set; }
    }

    static class MusteriIslem
    {
        public static List<Musteri> musteriler;
        static MusteriIslem()
        {
            musteriler = new List<Musteri>();
            musteriler.Add(new Musteri() { MusteriNo = 1, MusteriIsim = "Yavuz" });
            //Console.WriteLine("static yapıcı çalıştı");
        }

        public static void Kaydet(Musteri musteri)
        {
            musteriler.Add(musteri);
        }

        public static void Sil(Musteri musteri)
        {
            musteriler.Remove(musteri);
        }

        public static void Listele()
        {
            foreach (var item in MusteriIslem.musteriler)
            {
                Console.WriteLine(item);
            }
        }
    }

}
