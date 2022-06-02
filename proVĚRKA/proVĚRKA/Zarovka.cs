using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proVĚRKA
{
    public class Zarovka
    {
        private static bool sviti;
        private int prikon;
        private static int pocetRozsviceni;

        public Zarovka()
        {

        }

        public Zarovka(bool sviti, int prikon, int pocetRozsviceni)
        {

        }

        //vlastnosti
        public bool Sviti
        {
            get { return sviti; }
        }
        public int Prikon
        {
            get { return this.prikon; }
        }

        public void Rozsvit()
        {
            sviti = true;
            pocetRozsviceni += 1;
        }
        public void Zhasni()
        {
            sviti = false;
        }
        public int DejPocetRozsviceni()
        {
            return pocetRozsviceni;
        }
    }
}
