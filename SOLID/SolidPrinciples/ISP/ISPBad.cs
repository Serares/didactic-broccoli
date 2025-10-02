using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ❗ less flexible system design
// this interface forces clients to implement all methods
// even if one client needs just the Print method
namespace SolidPrinciples.ISP
{
    internal class ISPBad
    {
        public interface IMultiFunctionDevice
        {
            void Print(string message);
            void Scan(string message);
            void Fax(string message);
        }

        public class MultiFunctionPrinter : IMultiFunctionDevice
        {
            public void Fax(string message)
            {
                throw new NotImplementedException();
            }

            public void Print(string message)
            {
                throw new NotImplementedException();
            }

            public void Scan(string message)
            {
                throw new NotImplementedException();
            }
        }
    }
}
