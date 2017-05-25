/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.ValidatorTool.Validator.Imp;
using System.Collections.Specialized;
using Zh.Framework.Tools.ValidatorTool.Validator;
using Zh.Framework.Tools.ValidatorTool.Validator.NVCollectionValidator;

using System.Text.RegularExpressions;
using Zh.Framework.Exceptions;

namespace Zh.Framework.Tools.ValidatorTool
{
    public class ValidatorToolImp : IValidatorTool
    {
        /// <summary>
        /// 是否为空或Null
        /// </summary>
        public bool IsEmpty(object pObject)
        {
            return new Empty().Valid(pObject);
        }
        /// <summary>
        /// 是否不为空或Null
        /// </summary>
        public bool IsNotEmpty(object pObject)
        {
            return new NotEmpty().Valid(pObject);
        }
        /// <summary>
        /// 是否为手机号码
        /// </summary>
        public bool IsMobilePhone(object pObject)
        {
            return new Mobile().Valid(pObject);
        }
        /// <summary>
        /// 是否为电子邮件
        /// </summary>
        public bool IsEmail(object pObject)
        {
            return new Email().Valid(pObject);
        }
        /// <summary>
        /// 是否过期
        /// </summary>
        /// <param name="expire">过期时间</param>        
        public bool IsExpire(DateTime? expire)
        {
            return expire.HasValue && expire.Value <= DateTime.Now;
        }
        public IFieldChain CreateNVValidator(NameValueCollection pNameValueCollection)
        {
            return new NVCollectionValidatorImp(pNameValueCollection);
        }

 




        public bool IsPhone(string phone)
        {
            if (string.IsNullOrEmpty(phone)) return false;
            Regex regex = new Regex(@"^(1)\d{10}$");
            return regex.IsMatch(phone);
        }
        /// <summary>
        /// 是否中国手机号码
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <returns></returns>
        public bool IsMobilePhone(string phone)
        {
            if (string.IsNullOrEmpty(phone)) return false;
            Regex regex = new Regex(@"^(1)\d{10}$");
            return regex.IsMatch(phone);
        }

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
        public bool IsLengthRange(string value, int min, int max, bool isThrowException = false, string exceptionName = "", int exceptionHResult = 0, string exceptionMsg = "{0}字符串长度范围是{1}到{2}个字符")
        {
            if (value == null) value = "";
            var length = value.Length;
            var isTrue = (min <= length) && (length <= max);
            if (isThrowException)
            {
                if (isTrue == false) throw new NotInLengthRangeException(string.Format(exceptionMsg, exceptionName, min, max), exceptionHResult);
                return true;
            }
            else
            {
                return isTrue;

            }
        }
    }
}
