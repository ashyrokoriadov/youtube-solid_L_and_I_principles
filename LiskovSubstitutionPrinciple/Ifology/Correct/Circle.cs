using System;

namespace LiskovSubstitutionPrinciple.Ifology.Correct
{
    public class Circle : Shape
    {
        public Circle()
        {
            ShapeName = "Окружность";
        }

        public double R { get; set; }

        public override void CalculateSquare()
        {
            double  square = Math.PI * Math.Pow(R, 2);            

            Console.WriteLine($"Площадь фигуры {ShapeName} равна {square}.");
        }
    }
}
