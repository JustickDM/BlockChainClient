using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlockChain.Models
{
	/// <summary>
	/// Цепочка блоков
	/// </summary>
	public class Chain
	{
		[JsonProperty("Length")]
		public int Length { get; set; }

		[JsonProperty("Chain")]
		public List<Block> Blocks { get; set; }
	}
}
