using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Blackjack.Constants {
	public class CardName {
		public const string ACE = "Ace";
		public const string TWO = "Two";
		public const string THREE = "Three";
		public const string FOUR = "Four";
		public const string FIVE = "Five";
		public const string SIX = "Six";
		public const string SEVEN = "Seven";
		public const string EIGHT = "Eight";
		public const string NINE = "Nine";
		public const string TEN = "Ten";
		public const string JACK = "Jack";
		public const string QUEEN = "Queen";
		public const string KING = "King";

		public static readonly IList<string> CardNames = new ReadOnlyCollection<string>(new List<string> {
			ACE,
			TWO,
			THREE,
			FOUR,
			FIVE,
			SIX,
			SEVEN,
			EIGHT,
			NINE,
			TEN,
			JACK,
			QUEEN,
			KING
		});
		public static readonly IList<string> CardsWorthTenPoints = new ReadOnlyCollection<string>(new List<string> { 
			TEN,
			JACK,
			QUEEN,
			KING
		});
		}
}
