using System;

namespace Task1984
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(0,0,4,4);
            Console.WriteLine(line.Draw());

            Circle circle = new Circle(2, 2, 6);
            Console.WriteLine(circle.Draw());

            Round round = new Round(2, 2, 6, "Красный");
            Console.WriteLine(round.Draw());

            Ring ring = new Ring(2, 2, 2, 5, "Жёлтый");
            Console.WriteLine(ring.Draw());
            Rectangle rectangle = new Rectangle(1,1, 8,1, 1,5, 8,5);
            Console.WriteLine(rectangle.Draw());

        }
    }
}
