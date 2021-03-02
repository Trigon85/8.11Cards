using System;
using System.Collections.Generic;
using System.Text;

namespace _8._11Cards
{
   class DeckOfCards
   {
      private static Random randomNumber = new Random();

      private const int NumberOfCards = 52; // number of cards in a deck
      private Card[] deck = new Card[NumberOfCards]; 
      private int currentCard = 0; //index of next card to be dealt (0-51)


      public DeckOfCards()
      {
         string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
         string[] suits = {"Hearts", "Diamonds", "Clubs", "Spades"};

         //populate deck with card objects
         for (int count = 0; count < deck.Length; ++count)
         {
            deck[count] = new Card(faces[count % 13], suits[count / 13]);
         }
      }

      public void Shuffle()
      {
         //after shuffling, dealing should start at deck[0] again
         currentCard = 0; //reinitialize currentCard

         for (int first = 0; first < deck.Length; ++first)
         {
            var second = randomNumber.Next(NumberOfCards);

            //swap current card with randomly selected card
            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;

         }
      }
      public Card DealCard()
      {
         //determine whether cards remain to be dealt
         if (currentCard < deck.Length)
         {
            return deck[currentCard++]; //return current card in array
         }
         else
         {
            return null; // indicate that all cards were dealt
         }
      }

   }
}
