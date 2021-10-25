namespace LiskovSubstitutionPrinciple.Ifology.Correct
{
    public abstract class Shape
    {
        public string ShapeName { get; protected set; }

        public abstract void CalculateSquare();
    }
}
