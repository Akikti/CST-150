using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Calculator
{
    public partial class Form1 : Form
    {
        public object calCarbsLabel { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int fatCalories(int fatGram)
        {
            return fatGram * 9;
        }
        private int carbsCalories(int carbsGrams)
        {
            return carbsGrams * 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int calFromFat, fatGrams, calFromCarbs, carbsGrams;

            if (int.TryParse(fatTextBox.Text, out fatGrams))
            {
                calFromFat = fatGrams * 9;
                calFat.Text = calFromFat.ToString("n1");
            }
            else
            {
                MessageBox.Show("Enter Numeric Value for Fat Grams.");
            }
            if (int.TryParse(carbsTextBox.Text, out carbsGrams))
            {
                calFromCarbs = carbsGrams * 4;
                calCarbs.Text = calFromCarbs.ToString("n1");
            }
            else
            {
                MessageBox.Show("Enter Numeric Value for Carbs Grams.");
            }
        }

        private void button2_Click(object sender, EventArgs e, object calCarbsLabel)
        {
            fatTextBox.Text = "";
            carbsTextBox.Text = "";
            object calFatLabel = null;
            calFat.Text = "";
            calCarbs.Text = "";
            fatTextBox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calFat_Click(object sender, EventArgs e)
        {

        }
    }
}
