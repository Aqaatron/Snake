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

            Console.CursorVisible = false;

          

            Walls frame = new Walls(WIDTH, HEIGHT, SYM);

            frame.Draw();

            Point start_pos = new Point(4 , 5, '*');

            Snake snake = new Snake(start_pos, 3, Direction.RIGHT);

            snake.Draw();

            foodCreator foodcreator = new foodCreator(WIDTH, HEIGHT, SYM_EAT);

            Point food = foodcreator.CreatedFood();
            food.Draw();

            while (true)
            {
               if (snake.IsHitTail() || frame.IsHit(snake))
                {
                    break;
                    
                }
               if (snake.Eat(food))
                {
                    food = foodcreator.CreatedFood();
                    food.Draw();
                }
                else
                {
                    snake.Move(WIDTH, HEIGHT);
                }
                Thread.Sleep(120);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    snake.HandleKey(key.Key);

                }
                
            }
            WriteGameOver();
            Console.ReadLine();

        }
        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("========================================", xOffset, yOffset++);
            WriteText("П И С Ь,  Т Ы  Л У З Н У Л А", xOffset + 1, yOffset++);
            yOffset++;
            WriteText("Автор: Cидоров Андрей", xOffset + 1, yOffset++);
            WriteText("GeekBrains", xOffset + 1, yOffset++);
            WriteText("P. S.  Л Ю Б И М К А", xOffset + 1, yOffset++);
            WriteText("========================================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

    }
}
