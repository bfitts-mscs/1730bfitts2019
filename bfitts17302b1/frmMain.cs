using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfitts17302b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();          
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal albaniaAmount = Convert.ToDecimal(txtAmountAlbania.Text);
            decimal albaniaRate = Convert.ToDecimal(txtRateAlbania.Text);
            decimal albaniaUSD = albaniaAmount * albaniaRate;
            txtUSDAlbania.Text = (albaniaUSD).ToString("n2");
            decimal gibraltarAmount = Convert.ToDecimal(txtAmountGibraltar.Text);
            decimal gibraltarRate = Convert.ToDecimal(txtRateGibraltar.Text);
            decimal gibraltarUSD = gibraltarAmount * gibraltarRate;
            txtUSDGibraltar.Text = (gibraltarUSD).ToString("n2");
            decimal bangladeshAmount = Convert.ToDecimal(txtAmountBangladesh.Text);
            decimal bangladeshRate = Convert.ToDecimal(txtRateBangladesh.Text);
            decimal bangladeshUSD = bangladeshAmount * bangladeshRate;
            txtUSDBangladesh.Text = (bangladeshUSD).ToString("n2");
            decimal swedishAmount = Convert.ToDecimal(txtAmountSwedish.Text);
            decimal swedishRate = Convert.ToDecimal(txtRateSwedish.Text);
            decimal swedishUSD = swedishAmount * swedishRate;
            txtUSDSwedish.Text = (swedishUSD).ToString("n2");
            decimal totalUSD = albaniaUSD + gibraltarUSD + bangladeshUSD + swedishUSD;
            txtTotalUSD.Text = (totalUSD).ToString("n2");
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
