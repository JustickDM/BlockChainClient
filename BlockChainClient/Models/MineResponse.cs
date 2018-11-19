using System.Collections.Generic;

namespace BlockChainClient.Models
{
	/// <summary>
	/// Результат запроса метода Mine
	/// </summary>
	public class MineResponse
	{
		public Block Block { get; set; }

		public List<string> Errors { get; set; }
	}
}
