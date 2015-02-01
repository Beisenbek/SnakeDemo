using Snake.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            MySnake worm = new MySnake();
            Food food = new Food();
            Wall wall = new Wall();

            Console.SetWindowSize(41, 41);

 
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey();
                int dx = 0;
                int dy = 0;
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        dx = 0;
                        dy = -1;
                        break;
                    case ConsoleKey.DownArrow:
                        dx = 0;
                        dy = 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        dx = -1;
                        dy = 0;
                        break;
                    case ConsoleKey.RightArrow:
                        dx = 1;
                        dy = 0;
                        break;
                    case ConsoleKey.Escape:
                        return;

                    default: break;
                }

                MoveResult result = worm.Move(dx, dy, food.location, wall.body);

                switch (result)
                {
                    case MoveResult.OK:
                        break;
                    case MoveResult.FOOD:
                        food = new Food();
                        break;
                    case MoveResult.CRASH:
                        Console.SetCursorPosition(20, 20);
                        Console.WriteLine("Game Over!");
                        break;
                    default: break;
                }
              
                

            }

        }
    }
}
