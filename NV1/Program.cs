using NV1.Model;
using System;

namespace NV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int vek;
            string jmeno;
            bool pohlavi;
            Console.WriteLine("Zadejte Jmeno");
            jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte pohlavi(0 - muz, 1 - zena)");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                pohlavi = true;
            }
            else
            {
                pohlavi = false;
            }
            Console.WriteLine("Zadejte vek");
            vek = int.Parse(Console.ReadLine());
            var osoba = Osoba.getInstance(vek, pohlavi, jmeno);
            Console.WriteLine(osoba.ToString());

        }
    }
}
