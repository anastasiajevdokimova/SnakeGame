using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace SnakeGame
{
    public class Score
    {
        Params settings = new Params();
        private static string pathToRecordFile;
        private static string pathToResultsFile;
        private int currentPoints = 0;

        public Score(string _pathToResources)
        {
            pathToRecordFile = _pathToResources + "record.txt";
            pathToResultsFile = _pathToResources + "results.txt";
            Console.ForegroundColor = ConsoleColor.DarkGray;
            WriteText("Score: ", 92, 1);
            ShowCurrentPoints();
            Console.ForegroundColor = ConsoleColor.Black;
            WriteText("Record: ", 90, 5);
            WriteText(GetBestResult(), 98, 5);
            WriteText("-----------------------", 80, 6);
        }
        public string GetBestResult()
        {
            // Read from file
            StreamReader streamReader = new StreamReader(pathToRecordFile);
            string record = streamReader.ReadToEnd();
            streamReader.Close();
            if (record == "")
            {
                record = "0";
            }

            return record;
        }
        public void ShowCurrentPoints()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (currentPoints == 0)
            {
                Console.SetCursorPosition(94, 3);
            }
            else if (currentPoints > 0)
            {
                Console.SetCursorPosition(93, 3);
            }

            Console.WriteLine(currentPoints.ToString());
        }
        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
        public void UpCurrentPoints()
        {
            currentPoints += 10;
        }

    }

}
