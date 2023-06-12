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
        public enum BlackJackValues
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 10,
            Queen = 10,
            King = 10,
            Ace = 11
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
            switch (cardValue)
            {
                case Value.Two:     return 2;
                case Value.Three:   return 3;
                case Value.Four:    return 4;
                case Value.Five:    return 5;
                case Value.Six:     return 6;
                case Value.Seven:   return 7;
                case Value.Eight:   return 8;
                case Value.Nine:    return 9;
                case Value.Ten:     return 10;
                case Value.Jack:    return 10;
                case Value.Queen:   return 10;
                case Value.King:    return 10;
                case Value.Ace:     return 11;
            }
            return 0;
        }
        public int GetWarValue()
        {
            switch (cardValue)
            {
                case Value.Two:     return 2;
                case Value.Three:   return 3;
                case Value.Four:    return 4;
                case Value.Five:    return 5;
                case Value.Six:     return 6;
                case Value.Seven:   return 7;
                case Value.Eight:   return 8;
                case Value.Nine:    return 9;
                case Value.Ten:     return 10;
                case Value.Jack:    return 11;
                case Value.Queen:   return 12;
                case Value.King:    return 13;
                case Value.Ace:     return 14;
            }
            return 0;
        }
    }
}
