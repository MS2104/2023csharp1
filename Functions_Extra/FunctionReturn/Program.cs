using System;

namespace FunctionReturnn
{
    class Program
    {
        static int RollNumber()
        {
            Random random = new();
            int result = random.Next(1, 101);
            return result;
        }

        static void Main (string[] args)
        {
            int randInt = RollNumber();
            Console.WriteLine(randInt);
        }
    }
}