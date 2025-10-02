using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Interface Segregation Principle
// - segregate functionalitites intor separate interfaces
// - ensure clients that only need printing don't depend on scanning or faxing methods
namespace SolidPrinciples.ISP
{
    internal class ISPExample
    {
        public interface IPrinter
        {
            void Print(string d);
        }

        public interface IScanner
        {
            void Scan(string d);
        }

        public interface IFax
        {
            void Fax(string d);
        }

        public class MultiFunctionPrinter : IPrinter, IScanner, IFax
        {
            public void Fax(string d)
            {
                throw new NotImplementedException();
            }

            public void Print(string d)
            {
                throw new NotImplementedException();
            }

            public void Scan(string d)
            {
                throw new NotImplementedException();
            }
        }
    }
}
