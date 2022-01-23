using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Models {
	class PlayerModel {
		public PlayerModel() {
			PlayerId = new Guid();
			Hand = new List<CardModel>();
			Score = 0;
		}
		public Guid PlayerId { get; set; }
		public string PlayerName { get; set; }
		public int Score { get; set; }
		public List<CardModel> Hand { get; set; }

	}
}
