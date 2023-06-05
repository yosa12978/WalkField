using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkField.Core.Exceptions
{
    public class IteractionException : Exception
    {
        public IteractionException(string message) : base(message) 
        {
        
        }
    }
}
