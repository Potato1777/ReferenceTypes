using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1984
{
   public class Circle: Figure
    {
        private int _radius;
        public Circle( int x, int y, int radius): base(x,y)
        {
            Radius = radius;
        }
        
        public int Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _radius = value;
            } 
        }
            public override string Draw()
        {
            return string.Format("Фигура Окружность\n Начальна точка: (X:{0}, Y:{1})\n Радиус:{2}", X, Y, Radius);
        }
    }
    }

