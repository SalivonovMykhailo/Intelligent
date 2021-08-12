using Core.Attributes;
using System;
using System.Collections.Generic;
namespace TestsExamples
{
    [TestCase]
    public class TestCaseExample
    {
        [ActionStep]
        public void FirstActionStep()
        {
            Console.WriteLine("Executed FirstActionStep");
        }

        [ActionStep]
        public void SecondActionStep()
        {
            Console.WriteLine("Executed SecondActionStep");
        }

        [VerificationStep]
        public void FirstVerificationStep()
        {
            Console.WriteLine("Executed FirstVerificationStep");
        }

        [ActionStep]
        public void ThirdActionStep()
        {
            Console.WriteLine("Executed ThirdActionStep");
        }

        [VerificationStep]
        public void SecondVerificationStep()
        {
            Console.WriteLine("Executed SecondVerificationStep");
        }
    }
}
