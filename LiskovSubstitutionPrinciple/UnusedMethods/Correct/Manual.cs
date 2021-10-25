using System;

namespace LiskovSubstitutionPrinciple.UnusedMethods.Correct
{
    public class Manual : Transmission
    {
        /// <summary>
        /// Даю возможность переключить передачу.
        /// </summary>
        public override void EnableGearSwitching()
        {
            PressClutch();
            base.EnableGearSwitching();
        }

        /// <summary>
        /// Переключаю передачу.
        /// </summary>
        public override void SwitchGear() => Console.WriteLine("Переключаю передачу в ручном режиме.");

        private void PressClutch() => Console.WriteLine("Выжимаю сцепление.");
    }
}
