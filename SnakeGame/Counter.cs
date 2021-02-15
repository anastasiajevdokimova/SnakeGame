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
            this.score = score
        }
        public void ScoreDown()
        {
            score -= 4;
        }
        public void ScoreUp()
        {
            score += 3;
        }
        public int GetScore()
        {
            return score;
        }
    }
}
