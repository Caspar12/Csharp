using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Exceptions
{
    public class BaseException : Exception
    {
        public BaseException() { }

        public BaseException(string message) : base(message) { }
        public BaseException(string message, Exception innerException) : base(message, innerException) { }

        public BaseException(string message, int hResult) : base(message)
        {
            this.HResult = hResult;
        }
    }
}
