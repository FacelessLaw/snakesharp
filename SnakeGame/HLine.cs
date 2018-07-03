using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class HLine : Figure
    {
        public HLine(int xl, int xr, int y, char sym)
        {
            pList = new List<Point>();

            for (int x = xl; x <= xr; ++x)
                pList.Add(new Point(x, y, sym));
        }
    }
}
