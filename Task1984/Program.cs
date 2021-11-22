using System;
using System.Collections.Generic;

namespace Task1984
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(0,0,4,4);
      

            Circle circle = new Circle(2, 2, 6);
           

            Round round = new Round(2, 2, 6, "Красный");
        

            Ring ring = new Ring(2, 2, 2, 5, "Жёлтый");
         

            Rectangle rectangle = new(1,1, 8,1, 1,5, 8,5);
           


            List<Figure> figures = new();

            figures.Add(line);
            figures.Add(circle);
            figures.Add(round);
            figures.Add(ring);
            figures.Add(rectangle);

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.Draw()); 

            }
        }
    }
}
