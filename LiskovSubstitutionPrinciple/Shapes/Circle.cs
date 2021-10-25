namespace LiskovSubstitutionPrinciple.Shapes
{
    public class Circle : Ellipse
    {
        public override double HalfAxeA
        {
            set
            {
                base.HalfAxeA = value;
                base.HalfAxeB = value;
            }
        }

        public override double HalfAxeB
        {
            set
            {
                base.HalfAxeA = value;
                base.HalfAxeB = value;
            }
        }
    }
}
