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

            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Up");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Down");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Left");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Right");
                        break;
                    case ConsoleKey.Escape:
                        return;

                    default: break;
                }

               

            }

        }
    }
}
