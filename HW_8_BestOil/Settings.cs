using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_BestOil
{
    static class Settings
    {
        static public double hotDogPrice = 100.00;
        static public double hamburgerPrice = 125.00;
        static public double frenchFriesPrice = 65.00;
        static public double cocaColaPrice = 44.50;

        static public double a92Price = 48.80;
        static public double a95Price = 53.20;

        static public int pauseDuration = 10;
        static public string currency = "РУБ";
        static public double gain = 0.00;

        static string regKeyName = "Software\\BestOil";

        public static int trbar1Red = 123;
        public static int trbar2Green = 32;
        public static int trbar3Blue = 34;
        static public void ReadSettings()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);

                if (rk != null)
                {
                    hotDogPrice = Convert.ToDouble(rk.GetValue("Хот-Дог"));
                    hamburgerPrice = Convert.ToDouble(rk.GetValue("Гамбургер"));
                    frenchFriesPrice = Convert.ToDouble(rk.GetValue("Карт.Фри"));
                    cocaColaPrice = Convert.ToDouble(rk.GetValue("Кола"));

                    a92Price = Convert.ToDouble(rk.GetValue("A92"));
                    a95Price = Convert.ToDouble(rk.GetValue("A95"));

                    pauseDuration = Convert.ToInt32(rk.GetValue("Пауза"));
                    currency = rk.GetValue("Валюта").ToString();
                    gain = Convert.ToDouble(rk.GetValue("Получено"));
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

                rk.SetValue("Хот-Дог", hotDogPrice);
                rk.SetValue("Гамбургер", hamburgerPrice);
                rk.SetValue("Карт.Фри", frenchFriesPrice);
                rk.SetValue("Кола", cocaColaPrice);

                rk.SetValue("A92", a92Price);
                rk.SetValue("A95", a95Price);

                rk.SetValue("Пауза", pauseDuration);
                rk.SetValue("Валюта", currency);
                rk.SetValue("Получено", gain);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
