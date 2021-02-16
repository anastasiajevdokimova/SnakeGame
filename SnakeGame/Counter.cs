using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Counter
    {
        public int score;

        public Counter()
        {

        }
        public Counter(int score)
        {
            this.score = score;
        }
        public void ScoreDown()
        {
            score -= 4;
        }
        public void ScoreUp()
        {
            score += 1;
        }
        public void ScoreUp3()
        {
            score += 3;
        }
        public int GetScore()
        {
            return score;
        }
        public void ScoreWrite()
        {
            int xOffset = 80;
            int yOffset = 22;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("Score: " + score + " ", xOffset, yOffset++);
        }
        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
