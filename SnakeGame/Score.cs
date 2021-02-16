using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace SnakeGame
{
    public class Score
    {
        //Params settings = new Params();
        //private static string pathToRecordFile;
        //private static string pathToResultsFile;
        //private int currentPoints = 0;

        public Score(int score, string pathToResources)
        {
            Console.Clear();
            Console.WriteLine("Your name: ");
            string name = Console.ReadLine();
            StreamWriter file = new StreamWriter(pathToResources + "score.txt", true); //запись в файл
            file.WriteLine(name + "-" + score + " ");//запись имени игрока и его счета
            file.Close();
        }
        //{
        //    pathToRecordFile = _pathToResources + "record.txt";
        //    pathToResultsFile = _pathToResources + "results.txt";
        //    Console.ForegroundColor = ConsoleColor.DarkGray;
        //    WriteText("Score: ", 92, 1);
        //    ShowCurrentPoints();
        //    Console.ForegroundColor = ConsoleColor.Black;
        //    WriteText("Record: ", 90, 5);
        //    WriteText(GetBestResult(), 98, 5);
        //    WriteText("-----------------------", 80, 6);
        }
        public string GetBestResult(int score, string pathToResources)
        {
            // Read from file
            Console.Clear();
            Console.WriteLine("Your name: ");
            string name = Console.ReadLine();
            StreamWriter file = new StreamWriter(pathToResources + "score.txt", true); //запись в файл
            file.WriteLine(name + "-" + score + " ");//запись имени игрока и его счета
            file.Close();

        }

        //public void WriteBestResult()
        //{
        //    if (currentPoints > Convert.ToInt32(GetBestResult()))
        //    {
        //        // Write in file
        //        StreamWriter streamWriter = new StreamWriter(pathToRecordFile);
        //        streamWriter.Write(currentPoints);
        //        streamWriter.Close();

        //        // Write in file
        //        StreamWriter streamWriter1 = new StreamWriter(pathToResultsFile, true);
        //        streamWriter1.WriteLine(currentPoints);
        //        streamWriter1.Close();
        //    }
        //    else
        //    {
        //        // Write in file
        //        StreamWriter streamWriter = new StreamWriter(pathToResultsFile, true);
        //        streamWriter.WriteLine(currentPoints);
        //        streamWriter.Close();
        //    }
        //}

        //public void ShowCurrentPoints()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    if (currentPoints == 0)
        //    {
        //        Console.SetCursorPosition(94, 3);
        //    }
        //    else if (currentPoints > 0)
        //    {
        //        Thread.Sleep(100);
        //        Console.SetCursorPosition(93, 3);
        //    }

        //    Console.WriteLine(currentPoints.ToString());
        //}
        //static void WriteText(String text, int xOffset, int yOffset)
        //{
        //    Console.SetCursorPosition(xOffset, yOffset);
        //    Console.WriteLine(text);
        //}
    }

}
