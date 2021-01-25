using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace cardsGame
{
    public class Cards : CollectionBase
    {
        public Cards()
        {

        }

        /// <summary>
        /// Add the card to the cards collection
        /// </summary>
        /// <param newCard=cards to add</param>
        /// <returns>None</returns>
        public void Add(Card newCard)
        {
            try
            {
                List.Add(newCard);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.Write(e.Message + "\n");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Remove the card to the cards collection
        /// </summary>
        /// <param cardIndex=Card to remove at index</param>
        /// <returns>None</returns>
        public void Remove(int cardIndex)
        {
            try
            {
                List.RemoveAt(cardIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.Write(e.Message + "\n");
                Console.WriteLine();
            }
        }
        public Card this[int CardIndex]
        {
            get
            {
                return (Card)List[CardIndex];
            }
            set
            {
                List[CardIndex] = value;
            }
        }
    }
}
