namespace LiskovSubstitutionPrinciple.Ifology
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            ShapeName = "Прямоугольник";
        }

        public double A { get; set; }
        public double B { get; set; }
    }
}
