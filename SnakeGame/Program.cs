﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame
{
	class Program
	{
		//List<int> scorelist = new List<int>();
		
		static void Main(string[] args)
		{
			Console.SetWindowSize(80, 25);

			Walls walls = new Walls(80, 25);
			walls.Draw();

			// Отрисовка точек			
			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();
			//FoodCreator foodCreator1 = new FoodCreator(50, 15, '#');
			//Point food1 = foodCreator.CreateFood();
			//food1.Draw();
			//FoodCreator foodCreator2 = new FoodCreator(40, 5, '^');
			//Point food2 = foodCreator.CreateFood();
			//food2.Draw();

			//Пути и настройки
			Params settings = new Params();

			Sounds sound1 = new Sounds(settings.GetResourceFolder());
			Sounds sound2 = new Sounds(settings.GetResourceFolder());
			Sounds sound = new Sounds(settings.GetResourceFolder());
			sound.Play();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				if (snake.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
					sound1.PlayEat();

                }
    //            else if (snake.Eat(food))
    //            {
    //                food1= foodCreator.CreateFood();
    //                food1.Draw();
				//	sound1.PlayEat();
				//}
    //            else if (snake.Eat(food))
    //            {
    //                food2 = foodCreator.CreateFood();
    //                food2.Draw();
				//	sound1.PlayEat();
				//}
                else
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			GameOver();
			sound2.PlayEnd();
			Console.ReadLine();
		}
        static void GameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            WriteText("-------GAME OVER-------", xOffset + 1, yOffset++);
			Console.Write("Please, enter your username: ");


		}
		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}

	}
}
