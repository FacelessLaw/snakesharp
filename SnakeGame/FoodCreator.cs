using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class FoodCreator
    {
        int MapHeight;
        int MapWidth;
        char sym;

        Random rand = new Random();

        public FoodCreator(int MapHeight, int MapWidth, char sym)
        {
            this.MapHeight = MapHeight;
            this.MapWidth = MapWidth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = rand.Next(2, MapWidth - 2);
            int y = rand.Next(2, MapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
