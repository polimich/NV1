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
            Pohlavi pohlavi;
            Console.WriteLine("Zadejte Jmeno");
            jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte pohlavi(0 - muz, 1 - zena)");
            pohlavi = (Pohlavi)int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte vek");
            vek = int.Parse(Console.ReadLine());
            var osoba = Osoba.getInstance(vek, pohlavi, jmeno);
            Console.WriteLine(osoba.ToString());

        }
    }
}
