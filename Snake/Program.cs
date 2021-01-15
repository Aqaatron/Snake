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
            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';
            Point p1 = new Point(3, 1, '*');
            //p1.x = 1;
            //p1.y = 3;
            //p1.sym = '*';

            Point p2 = new Point(4, 5, '_');


            p1 = p2;

            p2.x++;

            p2.y++;

            Console.WriteLine($"p1= {p1.x}, {p1.y}");

            Console.Read();
        }
        
    }
}
