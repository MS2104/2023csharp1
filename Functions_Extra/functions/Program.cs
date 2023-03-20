using System;

namespace functionsOpdracht // Ik ben nou eenmaal slecht met namen
{
    class Program
    {
        static void Main(string[] args) 
        {
            int nummer = 14;
            string tekst = "Hello World!";

            IkBenSlechtMetNamen(nummer, tekst);
        }

        static void IkBenSlechtMetNamen(int nummer, string tekst)
        {
            Console.WriteLine(tekst);
            Console.WriteLine(nummer);
        }
    }
}