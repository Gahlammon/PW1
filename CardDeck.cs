using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class CardDeck
    {
        private Queue<Card> Cards = new Queue<Card>();

        public int CountCards()
        {
            return Cards.Count;
        }
        public void PutCardAtBottom(Card newCard)
        {
            Cards.Enqueue(newCard);
        }
        public Card DrawCard()
        {
            if(Cards.Count > 0)
            {
                return Cards.Dequeue();
            }
            else
            {
                return null;
            }
        }
        public void CreateNewDeck()
        {

        }
        public CardDeck()
        {
            CreateNewDeck();
        }
    }
}
