using System;

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
