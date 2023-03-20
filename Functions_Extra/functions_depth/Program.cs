using System;

namespace functions_depth
{
    class Program
    {
        string text = "Hello World!";
        int getal = 14;
        bool mewhenthe = true;

        static void Main(string[] args)
        {
            StringFunctie1(tekst, getal);
        }
        static void StringFunctie1(string tekst)
        {
            StringFunctie2();
        }

        static void StringFunctie2(string tekst, int getal)
        {
            StringFunctie3();
        }

        static void StringFunctie3(string tekst, int getal, bool mewhenthe)
        {
            if (mewhenthe)
            {
                Console.WriteLine(tekst);
                Console.WriteLine(getal);
                Console.WriteLine(mewhenthe);
            }
        }
    }
}