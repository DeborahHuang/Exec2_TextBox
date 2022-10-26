using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnResult_Click(object sender, EventArgs e)
		{
			DateTime DT = new DateTime(); 

			try
			{
				DT = GetDateTime();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			DateTime thhirteenYearsAgo = DateTime.Now.AddYears(-13);
			if (DT > thhirteenYearsAgo)
			{
				string result = "您未滿13歲";
				txtResult.Text = result;
			}
			else
			{
				string result = "您已滿13歲";
				txtResult.Text = result;
			}
		}

		private DateTime GetDateTime()
		{
			string input= txtInsertBirthday.Text;
			bool isDateTime = DateTime.TryParse(input, out DateTime DT);
			if (isDateTime == false) throw new Exception("請輸入生日");
			if (DT > DateTime.Now) throw new Exception("生日不能大於今天");
			else return DT;
		}
	}
}
