using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    public class Bloky : Papiry
    {
        public Varianty Varianta;
        public enum Varianty
        {
            Krouzkovy,
            Lepeny,
            LepenyNaVsechStranach,
            Sity,
            Sponkovany
        }
    }
}
