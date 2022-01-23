using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Models {
	public class DeckModel {
		public DeckModel() {
			Cards = new List<CardModel>();
		}
		public List<CardModel> Cards { get; set; }
		public int DeckId { get; set; }
	}
}
