using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMs.Common.Exceptions
{
    public class IncidentNotFoundException : Exception
    {
        public IncidentNotFoundException() { }

        public IncidentNotFoundException(string message)
            : base(message) { }

        public IncidentNotFoundException(string message, Exception inner)
            : base(message, inner) { }
    }
}