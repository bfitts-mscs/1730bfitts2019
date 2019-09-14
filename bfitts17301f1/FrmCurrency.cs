using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfitts17301f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnAlbania.BackgroundImage = picAlbania.Image;
            btnBangladesh.BackgroundImage = picBangladeshdim.Image;
            btnGibraltar.BackgroundImage = picGibraltardim.Image;
            btnSwedish.BackgroundImage = picSwedishdim.Image;
            txtRate.Text = "0.00906789";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = btnAlbania.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnAlbania_Click(object sender, EventArgs e)
        {
            btnAlbania.BackgroundImage = picAlbania.Image;
            btnBangladesh.BackgroundImage = picBangladeshdim.Image;
            btnGibraltar.BackgroundImage = picGibraltardim.Image;
            btnSwedish.BackgroundImage = picSwedishdim.Image;
            txtRate.Text = "0.00906789";
            lblCurrency.Text = btnAlbania.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnBangladesh_Click(object sender, EventArgs e)
        {
            btnAlbania.BackgroundImage = picAlbaniadim.Image;
            btnBangladesh.BackgroundImage = picBangladesh.Image;
            btnGibraltar.BackgroundImage = picGibraltardim.Image;
            btnSwedish.BackgroundImage = picSwedishdim.Image;
            txtRate.Text = "1.23388";
            lblCurrency.Text = btnBangladesh.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnGibraltar_Click(object sender, EventArgs e)
        {
            btnAlbania.BackgroundImage = picAlbaniadim.Image;
            btnBangladesh.BackgroundImage = picBangladeshdim.Image;
            btnGibraltar.BackgroundImage = picGibraltar.Image;
            btnSwedish.BackgroundImage = picSwedishdim.Image;
            txtRate.Text = "0.0118494";
            lblCurrency.Text = btnGibraltar.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnSwedish_Click(object sender, EventArgs e)
        {
            btnAlbania.BackgroundImage = picAlbaniadim.Image;
            btnBangladesh.BackgroundImage = picBangladeshdim.Image;
            btnGibraltar.BackgroundImage = picGibraltardim.Image;
            btnSwedish.BackgroundImage = picSwedish.Image;
            txtRate.Text = "0.103565";
            lblCurrency.Text = btnSwedish.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text =
            (Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void txtCurrency_Enter(object sender, MouseEventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtTotalUSD.Text) + Convert.ToDecimal(txtUSDollars.Text)
                ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtTotalUSD.Text;
            txtCurrency.Focus();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnAlbania.BackgroundImage = picAlbania.Image;
            btnBangladesh.BackgroundImage = picBangladeshdim.Image;
            btnGibraltar.BackgroundImage = picGibraltardim.Image;
            btnSwedish.BackgroundImage = picSwedishdim.Image;
            txtRate.Text = "0.00906789";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = btnAlbania.Text + ": ";
            txtCurrency.Text = "0.00";
            lblEquation.Text = " ";
            txtCurrency.Focus();
        }
    }
}
