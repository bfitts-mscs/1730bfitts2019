using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfitts17302c1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetMinButton_Click(object sender, EventArgs e)
        {
            byte byte1, byte2, byte3;
            sbyte sbyte1, sbyte2, sbyte3;
            short short1, short2, short3;
            ushort ushort1, ushort2, ushort3;
            int int1, int2, int3;
            uint uint1, uint2, uint3;
            long long1, long2, long3;
            ulong ulong1, ulong2, ulong3;
            float float1, float2, float3;
            double double1, double2, double3;
            decimal decimal1, decimal2, decimal3;

            byte1 = byte.MinValue;
            sbyte1 = sbyte.MinValue;
            short1 = short.MinValue;
            ushort1 = ushort.MinValue;
            int1 = int.MinValue;
            uint1 = uint.MinValue;
            long1 = long.MinValue;
            ulong1 = ulong.MinValue;
            float1 = float.MinValue;
            double1 = double.MinValue;
            decimal1 = decimal.MinValue;

            byte1Textbox.Text = byte1.ToString();
            sbyte1Textbox.Text = sbyte1.ToString();
            short1Textbox.Text = short1.ToString();
            ushort1Textbox.Text = ushort1.ToString();
            int1Textbox.Text = int1.ToString();
            uint1Textbox.Text = uint1.ToString();
            long1Textbox.Text = long1.ToString();
            ulong1Textbox.Text = ulong1.ToString();
            float1Textbox.Text = float1.ToString();
            double1Textbox.Text = double1.ToString();
            decimal1Textbox.Text = decimal1.ToString();
        }

        private void SetMaxButton_Click(object sender, EventArgs e)
        {
            byte byte1, byte2, byte3;
            sbyte sbyte1, sbyte2, sbyte3;
            short short1, short2, short3;
            ushort ushort1, ushort2, ushort3;
            int int1, int2, int3;
            uint uint1, uint2, uint3;
            long long1, long2, long3;
            ulong ulong1, ulong2, ulong3;
            float float1, float2, float3;
            double double1, double2, double3;
            decimal decimal1, decimal2, decimal3;

            byte2 = byte.MaxValue;
            sbyte2 = sbyte.MaxValue;
            short2 = short.MaxValue;
            ushort2 = ushort.MaxValue;
            int2 = int.MaxValue;
            uint2 = uint.MaxValue;
            long2 = long.MaxValue;
            ulong2 = ulong.MaxValue;
            float2 = float.MaxValue;
            double2 = double.MaxValue;
            decimal2 = decimal.MaxValue;

            byte2Textbox.Text = byte2.ToString();
            sbyte2Textbox.Text = sbyte2.ToString();
            short2Textbox.Text = short2.ToString();
            ushort2Textbox.Text = ushort2.ToString();
            int2Textbox.Text = int2.ToString();
            uint2Textbox.Text = uint2.ToString();
            long2Textbox.Text = long2.ToString();
            ulong2Textbox.Text = ulong2.ToString();
            float2Textbox.Text = float2.ToString();
            double2Textbox.Text = double2.ToString();
            decimal2Textbox.Text = decimal2.ToString();
        }
    }
}
