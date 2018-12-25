using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using bc = BlockChain.Classes;
using BlockChain.Models;

namespace BlockChainForms
{
	public partial class MainForm : Form
	{
		//private List<Block> Blocks { get; set; } = new List<Block>();

		public MainForm()
		{
			InitializeComponent();
		}

		private void AddTransaction_Click(object sender, EventArgs e)
		{
			var rnd = new Random();

			var transaction = new Transaction()
			{
				Name = Console.ReadLine(),
				Amount = rnd.Next(1, 1000),
				Recipient = Guid.NewGuid().ToString().Replace("-", ""),
				Sender = Guid.NewGuid().ToString().Replace("-", "")
			};

			//MessageBox.Show(transaction.ToString(), "Создана транзакция", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var result = bc.BlockChain.NewTransaction(transaction);
			if (result.Errors == null)
			{
				MessageBox.Show(result.Message, "Сообщение сервера", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				var errors = string.Empty;
				foreach (var error in result.Errors)
				{
					errors += error + "/n";
				}
				MessageBox.Show(errors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AddBlock_Click(object sender, EventArgs e)
		{
			var result = bc.BlockChain.Mine();
			if (result.Errors == null)
			{
				BlocksList.Items.Add(result.Block);
				MessageBox.Show(result.Block.ToString(), "Сообщение сервера", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				var errors = string.Empty;
				foreach (var error in result.Errors)
				{
					Console.WriteLine(error);
				}
				MessageBox.Show(errors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void GetFullChain_Click(object sender, EventArgs e)
		{
			ChainList.Items.Clear();
			var result = bc.BlockChain.GetFullChain();
			if (result.Errors == null)
			{
				MessageBox.Show($"Chain length - {result.Chain.Length}", "Сообщение сервера", MessageBoxButtons.OK, MessageBoxIcon.Information);

				foreach (var block in result.Chain.Blocks)
				{
					Console.WriteLine(block.ToString());
					ChainList.Items.Add(block);
				}
			}
			else
			{
				var errors = string.Empty;
				foreach (var error in result.Errors)
				{
					Console.WriteLine(error);
				}
				MessageBox.Show(errors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
