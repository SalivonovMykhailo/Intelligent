using Core.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Engine
{
    public class TestCase
    {
        public string Name { get; }
        public string Description { get; }
        public string FullName { get; }

        public List<MethodInfo> Steps { get; }
        public object Instance { get; }

        #region Constructors

        public TestCase(Type type)
        {
            Instance = Activator.CreateInstance(type, new object[] { });
            Steps = new List<MethodInfo>();
            TypeInfo typeInfo = type.GetTypeInfo();
            foreach(MethodInfo methodInfo in typeInfo.GetMethods())
            {
                if (methodInfo.GetCustomAttributes<StepAttribute>(inherit: true).ToList().Count > 0)
                {
                    Steps.Add(methodInfo);
                }
            }
        }

        #endregion
    }
}
