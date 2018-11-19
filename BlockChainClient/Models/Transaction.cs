namespace BlockChainClient.Models
{
	/// <summary>
	/// Транзакция
	/// </summary>
	public class Transaction
	{
		public int Amount { get; set; }
		public string Recipient { get; set; }
		public string Sender { get; set; }

		public override string ToString()
		{
			return $"Amount [{Amount}], Recipient [{Recipient}], Sender [{Sender}]";
		}
	}
}
