using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1984
{
   public class Ring:  Round
    {
        public Ring(int x, int y, int radius,  int radius2,string color) : base(x, y, radius,color)
        {
            Radius2 = radius2;
            Color = color;
        }
       
        private int _radius2;
        public int Radius2
        {
            get { return _radius2; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _radius2 = value;
            }
        }
        public override string Draw()
        {
            return string.Format("Фигура кольцо\n Начальна точка: (X:{0}, Y:{1})\n Внутренний радиус:{2} \n Внешний радиус:{3}\n Цвет:{4}", X, Y, Radius,Radius2, Color);
        }

    }
}
