using System;
using System.Collections.Generic;
using Blackjack.Core;
using Blackjack.Constants;
using Blackjack.Models;

namespace Blackjack {

	class Program {
		static public List<PlayerModel> CreatePlayers(List<string> names) {
			CreatePlayerCommand _createPlayerCommand = new CreatePlayerCommand();
			return _createPlayerCommand.GetNewPlayers(names);
		}
		static public DeckModel GenerateDeck() {
			CreateDeckCommand _createDeckCommand = new CreateDeckCommand();
			return _createDeckCommand.GetNewDeck();
		}

		static public void UnitTests(DeckModel deck, List<PlayerModel> players) {
			GenerateDeckTest(deck);
			ShuffleDeckTest(deck);
			PlayerTest(players);
		}
		static public void PlayerTest(List<PlayerModel> players) {
			bool playersAreGood = true;
			for (int i = 0; i < players.Count; i++) {
				if ( !(players[i].PlayerName != String.Empty
					&& players[i].Score == 0
					&& players[i].Hand != null
					&& players[i].Hand.Count == 0)) {
					playersAreGood = false;
				}
			}
			Console.WriteLine($"playersAreGood = {playersAreGood}");
		}
	

		static public void GenerateDeckTest(DeckModel deck) {
			const int CorrectCount = 52;
			if (deck.Cards.Count == CorrectCount) {
				Console.WriteLine($"Deck count is correct.");
			}
			else {
				Console.WriteLine($"Deck count is wrong.");
			}

		}

		static public void ShuffleDeckTest(DeckModel deck) {
			const int FIRST = 0;
			const int LAST = 51;
			if (deck.Cards[FIRST].Suite == CardSuite.DIAMONDS
				&& deck.Cards[FIRST].Name == CardName.ACE
				&& deck.Cards[LAST].Suite == CardSuite.CLUBS
				&& deck.Cards[LAST].Name == CardName.KING ) {
				Console.WriteLine($"Deck has been shuffled incorrectly.");
			}
			else {
				Console.WriteLine($"Deck has been shuffled correctly.");
			}
		}

		static public void GameLoop() {

		}

		static void Main(string[] args) {

			List<string> names = new List<string>();
			names.Add("Jim Bob");
			names.Add("George Clooney");
			names.Add("Henry Ford");
			names.Add("Jacob Batalon");
			names.Add("Fred Flintstone");

			var deck = GenerateDeck();
			var players = CreatePlayers(names);
			UnitTests(deck, players);
		}
	}
}
