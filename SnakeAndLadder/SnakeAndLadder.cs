using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        public static void DiceRoll()
        {
            Console.WriteLine("start the snake and ladder Game");
            Console.WriteLine("Press any key to roll the dice");
            Console.ReadKey();

            // generate a random number between 1 and 6 after dice roll
            Random random = new Random();
            int rollDice = random.Next(1, 7);  //used random to get the number between 1 to 6

            Console.WriteLine();
            Console.WriteLine("You rolled a " + rollDice);
        }
    }
        
}
