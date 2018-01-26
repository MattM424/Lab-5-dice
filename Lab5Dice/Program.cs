using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter the number of sides youd like your dice to have before we roll?");
                int Sides = int.Parse(Console.ReadLine());


                Random roll = new Random();

                int Dice1 = roll.Next(1, Sides + 1);
                int Dice2 = roll.Next(1, Sides + 1);
                int Total = Dice1 + Dice2;

                Console.WriteLine(Dice1);
                Console.WriteLine(Dice2);
                Console.WriteLine(Total);
                if (Total == 7 || Total == 11)
                {
                    Console.WriteLine("Craps!");
                }
                else if (Total == 2)
                {
                    Console.WriteLine("Snake eyes!");
                }
                else if (Dice1 == 6 && Dice2 == 6) 
                {
                    Console.WriteLine("Box cars!");
                }
                else
                {

                }


                Console.WriteLine("Would you like to roll again? (Yes/No)");
                if (Console.ReadLine().ToLower() != "yes")
                    break;
            }
        }
    }
}
