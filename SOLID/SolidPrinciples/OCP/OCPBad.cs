using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP
{
    internal class OCPBad
    {
        public class ReportGenerator
        {
            public void GenerateReport(string reportType)
            {
                if (reportType == "PDF")
                {
                    // do somethinmg
                }

                else if (reportType == "Excel")
                {
                    // something else
                }
            }
        }
    }
}
