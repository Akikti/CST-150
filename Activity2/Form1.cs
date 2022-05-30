using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////Set the conversion once the button is clicked and runs the conversion from Miles to Feet.
            double Miles = (double)numericUpDown2.Value;
            double Conversion = Miles * 5280;
            label3.Text = Conversion.ToString() + "  Miles in Feet";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Clears all fillable fields.
            numericUpDown1.Text = String.Empty;
            numericUpDown2.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Set the conversion once the button is clicked and runs the conversion from Feet to Miles.
            double Feet = (double)numericUpDown1.Value;
            double Conversion = Feet * 0.000189394;
            label3.Text = Conversion.ToString() + "  Feet in Miles";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
