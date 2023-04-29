using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        public static void ChecksNoplayLadderSnake()
        {
            Console.WriteLine("start the snake and ladder Game");
            int position = 0;
                // generate a random number between 1 and 3 to determine the option
                Random random = new Random();
                int option = random.Next(1, 4);

                switch (option)
                {
                    case 1: // No Play
                        Console.WriteLine("No Play --> You stay in the same position");
                        break;
                    case 2: // Ladder
                        int ladder = random.Next(1, 7); // generate a random number for the ladder position
                        Console.WriteLine("Ladder --> You move ahead by " + ladder + " positions");
                        position += ladder; // update position + random ladder
                        break;
                    case 3: // Snake
                        int snake = random.Next(1, 7); // generate a random number for the snake position
                        Console.WriteLine("Snake --> You move back by " + snake + " positions");
                        position -= snake; // update position - random number
                        if (position < 0) 
                        {
                            position = 0; // set position to 0.
                        }
                        break;
                }
            Console.WriteLine("You are now at position " + position);

        }
    }
        
}
