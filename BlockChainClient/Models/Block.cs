using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace BlockChainClient.Models
{
	/// <summary>
	/// Блок
	/// </summary>
	public class Block
	{
		[JsonProperty("Message")]
		public string Message { get; set; }

		[JsonProperty("Index")]
		public int Index { get; set; }

		[JsonProperty("Timestamp")]
		public DateTime Timestamp { get; set; }

		[JsonProperty("Transactions")]
		public List<Transaction> Transactions { get; set; }

		[JsonProperty("Proof")]
		public int Proof { get; set; }

		[JsonProperty("PreviousHash")]
		public string PreviousHash { get; set; }

		public override string ToString()
		{
			return $"{Index} [{Timestamp.ToString("yyyy-MM-dd HH:mm:ss")}] Proof: {Proof} | PrevHash: {PreviousHash} | Trx: {Transactions.Count}";
		}
	}
}
