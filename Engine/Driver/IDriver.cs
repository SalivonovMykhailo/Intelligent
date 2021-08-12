using System.Collections.Generic;

namespace Engine.Driver
{
    public interface IDriver
    {
        void Run(List<string> tests);
    }
}
