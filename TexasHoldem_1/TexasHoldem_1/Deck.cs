using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem_1
{
    class Deck
    {

        public List<Card> cards = new List<Card>(52);

        public Deck()
        {
            for (int i = 1; i < 13; i++) // init deck
            {
                for (int j = 1; j < 5; j++)
                {
                    cards.Add(new Card(i, j));
                }
            }
            ShuffulDeck();
        }

        public void ShuffulDeck()
        {
            Random rnd = new Random();
            for (var i = 0; i < cards.Count; i++)
            {
                Swap(cards, i, rnd.Next(i, cards.Count()));
            }
        }

        public static void Swap(List<Card> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public Card getCard()
        {
            if (cards.Count < 1) throw new Exception("Deck is empty");
            Card Temp = cards[0];
            cards.RemoveAt(0);
            return Temp;
        }

    }
}
