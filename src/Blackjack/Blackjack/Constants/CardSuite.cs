using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Blackjack.Constants {
	public class CardSuite {
		public const string DIAMONDS = "Diamonds";
		public const string HEARTS = "Hearts";
		public const string SPADES = "Spades";
		public const string CLUBS = "Clubs";

		public static readonly IList<string> SuiteNames = new ReadOnlyCollection<string>(new List<string> {
			DIAMONDS,
			HEARTS,
			SPADES,
			CLUBS
		});
		}
}
