using System;

namespace ArrayOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //maak een array van 10 enemies het onderstaande code blok gaat werken

            Enemy[] enemies = new Enemy[10];
            // de manier waarop ik het heb opgelost is hier enemies initialiseren met een lengte van 10.
            // daarna kon ik er doorheen loopen en 1 object maken voor elk element in de array
            // niet bepaald makkelijk tbh


            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new Enemy(i);

                Console.WriteLine(enemies);
            }
        }
    }
}