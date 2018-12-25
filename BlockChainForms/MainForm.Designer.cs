namespace BlockChainForms
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.AddTransaction = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.BlocksList = new System.Windows.Forms.ListBox();
			this.AddBlock = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.ChainList = new System.Windows.Forms.ListBox();
			this.GetFullChain = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 426);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.AddTransaction);
			this.tabPage1.Controls.Add(this.comboBox2);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.comboBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(768, 397);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Добавить транзакцию";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Значение*";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 66);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 22);
			this.textBox1.TabIndex = 6;
			// 
			// AddTransaction
			// 
			this.AddTransaction.Location = new System.Drawing.Point(112, 94);
			this.AddTransaction.Name = "AddTransaction";
			this.AddTransaction.Size = new System.Drawing.Size(200, 30);
			this.AddTransaction.TabIndex = 1;
			this.AddTransaction.Text = "Добавить транзакцию";
			this.AddTransaction.UseVisualStyleBackColor = true;
			this.AddTransaction.Click += new System.EventHandler(this.AddTransaction_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(112, 36);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(200, 24);
			this.comboBox2.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Получатель*";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Отправитель*";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(112, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(200, 24);
			this.comboBox1.TabIndex = 2;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.BlocksList);
			this.tabPage2.Controls.Add(this.AddBlock);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 397);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Создать блок";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// BlocksList
			// 
			this.BlocksList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BlocksList.FormattingEnabled = true;
			this.BlocksList.ItemHeight = 16;
			this.BlocksList.Location = new System.Drawing.Point(6, 6);
			this.BlocksList.Name = "BlocksList";
			this.BlocksList.Size = new System.Drawing.Size(756, 340);
			this.BlocksList.TabIndex = 3;
			// 
			// AddBlock
			// 
			this.AddBlock.Location = new System.Drawing.Point(6, 361);
			this.AddBlock.Name = "AddBlock";
			this.AddBlock.Size = new System.Drawing.Size(200, 30);
			this.AddBlock.TabIndex = 2;
			this.AddBlock.Text = "Создать блок";
			this.AddBlock.UseVisualStyleBackColor = true;
			this.AddBlock.Click += new System.EventHandler(this.AddBlock_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.ChainList);
			this.tabPage3.Controls.Add(this.GetFullChain);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(768, 397);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Получить цепочку";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// ChainList
			// 
			this.ChainList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ChainList.FormattingEnabled = true;
			this.ChainList.ItemHeight = 16;
			this.ChainList.Location = new System.Drawing.Point(6, 6);
			this.ChainList.Name = "ChainList";
			this.ChainList.Size = new System.Drawing.Size(756, 340);
			this.ChainList.TabIndex = 2;
			// 
			// GetFullChain
			// 
			this.GetFullChain.Location = new System.Drawing.Point(6, 361);
			this.GetFullChain.Name = "GetFullChain";
			this.GetFullChain.Size = new System.Drawing.Size(200, 30);
			this.GetFullChain.TabIndex = 1;
			this.GetFullChain.Text = "Получить цепочку";
			this.GetFullChain.UseVisualStyleBackColor = true;
			this.GetFullChain.Click += new System.EventHandler(this.GetFullChain_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button AddTransaction;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button GetFullChain;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button AddBlock;
		private System.Windows.Forms.ListBox BlocksList;
		private System.Windows.Forms.ListBox ChainList;
	}
}

