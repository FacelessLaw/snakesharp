using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
                p.Draw();
        }

        internal bool IsHit(Figure fig)
        {
            foreach(var p in pList)
                if (fig.IsHit(p))
                    return true;

            return false;
        }

        private bool IsHit(Point pt)
        {
            foreach (var p in pList)
                if (p.IsHit(pt))
                    return true;

            return false;
        }
    }
}
