using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Entities
{
    public class GenericApiResult<T>

    {
        public int code { get; set; }
        public string message { get; set; }
        public T data { get; set; }
        public bool success { get; set; }
    }
}
