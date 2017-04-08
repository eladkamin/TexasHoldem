using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem_1
{
    public enum CardType
    {
        Spades = 1, //עלה
        Hearts = 2,//לב
        Diamonds = 3,// יהלום
        Clubs = 4, // תלתן
    }
    class Card
    {
      
        public int value;
        public int type;

        public Card(int value, int type)
        {
            if (value < 1 || value > 13 || type < 1 || type > 4)
            {
                throw new Exception("illegal card");
            }

            this.value = value;
            this.type = type;
        }
    }

}

