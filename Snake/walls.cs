using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight, char sym)
        {
            wallList = new List<Figure>();

            //Отрисовка рамки
            HorizontalLine topLine = new HorizontalLine(1, mapWidth, 1, sym);

            HorizontalLine botLine = new HorizontalLine(1, mapWidth, mapHeight, sym);

            VerticalLine leftLine = new VerticalLine(1, mapHeight, 1, sym);

            VerticalLine rightLine = new VerticalLine(1, mapHeight, mapWidth, sym);

            wallList.Add(topLine);
            wallList.Add(botLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

            

        }
        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
