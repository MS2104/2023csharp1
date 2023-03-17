using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Rectangle rect = new Rectangle();

            rect.x = 100;
            rect.y = 200;
            rect.width = 50;
            rect.height = 50;

            Console.WriteLine(rect.x);
            Console.WriteLine(rect.y);
            Console.WriteLine(rect.width);
            Console.WriteLine(rect.height);
        }
    }
}