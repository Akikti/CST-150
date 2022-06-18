using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void calcbtn_Click(object sender, EventArgs e)
        {
            int n;
            double piVal = 4, num = 4, den = 3;
            n = Convert.ToInt32(textBox1.Text);
            for(int i=0;i<=n; i++)
            {
                if (i % 2 == 0)
                {
                    piVal -= num / den;
                }
                else
                {
                    piVal += num / den;
                }
                den += 2;
            }
            label2.Text = "Approximate value of pi after " + n + "  terms";
            label3.Text = "=  " + piVal;
        }
    }
}
