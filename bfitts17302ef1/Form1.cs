using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfitts17302ef1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            //#1: if
            result1ATextbox.Text = Ex2fCalculations.Calc01(input1ATextbox.Text);

            //#2: if {block}
            result2ATextbox.Text = Ex2fCalculations.Calc02(input2ATextbox.Text);

            //#3: If else
            result3ATextbox.Text = Ex2fCalculations.Calc03(input3ATextbox.Text);

            //#4: if else if
            result4ATextbox.Text = Ex2fCalculations.Calc04(input4ATextbox.Text);

            //#5: Better range test
            result5ATextbox.Text = Ex2fCalculations.Calc05(input5ATextbox.Text);

            //#6: Nested if statement
            result6ATextbox.Text = Ex2fCalculations.Calc06(input6ATextbox.Text, input6BTextbox.Text);

            //07: input validation
            result7ATextbox.Text = Ex2fCalculations.Calc07(input7ATextbox.Text);

            //08: Price * quantity shipped
            result8ATextbox.Text = Ex2fCalculations.Calc08(input8ATextbox.Text, input8BTextbox.Text);

            //09: Difference * rate
            result9ATextbox.Text = Ex2fCalculations.Calc09(input9ATextbox.Text, input9BTextbox.Text);

            //10: Divide Large
            result10ATextbox.Text = Ex2fCalculations.Calc10(input10ATextbox.Text, input10BTextbox.Text);
        }
    }
}