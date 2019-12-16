using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Cards
{
    // Card Rank
    public enum Rank
    {
        Ace = 1, Two, Three, Four, Five,
        Six, Seven, Eight, Nine, Ten,
        Jack, Queen, King
    }

    // Card Suit
    //public enum Suit { Club, Diamond, Heart, Spade }

    class Card
    {
        

        private Rank rank;
        private char suit;
         
        // Constructors
        public Card () { }
        public Card (Rank r, char s)
        {
            rank = r;
            suit = s;
        }

        public override string ToString()
        {
            return rank + " " + suit;
        }
        
    }
}
