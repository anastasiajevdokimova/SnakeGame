using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame
{
    class Score
    {
        List<int> scoreList = new List<int>();

        List<Person> peopleList = new List<Person>();
        public void ScoreTable()
        {
            foreach (var s in scoreList)
            {

            }
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}
