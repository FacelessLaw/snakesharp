using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Snake : Figure
    {
        public Direction dir;

        public Snake(Point tail, int length, Direction _dir)
        {
            dir = _dir;
            pList = new List<Point>();

            for (int i = 0; i < length; ++i)
            {
                Point p = new Point(tail);
                p.Move(i, dir);

                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextP();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextP()
        {
            Point head = pList.Last();
            Point nextP = new Point(head);
            nextP.Move(1, dir);

            return nextP;
        }

        public void GKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                dir = Direction.Left;
            else
                    if (key == ConsoleKey.RightArrow)
                dir = Direction.Right;
            else
                    if (key == ConsoleKey.DownArrow)
                dir = Direction.Down;
            else
                dir = Direction.Up;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextP();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();

            for (int i = 0; i < pList.Count - 2; ++i)
                if (head.IsHit(pList[i]))
                    return true;

            return false;
        }
    }
}
