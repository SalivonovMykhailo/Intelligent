using System;

namespace Core.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class OneTimeTearDownAttribute : Attribute
    {
    }
}
