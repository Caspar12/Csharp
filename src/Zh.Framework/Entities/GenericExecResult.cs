/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Exceptions;

namespace Zh.Framework.Entities
{
    public class GenericExecResult<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public bool Success { get; set; }
        public Exception Exception { get; set; }
        public bool IsSuccess
        {
            get
            {
                return Success;
            }
        }
        public bool IsFailure
        {
            get
            {
                return !Success;
            }
        }
        public void IfFailureThrowException()
        {
            if (this.IsFailure)
            {
                throw new BaseException(this.Message, this.Exception);
            }
        }
    }
}
