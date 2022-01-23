using System;
using System.Collections.Generic;
using System.Text;
using Blackjack.Models;

namespace Blackjack.Core {
	class CreatePlayerCommand {
		public List<PlayerModel> GetNewPlayers(List<string> names) {
			var players = GeneratePlayers(names);

			return players;
		}

		private List<PlayerModel> GeneratePlayers(List<string> names) {
			List<PlayerModel> players = new List<PlayerModel>();
			players.Add(new PlayerModel());
			players[0].PlayerName = "Dealer";
			for (var id = 1; id < names.Count; id++) {
				players.Add(new PlayerModel());
				players[id].PlayerName = names[id];
			}
			return players;
		}
	}
}
