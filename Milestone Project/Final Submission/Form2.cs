using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Application
{
    public partial class Form2 : Form
    {
        int i = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Price = (double)numericUpDown1.Value;
            double Conversion = Price * 7.99;
            label4.Text = " $ " + Conversion.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i += 1;
            comboBox1.Items.Add("Item " + i);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0 && !(String.IsNullOrEmpty(comboBox1.Text)))
            {
                comboBox1.Items.Remove(comboBox1.Text);
            }
            else
            {
                MessageBox.Show("Nothing");
            }
        }

        }
    }


