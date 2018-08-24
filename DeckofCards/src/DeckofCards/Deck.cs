using System;

namespace DeckofCards
{
    public class Deck
    {
        private readonly Card[] _cards = new Card[52]; //intializing an array of type card

        private readonly Random _ran = new Random(); //creating a random object
        public Card Draw()
        {
            for (int i = 0; i < _cards.Length; i++) //creates a card object 52 times for each item in the array
            {
                _cards[i] = new Card();

                for (int x = 0; x < 4; x++)
                {

                    for (int y = 0; y < 12; y++)
                    {
                        Card.Number = _ran.Next(1, 12);
                    }
                }
            }

            Card randomDraw = _cards[_ran.Next(1, _cards.Length)]; //draws a random object from the array and stores in randomDraw
            return randomDraw;
        }


    }
}
