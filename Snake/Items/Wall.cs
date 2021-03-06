﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Snake.Items
{
    class Wall
    {
        char sign = '#';
        public List<Point> body = null;
        public Wall()
        {
            body = new List<Point>();
            XmlSerializer xmls = new XmlSerializer(typeof(List<Point>));
            using (FileStream fs = new FileStream(@"Maps\Map1.xml", FileMode.Open))
            {
                body = xmls.Deserialize(fs) as List<Point>;
            }

            Show();
        }
        public void Show() 
        {
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.X,p.Y);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(sign);
            }
        }

    }
}
