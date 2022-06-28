using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int?[,] gameArray = new int?[3, 3];

            bool isXWin = false; ;
            bool isOWin = false;

            Random r = new Random();

            gameArray[0, 0] = r.Next(0, 2);
            gameArray[0, 1] = r.Next(0, 2);
            gameArray[0, 2] = r.Next(0, 2);
            gameArray[1, 0] = r.Next(0, 2);
            gameArray[1, 1] = r.Next(0, 2);
            gameArray[1, 2] = r.Next(0, 2);
            gameArray[2, 0] = r.Next(0, 2);
            gameArray[2, 1] = r.Next(0, 2);
            gameArray[2, 2] = r.Next(0, 2);


            if (gameArray[0, 0] == gameArray[0, 1] && gameArray[0, 1] == gameArray[0, 2])
            {
                isXWin = gameArray[0, 0] == 1;
                isOWin = gameArray[0, 0] == 0;
            }

            else if (gameArray[1, 0] == gameArray[1, 1] && gameArray[1, 1] == gameArray[1, 2])
            {
                isXWin = gameArray[1, 0] == 1;
                isOWin = gameArray[1, 0] == 0;
            }

            else if (gameArray[2, 1] == gameArray[2, 1] && gameArray[2, 1] == gameArray[2, 2])
            {
                isXWin = gameArray[2, 1] == 1;
                isOWin = gameArray[2, 1] == 0;
            }
            else if (gameArray[0, 0] == gameArray[1, 0] && gameArray[1, 0] == gameArray[2, 0])
            {
                isXWin = gameArray[0, 0] == 1;
                isOWin = gameArray[0, 0] == 0;
            }
            else if (gameArray[0, 1] == gameArray[1, 1] && gameArray[1, 1] == gameArray[2, 1])
            {
                isXWin = gameArray[0, 1] == 1;
                isOWin = gameArray[0, 1] == 0;
            }
            else if (gameArray[0, 2] == gameArray[1, 2] && gameArray[1, 2] == gameArray[2, 2])
            {
                isXWin = gameArray[0, 2] == 1;
                isOWin = gameArray[0, 2] == 0;
            }
            else if (gameArray[0, 0] == gameArray[1, 1] && gameArray[1, 1] == gameArray[2, 2])
            {
                isXWin = gameArray[0, 0] == 1;
                isOWin = gameArray[0, 0] == 0;
            }
            else if (gameArray[0, 2] == gameArray[1, 1] && gameArray[1, 1] == gameArray[2, 0])
            {
                isXWin = gameArray[0, 2] == 1;
                isOWin = gameArray[0, 2] == 0;
            }

            label1.Text = gameArray[0, 0] == 1 ? "X" : "O";
            label2.Text = gameArray[0, 1] == 1 ? "X" : "O";
            label3.Text = gameArray[0, 2] == 1 ? "X" : "O";
            label4.Text = gameArray[1, 0] == 1 ? "X" : "O";
            label5.Text = gameArray[1, 1] == 1 ? "X" : "O";
            label6.Text = gameArray[1, 2] == 1 ? "X" : "O";
            label7.Text = gameArray[2, 0] == 1 ? "X" : "O";
            label8.Text = gameArray[2, 1] == 1 ? "X" : "O";
            label9.Text = gameArray[2, 2] == 1 ? "X" : "O";

            if (isXWin)
            {
                txtResult.Text = "X Wins!";
            }

            else if (isOWin)
            {
                txtResult.Text = "O Wins!";
            }

            else
            {
                txtResult.Text = "Game Draw!";
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
