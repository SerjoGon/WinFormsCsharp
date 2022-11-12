using HW_8_BestOil.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_8_BestOil
{
    public partial class fSettings : Form
    {
        
        public fSettings()
        {
            InitializeComponent();
        }
        private void SetDefault()
        {
            tbxHotDogPrice.Text = Settings.hotDogPrice.ToString("#.##");
            tbxHamburgerPrice.Text = Settings.hamburgerPrice.ToString("#.##");
            tbxFrenchFriesPrice.Text = Settings.frenchFriesPrice.ToString("#.##");
            tbxCocaColaPrice.Text = Settings.cocaColaPrice.ToString("#.##");

            tbxA92Price.Text = Settings.a92Price.ToString("#.##");
            tbxA95Price.Text = Settings.a95Price.ToString("#.##");

            nudPause.Value = Settings.pauseDuration;
            tbxCurrency.Text = Settings.currency;
            tbxGain.Text = Settings.gain.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings.hotDogPrice = Convert.ToDouble(tbxHotDogPrice.Text);
            Settings.hamburgerPrice = Convert.ToDouble(tbxHamburgerPrice.Text);
            Settings.frenchFriesPrice = Convert.ToDouble(tbxFrenchFriesPrice.Text);
            Settings.cocaColaPrice = Convert.ToDouble(tbxCocaColaPrice.Text);

            Settings.a92Price = Convert.ToDouble(tbxA92Price.Text);
            Settings.a95Price = Convert.ToDouble(tbxA95Price.Text);

            Settings.pauseDuration = Convert.ToInt32(nudPause.Value);
            Settings.currency = tbxCurrency.Text;
            Settings.gain = Convert.ToDouble(tbxGain.Text);

            Settings.WriteSettings();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetDefault();
            Close();
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            SetDefault();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxGain.Text = "0";
            Settings.gain = Convert.ToDouble(tbxGain.Text);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value != 0)
            {
                Settings.trbar1Red = trackBar1.Value;
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            if (trackBar3.Value != 0)
            {
                Settings.trbar2Green = trackBar3.Value;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (trackBar2.Value != 0)
            {
                Settings.trbar3Blue = trackBar2.Value;
            }
        }
    }
}
