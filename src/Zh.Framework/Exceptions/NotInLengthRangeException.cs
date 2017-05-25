using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Exceptions
{
    public class NotInLengthRangeException : BaseException
    {
        public NotInLengthRangeException() { }

        public NotInLengthRangeException(string message) : base(message) { }
        public NotInLengthRangeException(string message, int hResult) : base(message, hResult) { }
        public NotInLengthRangeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
