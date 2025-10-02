using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionOverInheritance.BadExample
{
    /**
     * Here the design is less flexible
     * changing the logging mechanism would affect all subclasses
    */
    public abstract class BaseService
    {
        protected void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class OrderService : BaseService
    {
        public void ProcessOrder()
        {
            Log("processing order");
        }
    }
}
