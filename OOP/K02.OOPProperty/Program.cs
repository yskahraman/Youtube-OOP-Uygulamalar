using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K02.OOPProperty
{
    class Program
    {
        static void Main(string[] args)
        {
           Musteri musteri=  new Musteri();

          

            //int girilenDeger = 19;
            //if (girilenDeger>18)
            //{
            //    musteri.yas = girilenDeger;
            //}

            //Console.WriteLine("Sayın"+ musteri.musteriIsim+" borcunuz 180 Tl");

            musteri.MusteriIsim = "Yavuz";

            Console.WriteLine(musteri.MusteriIsim);

            musteri.Yas = 15;

            Console.ReadKey();
        }
    }

    class Musteri
    {
        //private int musteriNo;
        //public int MusteriNo
        //{
        //    get
        //    {
        //        return musteriNo;
        //    }
        //    set
        //    {
        //        musteriNo = value;
        //    }
        //}

        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}


        public int MusteriNo { get; set; }
        //18 den aşağı girilemesin
        private int yas;
        public int Yas
        {
            get
            {
                return yas;
            }
            set
            {
                if (value > 18)
                {
                    yas = value;
                }
                else
                {
                    Console.WriteLine("Yaş 18 den küçük olamaz");
                }
            }
        }

        private string musteriIsim;

        public string MusteriIsim
        {
            get
            {
                return "Sayın "+musteriIsim;
            }
            set
            {
                musteriIsim = value;
            }
        }

       
    }
}
