using LiskovSubstitutionPrinciple.Animals;
using LiskovSubstitutionPrinciple.Ifology;
using LiskovSubstitutionPrinciple.Shapes;
using LiskovSubstitutionPrinciple.UnusedMethods;
using LiskovSubstitutionPrinciple.UnusedMethods.Correct;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunExampleOne();
            //RunExampleTwo();
            //RunExampleThree();
            RunExampleFour();

            Console.ReadKey();
        }

        static void RunExampleOne()
        {
            Animal animal = new Lion();
            Console.WriteLine(animal.GetType());
            animal.Say();
        }

        static void RunExampleTwo()
        {
            Ellipse ellipse = new Ellipse()
            {
                HalfAxeA = 2,
                HalfAxeB = 3
            };

            Ellipse circle = new LiskovSubstitutionPrinciple.Shapes.Circle()
            {
                HalfAxeA = 2,
                HalfAxeB = 2
            };

            var ellipses = new[] { ellipse, circle };

            foreach(var item in ellipses)
            {
                if (item.HalfAxeA == item.HalfAxeB)
                    throw new Exception("Это не настоящий эллипс!");
            }
        }

        static void RunExampleThree()
        {
            ManualTransmission mt = new ManualTransmission();
            AutomaticTransmission at = new AutomaticTransmission();
            var transmissions = new[] { mt, at };

            foreach (var item in transmissions)
            {
                item.PressClutch();
                item.SwitchGear();
                Console.WriteLine("**************");
            }

            Transmission mt2 = new Manual();
            Transmission at2 = new Automatic();
            var transmissions2 = new[] { mt2, at2 };

            foreach (var item in transmissions2)
            {
                item.EnableGearSwitching();
                item.SwitchGear();
                Console.WriteLine("**************");
            }
        }

        static void RunExampleFour()
        {
            Shape circle1 = new LiskovSubstitutionPrinciple.Ifology.Circle()
            {
                R = 10
            };
            Shape rectangle1 = new Rectangle()
            {
                A = 20,
                B = 30
            };
            var shapes1 = new[] { circle1, rectangle1 };

            foreach (var item in shapes1)
            {
                item.CalculateSquare();
            }

            LiskovSubstitutionPrinciple.Ifology.Correct.Shape circle2
                = new LiskovSubstitutionPrinciple.Ifology.Correct.Circle()
                {
                    R = 10
                };
            LiskovSubstitutionPrinciple.Ifology.Correct.Shape rectangle2
                = new LiskovSubstitutionPrinciple.Ifology.Correct.Rectangle()
                {
                    A = 20,
                    B = 30
                };
            var shapes2 = new[] { circle2, rectangle2 };

            foreach (var item in shapes2)
            {
                item.CalculateSquare();
            }
        }
    }
}
