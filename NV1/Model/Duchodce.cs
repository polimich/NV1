using System;
using System.Collections.Generic;
using System.Text;

namespace NV1.Model
{
    public class Duchodce : Osoba
    {
        public Duchodce(int vek, Pohlavi pohlavi, string jmeno) :base(vek,pohlavi,jmeno)
        {
            
        }
        public override string ToString()
        {
            return base.ToString() + " Důchodce";
        }
    }
}
