using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //Класс-наследник Point. Дополнительно отрисовка горизонтальной линии.
    class HorizontalLine : Figure
    {

        //Метод отрисовки горизонтальной линии. На вход подаются начальное и конечное значение линии, а также символ отрисовки. 
        
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();//Создаёт объект класса List  содержащий объекты класса Point (содержащий точки). 

            //Создаём нужное количество точки в зависимости от входных параметров метода, на каждом шаге добавляя их в List.
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }
        
            
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;


            base.Draw();

            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
