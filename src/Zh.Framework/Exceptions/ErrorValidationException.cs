using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Exceptions
{
    public class ErrorValidationException : BaseException
    {
        public ErrorValidationException() { }

        public ErrorValidationException(string message) : base(message) { }
        public ErrorValidationException(string message, Exception innerException) : base(message, innerException) { }

        public ErrorValidationException(string message, int hResult) : base(message)
        {
            this.HResult = hResult;
        }
    }
}
