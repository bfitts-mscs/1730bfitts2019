using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfitts17301e1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtAveragescore.Text = (
                    (Convert.ToDecimal(txtTestone.Text) + Convert.ToDecimal(txtTesttwo.Text) + Convert.ToDecimal(txtTestthree.Text) + Convert.ToDecimal(txtTestfour.Text) + Convert.ToDecimal(txtTestfive.Text) + Convert.ToDecimal(txtTestsix.Text) + Convert.ToDecimal(txtTestseven.Text)) / 7.0m
                    ).ToString("0.00");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtTestone.Text = "0";
            txtTesttwo.Text = "0";
            txtTestthree.Text = "0";
            txtAveragescore.Text = "";
        }
    }
}
