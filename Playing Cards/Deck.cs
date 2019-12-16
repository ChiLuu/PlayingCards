using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Cards
{
    
    class Deck
    {
        List<Card> deck = new List<Card>();
        char[] suitChar = { '\u2663', '\u2666', '\u2665', '\u2660' };

        // Constructor
        public Deck() 
        {
            generateDeck();
        }
        
        // Getter
        public List<Card> getDeck
        {
            get { return deck; }
        }


        private void generateDeck()
        {
            for(int i = 0 ; i < suitChar.Length; i++)
            {
                for(Rank rank = Rank.Ace; rank <= Rank.King; rank++)
                {
                    Card card = new Card(rank, suitChar[i]);
                    deck.Add(card);
                }
            }
        }



    }
}
