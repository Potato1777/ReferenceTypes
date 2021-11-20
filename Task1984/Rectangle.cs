    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1984
{
  public  class Rectangle: Line
    {
        public Rectangle(int x, int y, int endX, int endY, int x1, int y1, int endX1, int endY1) : base(x, y, endX, endY)
        {
            if (X1 != X && Y1 == Y)
            {
                throw new ArgumentOutOfRangeException();
               
            }
            else
            {
                X1 = x1;
                Y1 = y1;
            }

            if (endX1==endX && endY1==Y1)
            {
                EndX1 = endX1;
                EndY1 = endY1;
                

            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public int EndX1 { get; set; }
        public int EndY1 { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public override string Draw()
        {
            return string.Format("Фигура Прямоугольник\n Первая точка: (X:{0}, Y:{1})\n Вторая точка: (X:{2}, Y{3})\n " +
                "Третья точка: (X:{4}, Y:{5})\n Четвёртая точка: (X:{6}, Y{7})", X, Y, EndX, EndY, X1, Y1, EndX1, EndY1);
        }
    }
}
