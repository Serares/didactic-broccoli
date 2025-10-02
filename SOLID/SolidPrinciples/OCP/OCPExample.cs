using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Open Closed Principle
namespace SolidPrinciples.OCP
{
    internal class OCPExample
    {
        public abstract class ReportGenerator
        {
            public abstract void GenerateReport();
        }

        public class PDFReportGenerator : ReportGenerator
        {
            public override void GenerateReport()
            {
                //throw new NotImplementedException();
            }
        }

        public class ExcelReportGenerator : ReportGenerator
        {
            public override void GenerateReport()
            {
                throw new NotImplementedException();
            }
        }
    }
}
