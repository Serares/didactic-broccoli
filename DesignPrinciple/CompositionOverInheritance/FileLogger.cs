using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionOverInheritance
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}
