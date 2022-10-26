using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnResult_Click(object sender, EventArgs e)
		{
			DateTime Today = DateTime.Today;
			string input = string.Empty;
			string [] DT = input.Split( '/' );

			try
			{
				DT = GetDateTime();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string answer = $"您輸入的日期為{}";
			lblResult.Text =answer;
		}
		
		private string GetDateTime()
		{
			string []DT= ;
			bool isDateTime =DateTime.TryParse(input,out DateTime DT);

			if (DT > DateTime.Today)
			{
				throw new Exception("日期不能大於今天");
			}
			return DT.ToString();
		}
	}
}
