using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    public class Akvarel : Barvy
    {
        public Typ TypAkvarelu;
        public enum Typ
        {
            Tuba,
            Panvicka,
            Tekuty
        }
    }
}
