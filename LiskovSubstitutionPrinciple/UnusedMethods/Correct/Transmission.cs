using System;

namespace LiskovSubstitutionPrinciple.UnusedMethods.Correct
{
    public abstract class Transmission
    {
        protected bool IsGearSwitchingEnabled { get; set; }

        /// <summary>
        /// Даю возможность переключить передачу.
        /// </summary>
        public virtual void EnableGearSwitching()
        {
            IsGearSwitchingEnabled = true;
            Console.WriteLine("Переключение передачи возможно.");
        }

        /// <summary>
        /// Переключаю передачу.
        /// </summary>
        public virtual void SwitchGear() => Console.WriteLine("Переключаю передачу.");
    }
}
