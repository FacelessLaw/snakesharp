using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void WriteGameOver()
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition( xOffset, yOffset++ );
			WriteText( "============================", xOffset, yOffset++ );
			WriteText( "И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++ );
			yOffset++;
			WriteText( "Автор: Андрей Волков", xOffset + 4, yOffset++ );
			WriteText( "Специально для GitHub", xOffset + 4, yOffset++ );
			WriteText( "============================", xOffset, yOffset++ );
		}

		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition( xOffset, yOffset );
			Console.WriteLine( text );
		}
        static void Main(string[] args)
        {
            //Рамка
            Console.SetBufferSize(80, 25);

            Wall wall = new Wall(80, 25);
            wall.Draw();

            //Точки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);

            snake.Draw();

            FoodCreator fCreator = new FoodCreator(25, 80, '&');
            Point food = fCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (wall.IsHit(snake) || snake.IsHitTail())
                {


                    break;
                }

                if (snake.Eat(food))
                {
                    food = fCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                { 
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.GKey(key.Key);
                }
            }

            WriteGameOver();
            Console.ReadLine();
        }
    }
}
