using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionOverInheritance
{
    internal class OrderService
    {
        // using composition here
        // it's easy to switch loggers
        private readonly ILogger? _logger;

        public OrderService(ILogger? logger)
        {
            _logger = logger;
        }

        public void ProcessOrder()
        {
            _logger?.Log("Processing order");
        }
    }
}
