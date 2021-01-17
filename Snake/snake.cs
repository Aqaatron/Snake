using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        //Класс-наследник Point. Определяет поведения Snake.

        Direction direction;//Доп. информация направление движения.

        //Метод Snake для формирования змейки. На вход получает объект класса точка с параметрами начальной точки (змейка строится от хвоста к голове).
        //Также длину и направление, в котором она будет формироваться.

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction; //получаем текущее направление

            pList = new List<Point>(); //создаём пустой лист - объект класса List содержащий объекты класса Point.

            //Далее каждый раз формируя начальную точку с помощью метода класса Point Move() распространяем нашу змейку.

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);

            }
        }

        //Метод реализации движения нашей змейки.
        internal void Move(int width, int height)
        {
            Point tail = pList.First();//вытаскиваем последний элемент из List (последний элемент змейки)

            pList.Remove(tail);//удаляем его

            Point head = GetNextPoint();//создаём новую точку для реализации движения змейки, путём перемешения первой точки

            ChangeDir(head, width, height);

            pList.Add(head);//добавляем её в наш лист в самое начало

            tail.Clear();//стираем хвост из консоли

            head.Draw();//выводим новую точку змейки на консоль

        }
        //Метод получения следующий точки нашей змейки для реализации её движения.
        public Point GetNextPoint()
        {
            Point head = pList.Last(); //Создаём переменную типа Point -  head, в которую копируем последнюю точку в списке (голову змейки).

            Point nextpoint = new Point(head);//Создаём точку 

            nextpoint.Move(1, direction);//сдвигаем координату точки на 1 единицу в выбранном направлении

            return nextpoint;

        }
        public void ChangeDir(Point nextpoint, int width, int height)
        {
            if (nextpoint.y == 1)
            {
                direction = Direction.DOWN;
            }
            if (nextpoint.y == height - 1)
            {
                direction = Direction.UP;
            }
            if (nextpoint.x == 2)
            {
                direction = Direction.RIGHT;
            }
            if (nextpoint.x == width - 1)
            {
                direction = Direction.LEFT;
            }
        }
           
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();

            if (head.IsHit(food))
            {
                food.sym = head.sym;

                pList.Add(food);

                return true;
            }
            else
            {
                return false;
            }

        }

        public void HandleKey(ConsoleKey key)//Обработка нажатия клавиши
        {
           //Проверяем какая клавиша нажата и меняем направление движения в соответствии с этой клавишей
                if (key == ConsoleKey.LeftArrow)

                    direction = Direction.LEFT;

                else if (key == ConsoleKey.RightArrow)

                    direction = Direction.RIGHT;

                else if (key == ConsoleKey.UpArrow)

                    direction = Direction.UP;

                else if (key == ConsoleKey.DownArrow)

                    direction = Direction.DOWN;
            
        }
    }
}
