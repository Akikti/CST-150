using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalSeconds, minutes, hours, days;
            int secondsInDay = 86400;
            int secondsInHour = 3600;
            int secondsInMinute = 60;

            int.TryParse(textBox1.Text, out totalSeconds);

            if (totalSeconds <= 60)
            {
                label2.Text = totalSeconds.ToString() + "  Seconds";
            }
            else if (totalSeconds >= (secondsInDay))
            {
                days = totalSeconds / (secondsInDay);
                totalSeconds = totalSeconds - (days / secondsInDay);
                label2.Text = days.ToString() + "  Days";
            }
            else if (totalSeconds >= (secondsInMinute))
            {
                minutes = totalSeconds / secondsInMinute;
                totalSeconds = totalSeconds - (minutes * secondsInMinute);
                label2.Text = minutes.ToString() + "  Minutes";
            }


            else if (totalSeconds >= (secondsInHour))
            {
                hours = totalSeconds / (secondsInHour);
                totalSeconds = totalSeconds - (hours / secondsInHour);
                label2.Text = hours.ToString() + "  Hours";
            }



        }
    }
}
        
        
  