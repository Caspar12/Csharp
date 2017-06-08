﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Exceptions
{
    public class ValidationException : BaseException
    {        

        public ValidationException() { }

        public ValidationException(string message) : base(message) { }
        public ValidationException(string message, Exception innerException) : base(message, innerException) { }

        public ValidationException(string message, int code) : base(message)
        {
            this.Code = code;
        }
    }
}
