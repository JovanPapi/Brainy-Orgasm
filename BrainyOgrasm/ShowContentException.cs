using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    public class ShowContentException : Exception
    {
        public ShowContentException() {}
        public ShowContentException(string message) : base(message) { }
    }
}
