using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //Основной класс программы
    class Point
    {
        //Параметры точки
        public int x;
        public int y;
        public char sym;

        //Конструктор 1. На вход параметры точки
        public Point (int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        //Конструктор 2. На вход точка, получаем параметры из неё
        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        //Метод сдвига по выбранному направлению. На вход величина сдвига offset и направление direction перечисление enum Direction.
        public void Move (int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x += offset;
            }
            if (direction == Direction.LEFT)
            {
                x -= offset;
            }
            if (direction == Direction.UP)
            {
                y -= offset;
            }
            if (direction == Direction.DOWN)
            {
                y += offset;
            }

        }
        //Метод отрисовки точки в консоли
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        //Метод получения информации о точке
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
        //Метод удаления точки из консоли
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
        internal bool IsHit (Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
