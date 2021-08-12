using Engine;
using Engine.Driver;
using Engine.Extractor;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using TestsExamples;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDriver driver = new Driver();
            //driver.Run(new List<string>());

            Extractor ex = new Extractor(typeof(TestCaseExample).Assembly);

            foreach (TestCase test in ex.TestCaseClasess)
            {
                foreach(MethodInfo step in test.Steps)
                {
                    step.Invoke(test.Instance,  null);
                }
            }
        }
    }
}
