using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Rectangle
    {
        // deze opdracht zou in 10 minuten gedaan moeten zijn maar ik ben gewoon zo slecht in lezen
        // het duurde me 40 minuten :((((((

        private int x, y, width, height;
        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void RectInfo()
        {
            Console.WriteLine($"The rectangle is located at x{x} y{y}. It is {height} pixels long and {width} pixels wide.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(100, 200, 50, 50);
            r.RectInfo();
        }
    }
}