using System;
using System.Collections.Generic;
using System.Text;

namespace cardsGame
{
    public enum Suit
    {
        clubs,
        Hearts,
        Spades,
        Diamonds
    }
    public enum Rank
    {
        Ace,
        Duece,
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
        King
    }
    public class Card
    {
        public Suit m_suit = 0;
        public Rank m_rank = 0;
        public Card()
        {
        }
        public Card(Rank rank, Suit suit)
        {
            try
            {
                m_rank = rank;
                m_suit = suit;
            }

            catch (Exception e)
            {
                Console.WriteLine();
                Console.Write(e.Message + "\n");
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Overriding the string to display based on the requirement
        /// </summary>
        /// <returns>The string</returns>
        public override string ToString()
        {
            try
            {
                return "The " + m_rank + " of " + m_suit;
            }

            catch (Exception e)
            {
                Console.WriteLine();
                Console.Write(e.Message + "\n");
                Console.WriteLine();
                return "Exception";
            }

        }



    }
}
