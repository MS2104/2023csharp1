using System;

namespace functions_depth
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Hello World!";
            FirstFunction(tekst);
        }
        static void FirstFunction(string str)
        {
            int getal = 42;
            SecondFunction(str, getal);
        }

        static void SecondFunction(string str, int num)
        {
            bool thisiabool = true;
            ThirdFunction(str, thisiabool, num);
        }

        static void ThirdFunction(string str, bool boolname, int num)
        {
            Console.WriteLine("string: " + str);
            Console.WriteLine("boolean: " + boolname);
            Console.WriteLine("integer: " + num);
        }
    }
}