
namespace DeckofCards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            Card card1 = deck1.Draw();
            card1.DisplayName();           

        }
    }
}
