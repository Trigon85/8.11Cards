using System;
using System.Collections.Generic;
using System.Text;

namespace _8._11Cards
{
   class Card
   {
      private string Face { get; }   // card face (Ace, Deuce.. etc.)   // class property
      private string Suit { get; }   // card suit (Hearts, Diamonds..etc.)    // class property

      public Card(string face, string suit)   //constructor -- initializes card's face and suit
      {
         Face = face;
         Suit = suit;
      }

      public override string ToString() => $"{Face} of {Suit}";   // expression-bodied method returns string representation of card


   }
}
