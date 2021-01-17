using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        const int WIDTH = 80;
        const int HEIGHT = 25;
        const char SYM = '+';
        const char SYM_EAT = '#';
        static void Main(string[] args)
        {
            Console.SetWindowSize (WIDTH + 2, HEIGHT + 2);

            Console.SetBufferSize(WIDTH + 2, HEIGHT + 2);

            HorizontalLine topLine = new HorizontalLine(1, WIDTH, 1, SYM);

            HorizontalLine botLine = new HorizontalLine(1, WIDTH, HEIGHT + 1, SYM);

            VerticalLine leftLine = new VerticalLine(1, HEIGHT + 1, 1, SYM);

            VerticalLine rightLine = new VerticalLine(1, HEIGHT + 1, WIDTH + 1, SYM);

            topLine.Draw();

            botLine.Draw();

            leftLine.Draw();

            rightLine.Draw();

            Point start_pos = new Point(4 , 5, '*');

            Snake snake = new Snake(start_pos, 3, Direction.RIGHT);

            snake.Draw();

            foodCreator foodcreator = new foodCreator(WIDTH, HEIGHT, SYM_EAT);

            Point food = foodcreator.CreatedFood();
            food.Draw();

            while (true)
            {
               if (snake.Eat(food))
                {
                    food = foodcreator.CreatedFood();
                    food.Draw();
                }
                else
                {
                    snake.Move(WIDTH, HEIGHT);
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    snake.HandleKey(key.Key);

                }
                
            }
        }
        
    }
}
