using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1984
{
   public class Round: Circle
    {
        public Round(int x, int y, int radius, string color): base(x, y, radius)
        {
            Color = color;
        }
        public string Color { get; set; }

        public override string Draw()
        {
            return string.Format("Фигура круг\n Начальна точка: (X:{0}, Y:{1})\n Радиус:{2}\n Цвет:{3}", X, Y, Radius,Color);
        }
    }
}
