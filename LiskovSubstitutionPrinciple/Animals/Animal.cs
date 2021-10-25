using System;

namespace LiskovSubstitutionPrinciple.Animals
{
    public class Animal
    {
        public virtual void Say() => Console.WriteLine("Ничего.");
    }
}
