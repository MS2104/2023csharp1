using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] supercreativearrayname = {0, 10, 20, 30, 40, 50, 60};

            int sum = Baller(supercreativearrayname);

            Console.WriteLine(sum);
        }

        static int Baller(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }   
}