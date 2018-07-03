using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Wall
    {
        List<Figure> WList;

        public Wall(int MapWidth, int MapHeight)
        {
            WList = new List<Figure>();

            HLine h1 = new HLine(0, MapWidth - 2, 0, '+');
            HLine h2 = new HLine(0, MapWidth - 2, MapHeight - 1, '+');
            VLine v1 = new VLine(0, MapHeight - 1, 0, '+');
            VLine v2 = new VLine(0, MapHeight - 1, MapWidth - 2, '+');

            WList.Add(h1);
            WList.Add(h2);
            WList.Add(v1);
            WList.Add(v2);

        }

        internal bool IsHit(Figure fig)
        {
            foreach (var wall in WList)
            {
                if (wall.IsHit(fig))
                    return true;
            }

            return false;
        }

        public void Draw()
        {
            foreach (var wall in WList)
                wall.Draw();
        }
    }
}
