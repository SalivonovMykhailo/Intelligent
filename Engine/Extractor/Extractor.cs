using Core.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Engine.Extractor
{
    public class Extractor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dllPath"></param>
        public Extractor(Assembly assembly)
        {
            TestCaseClasess = new List<TestCase>();
            foreach (Type type in assembly.GetTypes())
            {
                if (type.GetCustomAttributes(typeof(TestCaseAttribute), true).Length > 0)
                {
                    TestCaseClasess.Add(new TestCase(type));
                }
            }
        }

        public List<TestCase> TestCaseClasess { get; }
    }
}
