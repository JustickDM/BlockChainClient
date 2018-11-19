﻿using System.Collections.Generic;

namespace BlockChainClient.Models
{
	/// <summary>
	/// Результат запроса метода NewTransaction
	/// </summary>
	public class NewTransactionResponse
	{
		public string Message { get; set; }

		public List<string> Errors { get; set; }
	}
}
