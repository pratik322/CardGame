using System;

namespace cardsGame
{
    class Program
    {
        private static Card cardOnTable;
        static void Main(string[] args)
        {

            bool bIsOK = false;

            while (true)

            {
                try
                {
                    Console.WriteLine("Enter 1 to Play the Game");
                    Console.WriteLine("Enter 2 to Shuffle the cards");
                    Console.WriteLine("Enter 3 to Restart");
                    var op = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (op == 1)
                    {
                        Deck deck = new Deck();
                        Cards card = new Cards();
                        bIsOK = true;
                        deck.Shuffle();
                        deck.CardIndex = 6;
                        cardOnTable = deck.NextCard;
                        Console.WriteLine("Card on the table - {0}", cardOnTable);
                        InitializeCardsInHand(card, deck);
                        DisplayCardsInHand(card);
                        Console.WriteLine();
                    }

                    else if (op == 2 && bIsOK)
                    {

                        Cards cardObj = new Cards();
                        Deck newDeck = new Deck();
                        newDeck.Shuffle();
                        ReInitializeCardsInHand(cardObj, newDeck, cardOnTable);
                        DisplayCardsInHand(cardObj);
                        Console.WriteLine();
                    }

                    else if (op == 2)
                    {
                        Console.WriteLine("Please start playing first");
                    }

                    else if (op == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks for Playing...");
                        break;
                    }

                    else
                        Console.WriteLine("Please give correct option");
                }

                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.Write(e.Message + "\n");
                    Console.WriteLine();
                }
            }
        }


        /// <summary>
        /// Initialize the cards to add the cards in the deck
        /// </summary>
        /// <param cards=List if present cards</param>
        /// <param card=List of cards drawn</param>
        /// <returns>none</returns>
        public static void InitializeCardsInHand(Cards card, Deck cards)
        {
            try
            {
                int j = 0;

                for (int i = 0; i < 7; i++)
                {
                    card.Add(cards.card[j]);
                    j++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.Write(e.Message + "\n");
                Console.WriteLine();
            }

        }

        /// <summary>
        /// ReInitialize the cards to add the cards in the deck
        /// </summary>
        /// <param cards=List if present cards</param>
        /// <param card=List of cards drawn</param>
        /// <param removeCard=To remove the card which is already played</param>
        /// <returns>none</returns>
        public static void ReInitializeCardsInHand(Cards c, Deck cards, Card removeCard)
        {
            int j = 0;

            try
            {

                for (int i = 0; i < 7; i++)
                {
                    if (!(cards.card[j] == removeCard))
                    {
                        c.Add(cards.card[j]);
                        j++;
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


        /// <summary>
        /// Display the cards on console
        /// </summary>
        /// <param cards=List if present cards</param>
        /// <returns>none</returns>
        public static void DisplayCardsInHand(Cards cards)
        {
            try
            {
                foreach (Card card in cards)
                {
                    Console.WriteLine(card.ToString());
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
