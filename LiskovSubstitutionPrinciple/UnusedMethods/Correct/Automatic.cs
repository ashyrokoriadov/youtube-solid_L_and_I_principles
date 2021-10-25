using System;

namespace LiskovSubstitutionPrinciple.UnusedMethods.Correct
{
    public class Automatic : Transmission
    {
        /// <summary>
        /// Переключаю передачу.
        /// </summary>
        public override void SwitchGear() 
            => Console.WriteLine("Переключаю передачу в автоматическом режиме.");
    }
}
