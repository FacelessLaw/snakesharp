using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class VLine : Figure
    {
        public VLine(int yh, int yl, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yh; y <= yl; ++y)
                pList.Add(new Point(x, y, sym));
        }
    }
}
