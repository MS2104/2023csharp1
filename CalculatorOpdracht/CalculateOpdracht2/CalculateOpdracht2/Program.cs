using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan nu dingen kopen

            int controllersInMandje = 0;


            //koop 2 controllers
            controllersInMandje = controllersInMandje + 2;


            //hij is in voorraad snel kopen!
            int ps5 = 0;

            //koop 1 ps5
            ps5 = ps5 + 1;


            //koop de games:

            int eldenRing = 0;

            int shantae = 0;

            int spongebob = 0;

            spongebob = shantae = eldenRing = 1;
            // jaahaa ik weet dat het niet zo hoort maar kijk waarom zo moeilijk
            // als het makkelijk kan


            //hmmm weten we het zeker?
            //haal 1 game weg met -- of -= 1

            shantae = shantae -= 1;

            //nu nog de prijs


            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gamePrijs = 59.99;


            double totaalControllerPrijs = controllersInMandje * controllerPrijs; // controllersInMandje keer controllerPrijs
            double totaalGamePrijs = (spongebob + eldenRing) * gamePrijs; // game1 keer gamePrijs  + game2 keer gamePrijs (let op je haakjes!)
            



            double totaalPrijs = ((ps5Prijs * ps5) + totaalControllerPrijs + totaalGamePrijs); // tel hier alles bij elkaar op

            Console.WriteLine("De totaalprijs is: " + totaalPrijs);

            //er moet nu 759.95 staan
        }
    }
}