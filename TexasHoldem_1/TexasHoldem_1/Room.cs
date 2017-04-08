using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem_1
{
    class Room
    {
        public Queue<Player> players = new Queue<Player>(8);
        public Deck Deck = new Deck();
        public Card[] communityCards = new Card[5];
        public string name;

        public Room(String name, Player creator)
        {
            if (name == null) throw new Exception("illegal room name");

            if (creator == null) throw new Exception("illegal Player");
            players.Enqueue(creator);
            this.name = name;
        }

        public void AddPlayer(Player p)
        {
            if (p == null) throw new Exception("illegal Player");
            if (players.Count > 7) throw new Exception("room is full");
            players.Enqueue(p);
        }


        public void DealTwo()
        {
            foreach (Player p in players)
            {
                p.hand[1] = Deck.getCard();
                p.hand[2] = Deck.getCard();
            }
        }

        



        public Player HighHand()
        {
            return players.ElementAt(0);
        }

    }
}
