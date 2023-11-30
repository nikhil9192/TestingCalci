using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassLibrary
{
    public class Calci
    {
        public   int Numb1 { get; set; }
        public   int  Numb2 { get; set; }

        public int Add()
        {
            return Numb1 + Numb2;
        }
        public int Sub()
        {
            return Numb1 - Numb2;
        }
        public int Mul()
        {
            return Numb1 * Numb2;
        }

        public int Div()
        {
            return Numb1 / Numb2;
        }

        public int Sqt()
        {
            return Numb1 *Numb1;
        }
    }
}
