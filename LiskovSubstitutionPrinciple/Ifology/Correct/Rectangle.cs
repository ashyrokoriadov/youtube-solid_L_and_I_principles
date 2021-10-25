using System;

namespace LiskovSubstitutionPrinciple.Ifology.Correct
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            ShapeName = "Прямоугольник";
        }

        public double A { get; set; }
        public double B { get; set; }

        public override void CalculateSquare()
        {
            double square = A * B;
            
            Console.WriteLine($"Площадь фигуры {ShapeName} равна {square}.");
        }
    }
}
