using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblResult.Text = string.Empty;
		}

		private void btnResult_Click(object sender, EventArgs e)
		{
			DateTime DT = new DateTime(); ;

			try
			{
				DT=GetDateTime();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			
			string answer = $"您輸入的日期為{DT.ToString()}";
			lblResult.Text =answer;
		}
		
		private DateTime GetDateTime()
		{
			string input = txtInsertDateTime.Text;
			bool isDateTime = DateTime.TryParse(input, out DateTime DT);

			if (isDateTime == false) throw new Exception("請輸入日期");
			if (DT > DateTime.Today)
			{
				throw new Exception("日期不能大於今天");
			}
			else return DT;
		}
	}
}
