using System;
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
			FoodCreator foodd = new FoodCreator(80, 25, '#');
			Point f = foodCreator.CreateFood();
			food.Draw();
			FoodCreator fooddd = new FoodCreator(80, 25, '^');
			Point ff = foodCreator.CreateFood();
			food.Draw();

			//Пути и настройки
			Params settings = new Params();

			//Audio player
			Sounds sound1 = new Sounds(settings.GetResourceFolder());
			sound1.Play();

			Sounds sound2 = new Sounds(settings.GetResourceFolder());

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
					sound2.Play();
					
				}
				//else if (snake.Eat(f))
				//{
				//	f = foodCreator.CreateFood();
				//	f.Draw();
				//	Program.scorelist.Add(2);
				//}
				//else if (snake.Eat(ff))
				//{
				//	ff = foodCreator.CreateFood();
				//	ff.Draw();
				//	scorelist.Add(-1);
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
			Console.ReadLine();
		}
        static void GameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            WriteText("GAME OVER", xOffset + 1, yOffset++);
			Console.Write("Please, enter your username: ");

		}
		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}

	}
}
