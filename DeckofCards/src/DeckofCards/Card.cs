using System;
using System.Dynamic;
using System.Globalization;

namespace DeckofCards
{
    public class Card
    {
        public static int Number { get; set; } //properties of Card
        public static string Suit { get; set; }
    
        public Card() //constructor with no parameters
        {

        }
        public Card(int number, string suit) //constructor with two parameters
        {
            Number = number;
            Suit = suit;
        }


        public void DisplayName() //Method to write the card properties
        {
            Console.WriteLine($"{Number} of {Suit}");
            Console.ReadLine();
        }
    }
}
