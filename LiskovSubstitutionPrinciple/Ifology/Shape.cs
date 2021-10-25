using System;

namespace LiskovSubstitutionPrinciple.Ifology
{
    public class Shape
    {
        public string ShapeName { get; protected set; }        
        
        public void CalculateSquare()
        {
            double square = 0.0;

            if(this is Rectangle rectangle)
            {
                square = rectangle.A * rectangle.B;
            }

            if (this is Circle circle)
            {
                square = Math.PI * Math.Pow(circle.R, 2);
            }

            Console.WriteLine($"Площадь фигуры {ShapeName} равна {square}.");
        }
    }
}
