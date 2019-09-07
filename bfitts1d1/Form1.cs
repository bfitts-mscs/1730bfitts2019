using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfitts1d1
{
    public partial class bfitts1730CurrencyConverter : Form
    {
        public bfitts1730CurrencyConverter()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void albaniaTextChanged(object sender, EventArgs e)
        {
            txtUSDAlbania.Text = (
                Convert.ToDecimal(txtAmountAlbania.Text) * Convert.ToDecimal(txtRateAlbania.Text)
                ).ToString("0.00");

        }

        private void gibraltarTextChange(object sender, EventArgs e)
        {
            txtUSDGibraltar.Text = (
                Convert.ToDecimal(txtAmountGibraltar.Text) * Convert.ToDecimal(txtRateGibraltar.Text)
                ).ToString("0.00");
        }

        private void bangladeshTextChange(object sender, EventArgs e)
        {
            txtUSDBangladesh.Text = (
                Convert.ToDecimal(txtAmountBangladesh.Text) * Convert.ToDecimal(txtRateBangladesh.Text)
                ).ToString("0.00");
        }

        private void swedishTextChange(object sender, EventArgs e)
        {
            txtUSDSwedish.Text = (
                Convert.ToDecimal(txtAmountSwedish.Text) * Convert.ToDecimal(txtRateSwedish.Text)
                ).ToString("0.00");
        }

        private void USDTotal(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAlbania.Text) + Convert.ToDecimal(txtUSDGibraltar.Text) + 
                Convert.ToDecimal(txtUSDBangladesh.Text) + Convert.ToDecimal(txtUSDSwedish.Text)
                ).ToString("0.00");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountAlbania.Text = ("0.00");
            txtRateAlbania.Text = ("0.00906789");
            txtAmountBangladesh.Text = ("0.00");
            txtRateBangladesh.Text = ("1.23388");
            txtAmountGibraltar.Text = ("0.00");
            txtRateGibraltar.Text = ("0.0118494");
            txtAmountSwedish.Text = ("0.00");
            txtRateSwedish.Text = ("0.103565");
            txtTotalUSD.Text = ("0.00");
        }
    }
}
