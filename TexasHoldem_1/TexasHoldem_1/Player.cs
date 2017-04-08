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
        public int chipsAmount;
        private int currentBet = 0;
        Boolean folded=false;


        public Player(string name, int chips)
        {
            if (name == null) throw new Exception("illegal player name");
            if (chips < 0) throw new Exception("illegal amount of chips");

            this.name = name;
        }

        public int CurrentBet { get => currentBet; set => currentBet = value; }

        public void setCards(Card first, Card second)
        {
            if (first == null || second == null) throw new Exception("can't put null cards");
            hand[0] = first;
            hand[1] = second;
        }

        public void SetBet(int amount)
        {
            if (amount < 0 || amount > chipsAmount) throw new Exception("illegael bet");
            currentBet +=amount;
            chipsAmount -= amount;
        }

        public void ClearBet() { currentBet = 0; }

        public void Fold() { folded = true; }




    }
}
