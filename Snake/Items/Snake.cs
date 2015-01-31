using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Items
{
    public class MySnake
    {
        char sign = '*';
        List<Point> body = null;
        public MySnake()
        {
            body  = new List<Point>();
            body.Add(new Point { X = 10, Y = 10 });
            Show();
        }
        public void Show() 
        {
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.X,p.Y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(sign);
            }
        }

        public bool Move(int dx, int dy, Point foodLocation)
        {
            Clear();

            if (foodLocation.X == body[0].X + dx && foodLocation.Y == body[0].Y + dy)
            {
                body.Insert(0, foodLocation);
                Show();
                return true;
            }


            for (int i = body.Count-1; i > 0; i--)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }


            body[0].X = body[0].X + dx;
            body[0].Y = body[0].Y + dy;
            Show();

            return false;

        }
        public void Clear()
        {
            foreach (Point p in body)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(' ');
            }
        }
    }
}
