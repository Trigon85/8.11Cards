using System;

namespace _8._11Cards
{
   class DeckOfCardsTest
   {
      static void Main(string[] args)
      {
         var myDeckOfCards = new DeckOfCards();
         myDeckOfCards.Shuffle(); //place cards in random order

         for (int i = 0; i < 52; i++)
         {
            Console.Write($"{myDeckOfCards.DealCard(), -19}");

            if ((i + 1) % 4 == 0) 
            {
               Console.WriteLine();
            }

         }

      }
   }
}
