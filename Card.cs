using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Card
    {
        public enum Color
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }
        public enum Value
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
        private Color cardColor;
        private Value cardValue;
        public Card(Color newCardColor, Value newCardValue)
        {
            cardColor = newCardColor;
            cardValue = newCardValue;
        }
        public Color GetColor()
        {
            return cardColor;
        }
        public Value GetValue()
        {
            return cardValue;
        }
        public int GetBlackJackValue()
        {
            return (0);
        }
        public int GetWarValue()
        {
            return (0);
        }
    }
}
