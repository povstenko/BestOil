using Microsoft.Win32;
using System;

namespace BestOil
{
	static class Settings
	{
		// Cafe product price
		static public double hotDogPrice = 4.00;
		static public double hamburgerPrice = 5.40;
		static public double frenchFriesPrice = 7.20;
		static public double cocaColaPrice = 4.40;

		// Gas types price
		static public double a92Price = 27.00;
		static public double a95Price = 28.00;

		static public int pauseDuration = 10;// Time before clear
		static public string currency = "UAH";
		static public double gain = 0.00;// Total gain

		static string regKeyName = "Software\\Povstenko\\BestOil";

		static public void ReadSettings()
		{
			RegistryKey rk = null;

			try
			{
				rk = Registry.CurrentUser.OpenSubKey(regKeyName);

				if (rk != null)
				{
					hotDogPrice = Convert.ToDouble(rk.GetValue("HotDog"));
					hamburgerPrice = Convert.ToDouble(rk.GetValue("Hamburger"));
					frenchFriesPrice = Convert.ToDouble(rk.GetValue("FrenchFries"));
					cocaColaPrice = Convert.ToDouble(rk.GetValue("CocaCola"));

					a92Price = Convert.ToDouble(rk.GetValue("A92"));
					a95Price = Convert.ToDouble(rk.GetValue("A95"));

					pauseDuration = Convert.ToInt32(rk.GetValue("Pause"));
					currency = rk.GetValue("Currency").ToString();
					gain = Convert.ToDouble(rk.GetValue("Gain"));
				}
			}
			finally
			{
				if (rk != null) rk.Close();
			}
		}

		static public void WriteSettings()
		{
			RegistryKey rk = null;

			try
			{
				rk = Registry.CurrentUser.CreateSubKey(regKeyName);
				if (rk == null) return;

				rk.SetValue("HotDog", hotDogPrice);
				rk.SetValue("Hamburger", hamburgerPrice);
				rk.SetValue("FrenchFries", frenchFriesPrice);
				rk.SetValue("CocaCola", cocaColaPrice);

				rk.SetValue("A92", a92Price);
				rk.SetValue("A95", a95Price);

				rk.SetValue("Pause", pauseDuration);
				rk.SetValue("Currency", currency);
				rk.SetValue("Gain", gain);
			}
			finally
			{
				if (rk != null) rk.Close();
			}
		}
	}
}
