using System;
using System.Collections.Generic;
using System.Text;
using Blackjack.Constants;
using Blackjack.Models;
using Medallion;

namespace Blackjack.Commands {
	public class CreateDeckCommand {
		public DeckModel CreateDeck() {
			var deck = GenerateDeck();
			deck = ShuffleDeck(deck);
		
			return deck;
		}

		private DeckModel GenerateDeck() {
			var deck = new DeckModel();
			for (var suite = 0; suite < CardSuite.SuiteNames.Count; suite++) {
				for (var name = 0; name < CardName.CardNames.Count; name++) {
					deck.Cards.Add(new CardModel { Name = CardName.CardNames[name], Suite = CardSuite.SuiteNames[suite] });
				}
			}
			return deck;
		}

		private DeckModel ShuffleDeck(DeckModel deck) {
			var random = new Random();
			for(var i = 0; i < 7; i++) {
				deck.Cards.Shuffle(random);
			}

			return deck;
		}
	}
}
