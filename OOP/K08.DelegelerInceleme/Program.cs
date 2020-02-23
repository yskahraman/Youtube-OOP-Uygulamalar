using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K08.DelegelerInceleme
{
    class Program
    {
        //delegate void BenimDelegem(string isim);
        static void Main(string[] args)
        {
            //BenimDelegem benimDelegem = new BenimDelegem(SelamVer);

            //benimDelegem += VedaEt;

            //benimDelegem.Invoke("Yavuz");

            //Func, Predicate, Action

            // Func herhangi=>herhangi
            // Predicate herhangi(1 tane)=> bool dönerim 
            // Action herhangi => bir şey dönmem

            List<string> isimler = new List<string>()
            {"yavuz","selim","ayse","ahmet","ersin","mahmut","ahmet"};

            Predicate<string> predicate = new Predicate<string>(AhmetiBul);

            var gelenIsimler = isimler.FindAll(I => I == "ahmet" ? true:false) ;

            //foreach (var item in gelenIsimler)
            //{
            //    Console.WriteLine(item);
            //}

            gelenIsimler.ForEach(I =>
            {
                Console.WriteLine(I);
            });
           

            Console.ReadKey();
        }

        static bool AhmetiBul(string deger)
        {
            //if (deger.ToLower() == "ahmet")
            //{
            //    return true;
            //}
            //return false;

            return deger.ToLower() == "ahmet" ? true : false;
        }

        //static void SelamVer(string deger)
        //{
        //    Console.WriteLine("Selam "+deger);
        //}
        //static void VedaEt(string ikinci)
        //{
        //    Console.WriteLine("Gule gule "+ikinci);
        //}
    }
}
