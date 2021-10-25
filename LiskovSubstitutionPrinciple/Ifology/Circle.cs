namespace LiskovSubstitutionPrinciple.Ifology
{
    public class Circle : Shape
    {
        public Circle()
        {
            ShapeName = "Окружность";
        }

        public double R { get; set; }
    }
}
