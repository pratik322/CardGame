﻿using System;
using System.Collections.Generic;
using System.Text;

namespace cardsGame
{
    class Deck
    {
		public int nextCardIndex = 0;
		public Card[] card;
		public Deck()
		{
			card = new Card[52];
		}
		public Card NextCard
		{
			get
			{
				return card[++nextCardIndex];
			}

		}
		public int CardIndex
		{
			set
			{
				nextCardIndex = value;
			}
		}


        /// <summary>
        /// Shuffling the cards to play
        /// </summary>
        /// <returns>None</returns>

        public void Shuffle()
		{
            try
            {
                bool[] bAssigned = new bool[52];
                //int index = 0;
                for (int iRank = 0; iRank < 13; iRank++)
                {
                    for (int iSuit = 0; iSuit < 4; iSuit++)
                    {
                        Random randomCard = new Random();
                        bool bCardFound = false;
                        while (bCardFound == false)
                        {
                            int index = randomCard.Next(52);
                            if (bAssigned[index] == false)
                            {
                                card[index] = new Card((Rank)iRank, (Suit)iSuit);
                                bCardFound = true;
                                bAssigned[index] = true;
                            }
                            //index1++;
                        }

                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine();
                Console.Write(e.Message + "\n");
                Console.WriteLine();
            }
        }

	}
}
