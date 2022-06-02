using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proVĚRKA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zarovka zarovka = new Zarovka(false,35,0);

            //rozsveceni a zhasinani
            zarovka.Rozsvit();
            Console.WriteLine("sviti? " + zarovka.Sviti);
            zarovka.Zhasni(); 
            Console.WriteLine("sviti? " + zarovka.Sviti);
            zarovka.Rozsvit();
            Console.WriteLine("sviti? " + zarovka.Sviti);
            zarovka.Zhasni();
            Console.WriteLine("sviti? " + zarovka.Sviti);

            //vypsani prikonu
            Console.WriteLine("Prikon je: " + zarovka.Prikon);

            //vypsani poctu rozsviceni
            Console.WriteLine("Pocet rozsviceni je: " + zarovka.DejPocetRozsviceni());
            

            Console.ReadKey();
        }
    }
}
