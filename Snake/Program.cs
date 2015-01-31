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

            Console.SetWindowSize(41, 41);

 
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (worm.Move(0, -1, food.location))
                        {
                            food = new Food();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if(worm.Move(0, 1, food.location))
                        {
                            food = new Food();
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if(worm.Move(-1, 0, food.location))
                        {
                            food = new Food();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if(worm.Move(1, 0, food.location))
                        {
                            food = new Food();
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;

                    default: break;
                }

               

            }

        }
    }
}
