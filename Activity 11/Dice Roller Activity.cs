using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
    public class Dice
    {
        private int numberOfSides;

       
        private static Random rnd = new Random();

        public Dice(int numberOfSides)
        {

            if (numberOfSides < 4 || numberOfSides > 20)
            {
                throw new ArgumentOutOfRangeException("Should be in range [4, 20] !");
            }

            this.numberOfSides = numberOfSides;
        }

        public int rollDie()
        {
            return rnd.Next(1, numberOfSides + 1);
        }

    }

    public class DieRoll
    {
        public static void Main()
        {
            dice1 = new Dice(6);
            dice2 = new Dice(6);

            int dice1Roll, dice2Roll;
            int numberOfRolls = 0;

            do
            {

                dice1Roll = dice1Roll.rollDie();
                dice2Roll = dice2Roll.rollDie();

                Console.WriteLine("Rolled [Dice 1: " + dice1Roll + ", Dice 2: " + dice2Roll + "]");

                ++numberOfRolls;

            } while (dice1Roll != 1 || dice2Roll != 1);

            Console.WriteLine("\nIt took " + numberOfRolls + " rolls to get snake eyes!");
        }
    }
}