using System;

namespace LiskovSubstitutionPrinciple.UnusedMethods
{
    public class ManualTransmission
    {
        /// <summary>
        /// Выжми сцепление.
        /// </summary>
        public virtual void PressClutch() => Console.WriteLine("Выжимаю сцепление.");

        /// <summary>
        /// Переключи передачу.
        /// </summary>
        public virtual void SwitchGear() => Console.WriteLine("Переключаю передачу.");
    }
}
