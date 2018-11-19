using BlockChainClient.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace BlockChainClient.Classes
{
	public class BlockChain
	{ 
		/// <summary>
		/// Добавить новую транзакцию в блок, POST запрос
		/// </summary>
		/// <param name="transaction">Транзакция</param>
		public static NewTransactionResponse NewTransaction(Transaction transaction)
		{
			WebRequest request = WebRequest.Create("http://localhost:12345/transactions/new");
			request.Method = "POST";

			var data = JsonConvert.SerializeObject(transaction);

			byte[] byteArray = Encoding.UTF8.GetBytes(data);

			request.ContentType = "application/x-www-form-urlencoded";

			request.ContentLength = byteArray.Length;

			var result = new NewTransactionResponse();

			try
			{
				using (Stream dataStream = request.GetRequestStream())
				{
					dataStream.Write(byteArray, 0, byteArray.Length);
				}

				WebResponse response = request.GetResponseAsync().Result;

				using (Stream stream = response.GetResponseStream())
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						result.Message = reader.ReadToEnd();
					}
				}

				response.Close();

				return result;
			}
			catch (WebException ex)
			{
				result.Errors = new List<string>();

				result.Errors.Add($"{ex.Message} [{ex.Status}]");

				return result;
			}
		}

		/// <summary>
		/// Собрать блок из транзакций, GET запрос
		/// </summary>
		public static MineResponse Mine()
		{
			WebRequest request = WebRequest.Create("http://localhost:12345/mine");
			request.Method = "GET";

			var mineResponse = new MineResponse();

			try
			{
				WebResponse response = request.GetResponseAsync().Result;

				using (Stream stream = response.GetResponseStream())
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						var responseString = reader.ReadToEnd();
						mineResponse.Block = JsonConvert.DeserializeObject<Block>(responseString);
					}
				}

				response.Close();

				return mineResponse;
			}
			catch (AggregateException ex)
			{
				mineResponse.Errors = new List<string>();

				foreach (var e in ex.InnerExceptions)
				{
					mineResponse.Errors.Add(e.Message);
				}

				return mineResponse;
			}
		}

		/// <summary>
		/// Получить полную цепочку блоков, GET запрос
		/// </summary>
		public static GetFullChainResponse GetFullChain()
		{
			WebRequest request = WebRequest.Create("http://localhost:12345/chain");
			request.Method = "GET";

			var getFullChainResponse = new GetFullChainResponse();

			try
			{
				WebResponse response = request.GetResponseAsync().Result;

				using (Stream stream = response.GetResponseStream())
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						var responseString = reader.ReadToEnd();
						getFullChainResponse.Chain = JsonConvert.DeserializeObject<Chain>(responseString);
					}
				}

				response.Close();

				return getFullChainResponse;
			}
			catch (AggregateException ex)
			{
				getFullChainResponse.Errors = new List<string>();

				foreach (var e in ex.InnerExceptions)
				{
					getFullChainResponse.Errors.Add(e.Message);
				}

				return getFullChainResponse;
			}
		}
	}
}
