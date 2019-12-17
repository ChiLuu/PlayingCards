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

        /*  Random list shuffle. Ref: https://jamesshinevar.com/2017/05/28/shuffle-a-list-c-fisher-yates-shuffle/ 
         *  1.Get a list (We’ll call this list A)
         *  2.Get the number of items in the list.
         *  3.Start counting backward from the number of items in the list.
         *  4.Pick a random number from 1 to n (n being the total number of elements in the list A), 
         *  and we’ll call that number k.
         *  5.Put the item from count backward point n into the point k spot, and vice versa.
         *  6.Repeat steps 3-5 until list n gets back to 0.
         */


        // Declare random object 'rnd'
        private Random rnd = new Random();

        // 1. List sDeck
        public void Shuffle()
        {
            List<Card> sDeck = deck;
            // 2.Get the number of items in list
            int numCards = sDeck.Count;

            // 3. Count backward from number of items in list
            while(numCards > 1)
            {
                // Index starts at 0 so we count at 1 less than number of items. Also ensure 
                // we do not count cards that were swapped to end of deck.
                numCards--; 

                // 4.Pick a card at a random position in list (number from 1 to # of items)
                int rndPosition = rnd.Next(numCards);
                Card rndCard = sDeck[rndPosition];

                // 5.Swap the card at the end of the list with the randomly picked card in step 4.
                sDeck[rndPosition] = sDeck[numCards];
                sDeck[numCards] = rndCard;
            }
        }



    }
}
