using System;

namespace Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TestCaseAttribute : Attribute
    {
        public string Author { get; set; }
        public string Description { get; set; }
        public string Reason { get; set; }
    }
}
