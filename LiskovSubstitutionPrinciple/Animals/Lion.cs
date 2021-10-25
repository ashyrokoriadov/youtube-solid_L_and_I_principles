using System;

namespace LiskovSubstitutionPrinciple.Animals
{
    public class Lion : Animal
    {
        public override void Say() => Console.WriteLine("Рррррррр!");
    }
}
