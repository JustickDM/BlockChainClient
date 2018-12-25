using BlockChain.Models;
using bc = BlockChain.Classes;

using System;

namespace BlockChainClient
{
	class Program
	{
		public static Chain FullChain { get; set; }

		static void Main(string[] args)
		{
			Console.WriteLine("1 - Создать транзакцию");
			Console.WriteLine("2 - Создать блок из транзакций");
			Console.WriteLine("3 - Получить цепочку блоков");

			while (true)
			{
				var method = Console.ReadLine();

				switch (method)
				{
					case "1":
						{
							var rnd = new Random();

							var transaction = new Transaction()
							{
								Name = Console.ReadLine(),
								Amount = rnd.Next(1, 1000),
								Recipient = Guid.NewGuid().ToString().Replace("-", ""),
								Sender = Guid.NewGuid().ToString().Replace("-", "")
							};

							Console.WriteLine(transaction.ToString());

							var result = bc.BlockChain.NewTransaction(transaction);
							if (result.Errors == null)
							{
								Console.WriteLine(result.Message);
							}
							else
							{
								foreach(var error in result.Errors)
								{
									Console.WriteLine(error);
								}
							}
						}
						break;
					case "2":
						{
							var result = bc.BlockChain.Mine();
							if (result.Errors == null)
							{
								Console.WriteLine(result.Block.ToString());
							}
							else
							{
								foreach (var error in result.Errors)
								{
									Console.WriteLine(error);
								}
							}
						}
						break;
					case "3":
						{
							var result = bc.BlockChain.GetFullChain();
							if (result.Errors == null)
							{
								Console.WriteLine($"Chain length - {result.Chain.Length}");

								foreach (var block in result.Chain.Blocks)
								{
									Console.WriteLine(block.ToString());
								}
							}
							else
							{
								foreach (var error in result.Errors)
								{
									Console.WriteLine(error);
								}
							}
						}
						break;
				}
			}
		}
	}
}
