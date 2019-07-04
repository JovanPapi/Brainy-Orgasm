using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    /// <summary>
    /// The execption that is thrown when the ContentForm needs to be shown
    /// </summary>
    public class ShowContentException : Exception
    {
        public ShowContentException() {}
        public ShowContentException(string message) : base(message) {}
    }
}
