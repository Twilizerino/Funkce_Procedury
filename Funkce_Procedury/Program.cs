using System;

class Program
{
    // PROCEDURA – jen vypíše text
    static void VypisUvodniText()
    {
        Console.WriteLine("Program: kontrola plnoletosti");
    }

    // FUNKCE – vrátí true/false podle věku
    static bool JePlnolety(int vek)
    {
        return vek >= 18;
    }

    static void Main()
    {
        Console.Write("Zadej věk: ");
        int vek = int.Parse(Console.ReadLine());

        if (JePlnolety(vek))
        {
            Console.WriteLine("Jsi plnoletý!");
        }
        else
        {
            Console.WriteLine("Nejsi plnoletý");
        }

        Console.WriteLine("ENTER pro ukončení");
        Console.ReadLine();

        // FUNKCE – vrací int (součet dvou čísel)
        static int Secti(int a, int b)
        {
            return a + b;
        }

        // sčítání čísel pomocí FUNKCE
        int x = 5;
        int y = 7;
        int soucet = Secti(x, y);
        Console.WriteLine("Součet {0} + {1} = {2}", x, y, soucet);

        // volání PROCEDURY (vápus textu)
        VypisUvodniText();
    }

}