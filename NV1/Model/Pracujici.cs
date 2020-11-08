using System;
using System.Collections.Generic;
using System.Text;

namespace NV1.Model
{
    public class Pracujici : Osoba
    {
        public Pracujici(int vek, Pohlavi pohlavi, string jmeno) : base(vek, pohlavi, jmeno)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " Pracující";
        }
    }
}
