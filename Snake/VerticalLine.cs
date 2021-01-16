using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //Класс-наследник Point. Дополнительно отрисовка вертикальной линии.
    class VerticalLine : Figure
    {
        
        //Тоже самое как и для горизонтальной линии.
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }

        }
        
    }
}
