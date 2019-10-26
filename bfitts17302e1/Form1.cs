using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfitts17302e1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            result01ATextBox.Text = "";
            result02ATextBox.Text = "";
            result03ATextBox.Text = "";
            result03BTextBox.Text = "";
            result04ATextBox.Text = "";
            result04BTextBox.Text = "";
            result05ATextBox.Text = "";
            result05BTextBox.Text = "";
            result06ATextBox.Text = "";
            result06BTextBox.Text = "";
            result07ATextBox.Text = "";
            result08ATextBox.Text = "";
            result09ATextBox.Text = "";
            result09BTextBox.Text = "";
            result10ATextBox.Text = "";
            result11ATextBox.Text = "";
            result12ATextBox.Text = "";
            result13ATextBox.Text = "";

            //01
            decimal subtotal = Convert.ToDecimal(input01TextBox.Text);
            //result01ATextBox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01ATextBox.Text = (LogicalOperations.q01(subtotal)).ToString();

            //02
            int timeInService = Convert.ToInt32(input02TextBox.Text);
            result02ATextBox.Text = (LogicalOperations.q02(timeInService)).ToString();

            //03
            bool isValid = Convert.ToBoolean(input03ATextBox.Text);
            int years = Convert.ToInt32(input03CTextBox.Text);

            //03
            int counter = Convert.ToInt32(input03BTextBox.Text);
            result03ATextBox.Text = (LogicalOperations.q03(isValid, years, counter)).ToString();
            result03BTextBox.Text = counter.ToString();

            //04
            counter = Convert.ToInt32(input03BTextBox.Text);
            result04ATextBox.Text = (LogicalOperations.q04(isValid, counter, years)).ToString();
            result04BTextBox.Text = counter.ToString();

            //05
            counter = Convert.ToInt32(input03BTextBox.Text);
            result05ATextBox.Text = (LogicalOperations.q05(isValid, counter, years)).ToString();
            result05BTextBox.Text = counter.ToString();

            //06
            counter = Convert.ToInt32(input03BTextBox.Text);
            result06ATextBox.Text = (LogicalOperations.q06(isValid, years, counter)).ToString();
            result06BTextBox.Text = counter.ToString();

            //07  DateTime startDate, DateTime expirationDate, DateTime date
            DateTime startDate = Convert.ToDateTime(input07ATextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input07BTextBox.Text);
            DateTime date = Convert.ToDateTime(input07CTextBox.Text);
            isValid = Convert.ToBoolean(input07DTextBox.Text);
            result07ATextBox.Text = (LogicalOperations.q07(startDate, expirationDate, date, isValid)).ToString();

            //08  decimal thisYTD, decimal lastYTD, string emptype, int startYear, int currentYear
            decimal thisYTD = Convert.ToDecimal(input08ATextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input08BTextBox.Text);
            string emptype = input08CTextBox.Text;
            int startYear = Convert.ToInt32(input08DTextBox.Text);
            int currentYear = Convert.ToInt32(input08ETextBox.Text);
            result08ATextBox.Text = (LogicalOperations.q08(thisYTD, lastYTD, emptype, startYear, currentYear)).ToString();

            //09
            counter = Convert.ToInt32(input09ATextBox.Text);
            years = Convert.ToInt32(input09BTextBox.Text);
            result09ATextBox.Text = (LogicalOperations.q09(years, counter)).ToString();
            result09BTextBox.Text = counter.ToString();

            //10  int a, int b, int c, int d
            int a = Convert.ToInt32(input10ATextBox.Text);
            int b = Convert.ToInt32(input10BTextBox.Text);
            int c = Convert.ToInt32(input10CTextBox.Text);
            int d = Convert.ToInt32(input10DTextBox.Text);

            result10ATextBox.Text = (LogicalOperations.q10(a, b, c, d)).ToString();

            //11 bool member, decimal price, float weight
            bool member = Convert.ToBoolean(input11ATextBox.Text);
            decimal price = Convert.ToDecimal(input11BTextBox.Text);
            float weight = Convert.ToSingle(input11CTextBox.Text);
            result11ATextBox.Text = (LogicalOperations.q11(member, price, weight)).ToString();

            //12
            member = Convert.ToBoolean(input12ATextBox.Text);
            price = Convert.ToDecimal(input12BTextBox.Text);
            weight = Convert.ToSingle(input12CTextBox.Text);
            result12ATextBox.Text = (LogicalOperations.q12(member, price, weight)).ToString();

            //13    is sales tax due? tax in minnesota, clothing and food no tax string shipState, string itemType
            string shipState = input13ATextBox.Text;
            string itemType = input13BTextBox.Text;
            result13ATextBox.Text = (LogicalOperations.q13(shipState, itemType)).ToString();
        }
    }
}
