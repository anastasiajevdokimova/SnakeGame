using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    public class Colors
    {
        public Colors(int score)
        {
            if (score <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (score >= 11 && score <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (score >= 21 && score <= 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else if (score >= 31 && score <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    }
}
