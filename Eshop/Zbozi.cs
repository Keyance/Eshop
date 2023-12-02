using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
     abstract public class Zbozi
    {
        public double Cena;
        public string Nazev;
        public string Vyrobce;
        public int PocetNaSklade;
        public long EAN;

        public void Naskladni(int pocet)
        {
            PocetNaSklade += pocet;
        }

        public int Prodej(int pocet)
        {
            return PocetNaSklade - pocet;
        }

        public double ZjistiCenu(int pocet)
        {
            return pocet * Cena;
        }
    }
}
