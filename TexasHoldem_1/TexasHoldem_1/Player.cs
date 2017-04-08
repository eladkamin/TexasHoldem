using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem_1
{
    class Player
    {
        public Card[] hand = new Card[2];
        public string name;
        
        public Player(string name)
        {
            if (name == null) throw new Exception("illegal player name");

            this.name = name;
        }

        public void setCards(Card first, Card second)
        {
           
            if (first == null || second == null) throw new Exception("can't put null cards");
            this.hand[0] = first;
            this.hand[1] = second;
        }
       
        
    }
}
