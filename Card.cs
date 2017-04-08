using System;
public enum CardType
{
    Spades = 1, //עלה
    Hearts = 2,//לב
    Diamonds = 3,// יהלום
    Clubs = 4, // תלתן
}

public class Card
{
    public int value;
    public int type;

	public Card(int value, int type)
	{
        if(value<1||value>13||type<1||type>4)
        {
            throw "illegal card value";
        }

        this.value = value;
        this.type = type;
	}
}
