using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class foodCreator
    {
        //rласс, реализующий появления еды на поле для змейки
        int mapWidth;
        int mapHeight;
        char eat_sym;
        Random random = new Random();
        public foodCreator (int mapWidth, int mapHeight, char eat_sym)
        {
            this.mapWidth = mapWidth;//через ключевое слово this помечаются поля класса. Соответственно, в этой строчки 
            //кода полю mapWidth класса foodCreator присвается значения переменной, которая передаётся в аргументе конструктора
            this.mapHeight = mapHeight;
            this.eat_sym = eat_sym;
        }
        public Point CreatedFood()//Метод, реализующий создание случайной точки еды на поле игры. Возращает точку.
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, eat_sym);
        }
    }
}
