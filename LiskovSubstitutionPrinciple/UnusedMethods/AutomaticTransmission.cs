using System;

namespace LiskovSubstitutionPrinciple.UnusedMethods
{
    public class AutomaticTransmission : ManualTransmission
    {
        /// <summary>
        /// Выжми сцепление.
        /// </summary>
        public override void PressClutch() { }

        /// <summary>
        /// Переключи передачу.
        /// </summary>
        public override void SwitchGear() 
            => Console.WriteLine("Переключаю передачу в автоматическом режиме.");
    }
}
