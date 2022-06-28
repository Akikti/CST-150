using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Number
{
    public partial class Form1 : Form
    {

        int maxDay;
        static int luckyNumber;

        public Form1()
        {
            InitializeComponent();
        }

        public int getLuckyNumber()
        {
            return luckyNumber;
        }

        public void birthDay()
        {
            maxDay = 0;
            if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 2 || comboBox2.SelectedIndex == 4 || comboBox2.SelectedIndex == 6 || comboBox2.SelectedIndex == 7 || comboBox2.SelectedIndex == 9 || comboBox2.SelectedIndex == 11)
            {
                maxDay = 31;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                int year = Int32.Parse(comboBox1.Text);

                if (year % 400 == 0)
                    maxDay = 29;

                if (year % 100 == 0)
                    maxDay = 28;

                if (year % 4 == 0)
                    maxDay = 29;
                else
                    maxDay = 28;
            }
            else
                maxDay = 30;

            if (comboBox2.SelectedIndex != -1)
            {
                comboBox3.Items.Clear();
                for (int i = 0; i < maxDay; i++)
                {
                    comboBox3.Items.Add(i + 1);
                }
                comboBox3.Text = maxDay.ToString();
            }

            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {
                birthDay();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                maxDay = 0;
                if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 2 || comboBox2.SelectedIndex == 4 || comboBox2.SelectedIndex == 6 || comboBox2.SelectedIndex == 7 || comboBox2.SelectedIndex == 9 || comboBox2.SelectedIndex == 11)
                {
                    maxDay = 31;
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    int year = Int32.Parse(comboBox1.Text);

                    if (year % 400 == 0)
                        maxDay = 29;

                    if (year % 100 == 0)
                        maxDay = 28;

                    if (year % 4 == 0)
                        maxDay = 29;

                    else
                        maxDay = 28;
                }

                else
                    maxDay = 30;

                if (comboBox2.SelectedIndex != -1)
                {
                    comboBox3.Items.Clear();

                    for (int i = 0; i < maxDay; i++)
                    {
                        comboBox3.Items.Add(i + 1);
                    }
                    comboBox3.Text = maxDay.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "2004";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
            {
                luckyNumber = (comboBox1.SelectedIndex + comboBox2.SelectedIndex + comboBox3.SelectedIndex + comboBox4.SelectedIndex);
                Form2 frm2 = new Form2();
                frm2.Show();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDay();
        }

        private static void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


        
    


        
        

