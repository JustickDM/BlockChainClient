namespace BlockChain.Models
{
	/// <summary>
	/// Транзакция
	/// </summary>
	public class Transaction
	{
		public string Name { get; set; }
		public int Amount { get; set; }
		public string Recipient { get; set; }
		public string Sender { get; set; }

		public override string ToString()
		{
			return $"Name [{Name}], Amount [{Amount}], Recipient [{Recipient}], Sender [{Sender}]";
		}
	}
}
