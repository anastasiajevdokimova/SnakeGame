using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame
{
	class Program
	{
		
		static void Main(string[] args)
		{
			Console.SetWindowSize(80, 25);

			Walls walls = new Walls(80, 25);
			walls.Draw();

			// Отрисовка точек			
			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '#', '$', '^');
			Point food = foodCreator.CreateFood();
			Point spsfood = foodCreator.CreateSpsFood();
			Point badfood = foodCreator.CreateBadFood();
			food.Draw();

			//Пути и настройки
			Params settings = new Params();

			//Music
			Sounds sound1 = new Sounds(settings.GetResourceFolder());
			Sounds sound2 = new Sounds(settings.GetResourceFolder());
			Sounds sound = new Sounds(settings.GetResourceFolder());
			sound.Play();

			Counter count = new Counter(0);
			count.ScoreWrite();
			

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				if (snake.Eat(food))
				{
					sound1.PlayEat();
					food = foodCreator.CreateFood();
					food.Draw();
					count.ScoreUp();
					count.ScoreWrite();
					if (count.GetScore()%10==0)
                    {
						spsfood = foodCreator.CreateSpsFood();
						spsfood.Draw();
						badfood = foodCreator.CreateBadFood();
						badfood.Draw();
                    }
    
				}
				if (snake.Eat(spsfood))
                {
					count.ScoreUp();
					count.ScoreWrite();
					sound1.PlayEat();
				}
				if (snake.Eat(badfood))
				{
					count.ScoreDown();
					count.ScoreWrite();
					sound1.PlayEat();
				}
				else
				{
					snake.Move();
				}
				new Speed(count.GetScore());

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			GameOver();
			sound2.PlayEnd();
			score.WriteBestResult();
			Console.ReadLine();
		}
        static void GameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            WriteText("-------GAME OVER-------", xOffset + 1, yOffset++);

		}
		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}

	}
}
