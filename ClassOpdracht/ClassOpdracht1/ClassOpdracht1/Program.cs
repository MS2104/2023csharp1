using System;

namespace ClassOpdracht1
{
    // Schrijf met commentaar(//dit is commentaar) in deze file de naam bij elk onderdeel 
    // Ik neem aan dat u hiermee bedoelt dat ik moet uitleggen wat elke functie doet, toch? toch?
    // sweating.png
    internal class ClassStructureExercise
    {
        private readonly string accountName;

        internal ClassStructureExercise(string accountName)
        {
            this.accountName = accountName;

            // we maken een accountname object aan
        }

        internal void ShowGreetingInConsole()
        {
            string greeting = "hello";
            Console.WriteLine(greeting + " " + accountName);

            // we maken een string variable aan genaamd "hello"
            // en groeten de gebruiker in de console
        }

        internal void Show1To10()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }

            // we printen alle getallen van 1 - 10 uit
        }

        internal double DistBetweenPoints(int x1, int y1, int x2, int y2)
        {

            int dx = x2 - x1;
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy);

            double length = Math.Sqrt(lengthSquared);
            return length;

            // afstand tussen 2 punten
        }
        internal int MultiplyToPower2(int value)
        {
            int result = value * value;
            return result;

            // value tot de macht 2
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // main bs whatever
        }
    }
}