﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NV1.Model
{
    public enum Pohlavi
    {
        Muž,
        Žena
    }
    public class Osoba
    {
        private readonly int _vek;
        private readonly Pohlavi _pohlavi; //0 - muz 1 - zena
        private readonly string _jmeno;
        public int Vek
        {
            get
            {
                return _vek;
            }
        }
        public Pohlavi Pohlavi
        {
            get
            {
                return _pohlavi;
            }
        }
        public string Jmeno
        {
            get
            {
                return _jmeno;
            }
        }
        protected Osoba(int vek, Pohlavi pohlavi, string jmeno)
        {
            _jmeno = jmeno;
            _vek = vek;
            _pohlavi = pohlavi;
        }
        public static Osoba getInstance(int vek, Pohlavi pohlavi, string jmeno)
        {
            Osoba osoba = new Osoba(vek, pohlavi, jmeno);
            if (osoba.Vek > 0)
            {
                if (osoba.Vek > 7)
                {
                    if (osoba.Vek > 19)
                    {
                        if (osoba.Vek > 65)
                        {
                            return new Duchodce(vek, pohlavi, jmeno);
                        }
                        return new Pracujici(vek, pohlavi, jmeno);
                    }
                    return new Skolak(vek, pohlavi, jmeno);
                }
                return new Predskolak(vek, pohlavi, jmeno);
            }
            else
            {
                return null;
            }


        }
        public override string ToString()
        {
            return Jmeno + " " + Pohlavi.ToString() + " " + Vek.ToString();
        }
        public Osoba Starnuti(int rok)
        {
            return getInstance(this.Vek + rok, this.Pohlavi, this.Jmeno);
        }
    }
}
