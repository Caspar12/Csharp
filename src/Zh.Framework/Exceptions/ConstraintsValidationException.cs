using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Exceptions
{
    /// <summary>
    /// 约束验证异常
    /// </summary> 

    public class ConstraintsValidationException : ValidationException
    {
        /// <summary>
        /// 全部异常约束信息,key是验证的字段路径,value是key对应的全部错误
        /// </summary>
        public Dictionary<string, List<string>> Errors { get; set; }
        /// <summary>
        /// 默认错误字段
        /// </summary>
        public string Field { get; set; }
        /// <summary>
        /// 默认错误字段,错误信息
        /// </summary>
        public new string Message { get; set; }

        public ConstraintsValidationException() { }

        public ConstraintsValidationException(string field, string message) : base(message)
        {
            this.Field = field;
            this.Message = message;
        }
    }
}
