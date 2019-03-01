using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
	public partial class fMain : Form
	{
		bool isPause;
		int checkOrder;
		// Cafe
		double hotDog, hamburger, frenchFries, cocaCola;// Price of each products

		double dayGain;

		public fMain()
		{
			InitializeComponent();
			isPause = false;
			checkOrder = 0;
			dayGain = 0;
		}
		private void fMain_Load(object sender, EventArgs e)
		{
			Settings.ReadSettings();
			ChangeSettings();

			cbxFuel.SelectedIndex = 0;
		}

		private void Compute()
		{
			// Gas
			double gasPrice;
			double gasQuantity, gasAmount;

			// To Pay
			double gasToPay;
			double cafeToPay;
			double totalToPay;

			// Compute price of each products
			hotDog = Convert.ToDouble(tbxHotDogPrice.Text) * Convert.ToDouble(nudHotDog.Value);
			hamburger = Convert.ToDouble(tbxHamburgerPrice.Text) * Convert.ToDouble(nudHamburger.Value);
			frenchFries = Convert.ToDouble(tbxFrenchFriesPrice.Text) * Convert.ToDouble(nudFrenchFries.Value);
			cocaCola = Convert.ToDouble(tbxCocaColaPrice.Text) * Convert.ToDouble(nudCocaCola.Value);

			cafeToPay = hotDog + hamburger + frenchFries + cocaCola;// Summary price of products

			if (rbtnQuantity.Checked)
			{
				gasPrice = Convert.ToDouble(tbxPrice.Text);
				gasQuantity = Convert.ToDouble(tbxQuantity.Text);
				gasToPay = gasPrice * gasQuantity;// Compute "To Pay" price
				totalToPay = cafeToPay + gasToPay;// Compute "Total To Pay" price
			}
			else
			{
				gasPrice = Convert.ToDouble(tbxPrice.Text);
				gasAmount = Convert.ToDouble(tbxAmount.Text);
				gasToPay = gasAmount / gasPrice;// Compute "To Issue" liters
				totalToPay = cafeToPay + gasAmount;// Compute "Total To Pay" price
			}

			tbxToPayStation.Text = gasToPay.ToString("#.##");
			tbxToPayCafe.Text = cafeToPay.ToString("#.##");
			tbxToPayTotal.Text = totalToPay.ToString("#.##");

			// Bug fix
			string stat, cafe, total;
			stat = tbxToPayStation.Text;
			cafe = tbxToPayCafe.Text;
			total = tbxToPayTotal.Text;

			// Replace empthy string in "to pay" to zero
			if (stat == "")
				tbxToPayStation.Text = "0";
			if (cafe == "")
				tbxToPayCafe.Text = "0";
			if (total == "")
				tbxToPayTotal.Text = "0";

			// Replace empthy first character to zero
			// "Length > 1" - Anti-Exception
			if (stat.Length > 1 && stat[0] == ',')
				tbxToPayStation.Text = "0" + stat;
			if (cafe.Length > 1 && cafe[0] == ',')
				tbxToPayCafe.Text = "0" + cafe;
			if (total.Length > 1 && total[0] == ',')
				tbxToPayTotal.Text = "0" + total;
		}
		private void ChangeSettings()
		{
			tbxHotDogPrice.Text = Settings.hotDogPrice.ToString("#.##");
			tbxHamburgerPrice.Text = Settings.hamburgerPrice.ToString("#.##");
			tbxFrenchFriesPrice.Text = Settings.frenchFriesPrice.ToString("#.##");
			tbxCocaColaPrice.Text = Settings.cocaColaPrice.ToString("#.##");

			if (cbxFuel.SelectedIndex == 0)
			{
				tbxPrice.Text = Settings.a92Price.ToString("#.##");
			}
			else if (cbxFuel.SelectedIndex == 1)
			{
				tbxPrice.Text = Settings.a95Price.ToString("#.##");
			}

			lblUah.Text = Settings.currency;
			lblUah2.Text = Settings.currency;
			lblUah3.Text = Settings.currency;
			lblUah4.Text = Settings.currency;
			lblUah5.Text = Settings.currency;

			toolStripProgressBar1.Maximum = Settings.pauseDuration;
			toolStripProgressBar1.Value = Settings.pauseDuration;

			// Time
			//toolStripStatusLabel1.Text = localDate.ToShortTimeString();
			//toolStripStatusLabel2.Text = localDate.ToShortDateString();
		}
		private void DefaultPosition()
		{
			ChangeSettings();

			cbxFuel.SelectedIndex = 0;

			rbtnQuantity.Checked = true;
			tbxQuantity.Text = "0";
			tbxAmount.Text = "0";

			cbxHotDog.Checked = false;
			cbxHamburger.Checked = false;
			cbxFrenchFries.Checked = false;
			cbxCocaCola.Checked = false;

			tbxToPayStation.Text = "0";
			tbxToPayCafe.Text = "0";
			tbxToPayTotal.Text = "0";
		}
		private string BuildCheckString()
		{
			string str;

			str = $"                    BestOil{Environment.NewLine}" +
				  $" Order N {checkOrder}       {toolStripStatusLabel1.Text} - {toolStripStatusLabel2.Text}{Environment.NewLine}" +
				  $"=========================={Environment.NewLine}" +
				  $" Gas Station:{Environment.NewLine}";

			if (rbtnQuantity.Checked)
			{
				str += $"{cbxFuel.Text} - {tbxQuantity.Text}L                         {tbxToPayStation.Text} {Settings.currency}{Environment.NewLine}";
			}
			else
			{
				str += $"{cbxFuel.Text} - {tbxToPayStation.Text}L                         {tbxAmount.Text} {Settings.currency}{Environment.NewLine}";
			}

			str += $"=========================={Environment.NewLine}" +
				   $" Mini Cafe:{Environment.NewLine}";

			if (cbxHotDog.Checked) str += $"Hot Dog - {nudHotDog.Value}x                  {hotDog} {Settings.currency}{Environment.NewLine}";
			if (cbxHamburger.Checked) str += $"Hamburger - {nudHamburger.Value}x               {hamburger} {Settings.currency}{Environment.NewLine}";
			if (cbxFrenchFries.Checked) str += $"French fries - {nudFrenchFries.Value}x             {frenchFries} {Settings.currency}{Environment.NewLine}";
			if (cbxCocaCola.Checked) str += $"Coca Cola - {nudCocaCola.Value}x               {cocaCola} {Settings.currency}{Environment.NewLine}";

			str += $"--------------------------{Environment.NewLine}" +
				   $"Mini Cafe Total:            {tbxToPayCafe.Text} {Settings.currency}{Environment.NewLine}" +
				   $"=========================={Environment.NewLine}" +
				   $"                       TOTAL: {tbxToPayTotal.Text} {Settings.currency}{Environment.NewLine}";

			return str;
		}

		private void cbFuel_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbxFuel.SelectedIndex == 0)
			{
				tbxPrice.Text = Settings.a92Price.ToString("#.##");
			}
			else if(cbxFuel.SelectedIndex == 1)
			{
				tbxPrice.Text = Settings.a95Price.ToString("#.##");
			}
			Compute();
		}
		private void rbtnAmount_CheckedChanged(object sender, EventArgs e)
		{
			if(rbtnQuantity.Checked)
			{
				tbxAmount.Enabled = false;
				tbxQuantity.Enabled = true;
				tbxAmount.Text = "0";
				gbxToPayStation.Text = "To Pay";
				lblUah3.Text = Settings.currency;
			}
			else if(rbtnAmount.Checked)
			{
				tbxQuantity.Enabled = false;
				tbxAmount.Enabled = true;
				tbxQuantity.Text = "0";
				gbxToPayStation.Text = "To Issue";
				lblUah3.Text = "L";
			}
		}
		private void tbxQuantity_TextChanged(object sender, EventArgs e)
		{
			TextBox tbx = (TextBox)sender;

			if (tbx.Text != "0" && tbx.Text.Length <= 1)
			{
				if (tbx.Text == "")
					tbx.Text = "0";

				if (rbtnAmount.Checked)
					tbxQuantity.Text = tbxToPayStation.Text;
			}
			else if (tbx.Text[0] == '0' && tbx.Text.Length > 1)// delete first 0
			{
				string tmp = "";

				for (int i = 1; i < tbx.Text.Length; i++)
				{
					tmp += tbx.Text[i];
				}
				tbx.Text = tmp;
			}
			Compute();
		}
		private void cbxCocaCola_CheckedChanged(object sender, EventArgs e)
		{
			if(cbxHotDog.Checked)
			{
				nudHotDog.Enabled = true;
				if (nudHotDog.Value == 0)
					nudHotDog.Value = 1;
			}
			else
			{
				nudHotDog.Enabled = false;
				nudHotDog.Value = 0;
			}

			if (cbxHamburger.Checked)
			{
				nudHamburger.Enabled = true;
				if(nudHamburger.Value == 0)
					nudHamburger.Value = 1;
			}
			else
			{
				nudHamburger.Enabled = false;
				nudHamburger.Value = 0;
			}

			if (cbxFrenchFries.Checked)
			{
				nudFrenchFries.Enabled = true;
				if (nudFrenchFries.Value == 0)
					nudFrenchFries.Value = 1;
			}
			else
			{
				nudFrenchFries.Enabled = false;
				nudFrenchFries.Value = 0;
			}

			if (cbxCocaCola.Checked)
			{
				nudCocaCola.Enabled = true;
				if (nudCocaCola.Value == 0)
					nudCocaCola.Value = 1;
			}
			else
			{
				nudCocaCola.Enabled = false;
				nudCocaCola.Value = 0;
			}
			Compute();
		}
		private void nudCocaCola_ValueChanged(object sender, EventArgs e)
		{
			if (nudHotDog.Value == 0)
				cbxHotDog.Checked = false;

			if (nudHamburger.Value == 0)
				cbxHamburger.Checked = false;

			if (nudFrenchFries.Value == 0)
				cbxFrenchFries.Checked = false;

			if (nudCocaCola.Value == 0)
				cbxCocaCola.Checked = false;

			Compute();
		}

		private void btnCompute_Click(object sender, EventArgs e)
		{
			Compute();
		}

		private void fMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			MessageBox.Show($"Day gain: {dayGain} {Settings.currency}\nTotal gain: {Settings.gain} {Settings.currency}", "Gain Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			checkOrder++;
			isPause = true;
			fCheck c = new fCheck(checkOrder, BuildCheckString());
			Settings.gain += Convert.ToDouble(tbxToPayTotal.Text);
			Settings.WriteSettings();
			dayGain += Convert.ToDouble(tbxToPayTotal.Text);
			c.ShowDialog();
		}
		private void btnSettings_Click(object sender, EventArgs e)
		{
			fSettings set = new fSettings();

			set.ShowDialog();
			ChangeSettings();
			Compute();
		}


		private void timer1_Tick(object sender, EventArgs e)
		{
			DateTime localDate = DateTime.Now;

			toolStripStatusLabel1.Text = localDate.ToShortTimeString();
			toolStripStatusLabel2.Text = localDate.ToShortDateString();

			if(isPause)
			{
				toolStripProgressBar1.Enabled = true;

				if(toolStripProgressBar1.Value > 0)// loop
				{
					toolStripProgressBar1.Value--;
				}
				else// if cntr == 0
				{
					isPause = false;
					toolStripProgressBar1.Enabled = false;
					DefaultPosition();
				}
			}

		}
	}
}
