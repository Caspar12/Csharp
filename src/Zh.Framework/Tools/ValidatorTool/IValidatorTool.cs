using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.ValidatorTool.Validator.NVCollectionValidator;
using System.Collections.Specialized;
namespace Zh.Framework.Tools.ValidatorTool
{
    public interface IValidatorTool
    {
        bool IsEmpty(object pObject);
        bool IsNotEmpty(object pObject);
        bool IsExpire(DateTime? expire);

        bool IsPhone(string phone);
        bool IsMobilePhone(string phone);
        /// <summary>
        /// 字符串长度范围
        /// </summary>
        /// <param name="value">字符串</param>
        /// <param name="min">大于等于最小长度</param>
        /// <param name="max">小于等于最大长度</param>
        /// <param name="isThrowException">是否抛出错误信息</param>
        /// <param name="exceptionName">错误对象名称</param>
        /// 
        /// /// <param name="exceptionHResult">抛出的错误信息代码</param>
        /// <param name="exceptionMsg">抛出的错误信息</param>
        /// <returns>true / false</returns>
        bool IsLengthRange(string value, int min, int max, bool isThrowException = false, string exceptionName = "", int exceptionHResult = 0, string exceptionMsg = "{0}字符串长度范围是{1}到{2}个字符");
        IFieldChain CreateNVValidator(NameValueCollection pNameValueCollection);
    }
}
