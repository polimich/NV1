using System;
using System.Collections.Generic;
using System.Text;

namespace NV1.Model
{
    public class Predskolak : Osoba
    {
        public Predskolak(int vek, Pohlavi pohlavi, string jmeno) : base(vek, pohlavi, jmeno)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " Předškolák";
        }
    }
}
