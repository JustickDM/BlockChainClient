using System.Collections.Generic;

namespace BlockChainClient.Models
{
	/// <summary>
	/// Результат запроса метода GetFullChain
	/// </summary>
	public class GetFullChainResponse
	{
		public Chain Chain { get; set; }

		public List<string> Errors { get; set; }
	}
}
