using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfitts17302A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            decimal discountAmount = 
                Convert.ToDecimal(txtSubtotal.Text)
                * Convert.ToDecimal(txtDiscountPercent.Text) / 100;
            txtDiscountAmount.Text = discountAmount.ToString("n2");
            decimal Total =
                Convert.ToDecimal(txtSubtotal.Text)
                - discountAmount; 
            txtTotal.Text = Total.ToString("n2");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
