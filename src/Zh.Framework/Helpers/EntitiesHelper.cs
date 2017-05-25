using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Entities;

namespace Zh.Framework.Helpers
{
    public class EntitiesHelper
    {
        public static GenericExecResult<T> ConvertGenericExecResult<T, T1>(GenericExecResult<T1> r1)
        {
            var r = new GenericExecResult<T>()
            { 
                Code = r1.Code,
                Exception = r1.Exception,
                Message = r1.Message,
                Success = r1.Success
            };
             
            return r;
        }
    }
}
