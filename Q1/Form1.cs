using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblResult.Text=String.Empty;
		}

		private void btnResult_Click(object sender, EventArgs e)
		{
			int number=0; 
			try
			{
				number = GetNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			lblResult.Text=$"您輸入的數為{number},介於1~99之間!" ;
		}

		private int GetNumber()
		{
			string input= txtInsertNumber.Text;
			bool Isint = int.TryParse(input, out int number);
			if (Isint == false)throw new Exception("請輸入整數");
			if (number<=0||number>99) throw new Exception("您輸入的數不在1~99之間");
			return number;
		}
	}
}
