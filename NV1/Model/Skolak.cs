using System;
using System.Collections.Generic;
using System.Text;

namespace NV1.Model
{
    class Skolak : Osoba
    {
        public Skolak(int vek, bool pohlavi, string jmeno) : base(vek, pohlavi, jmeno)
        {

        }
        public override string ToString()
        {
            return base.ToString() + "Školák";
        }
    }
}
