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
        private void Shuffle()
        {
            List<Card> cardList = new List<Card>();
            Random randomGenerator = new Random();
            int index;

            while(Cards.Count > 0)
            {
                cardList.Add(Cards.Dequeue());
            }
            while(cardList.Count > 0)
            {
                index = randomGenerator.Next(0, cardList.Count - 1);
                Cards.Enqueue(cardList[index]);
                cardList.RemoveAt(index);
            }
        }
        private void CreateNewDeck(int size)
        {
            while(size > 0)
            {
                foreach (Card.Color i in Enum.GetValues(typeof(Card.Color)))
                {
                    foreach (Card.Value j in Enum.GetValues(typeof(Card.Value)))
                    {
                        Cards.Enqueue(new Card(i, j));
                    }
                }
            }
            Shuffle();
        }
        public CardDeck(int size)
        {
            CreateNewDeck(size);
        }
    }
}
