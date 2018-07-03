using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Point
    {
        public int x, y;
        public char sym;

        public Point() { }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction dir)
        {
            if (dir == Direction.Right)
                x += offset;
            else
            if (dir == Direction.Down)
                y += offset;
            else
            if (dir == Direction.Left)
                x -= offset;
            else
                y -= offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool IsHit(Point p)
        {
            return this.x == p.x && this.y == p.y;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
