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
            int rok;
            Console.WriteLine("Zadejte Jmeno");
            jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte pohlavi(0 - muz, 1 - zena)");
            pohlavi = (Pohlavi)int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte vek");
            vek = int.Parse(Console.ReadLine());
            var osoba = Osoba.getInstance(vek, pohlavi, jmeno);
            Console.WriteLine(osoba.ToString());
            Console.WriteLine("Zadejte o kolik let chcete zestarnout ");
            rok = int.Parse(Console.ReadLine());
            osoba = osoba.Starnuti(rok);
            Console.WriteLine(osoba.ToString());
            Console.WriteLine("Zadejte o kolik let chcete zestarnout ");
            rok = int.Parse(Console.ReadLine());
            osoba = osoba.Starnuti(rok);
            Console.WriteLine(osoba.ToString());

        }
    }
}
