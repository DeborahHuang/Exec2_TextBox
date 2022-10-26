using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4_計算入場費用
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCal_Click(object sender, EventArgs e)
		{
			
			int carNumber = 0;
			int personNumber = 0;
			try
			{
				carNumber = GetCarNumber();
				personNumber = GetPersonNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			int totalCharge = ChargeCal();

			string result = $"車子共{carNumber}台\r\n人數共{personNumber}位\r\n一共為{totalCharge}元";
			txtResult.Text = result;
		}

		private int ChargeCal()
		{
			int personNumber=GetPersonNumber();
			int carNumber=GetCarNumber();
			int carCgarge = carNumber*200;
			int personCharge = personNumber * 60;
			int totalCharge = carNumber * 200+ personNumber * 60;
			return totalCharge;
		}

		private int GetPersonNumber()
		{
			string person = txtPersonInsert.Text;
			bool isInt = int.TryParse(person, out int PersonNumber);
			if (isInt == false) throw new Exception("人數必須大於零");
			return PersonNumber;
		}

		private int GetCarNumber()
		{
			string car = txtCarInsert.Text;
			bool isInt = int.TryParse(car, out int carNumber);
			if (isInt == false) throw new Exception("車數必須大於零");
			return carNumber;
		}
	}
}
