using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.ProgramTool
{
    public interface IProgramTool
    {
        bool IsStringType(object pObject);

        bool IsDoubleType(object pObject);

        bool IsFloatType(object pObject);

        bool IsDecimalType(object pObject);

        bool IsIntegerType(object pObject);

        bool IsNumericType(object pObject);

        bool IsDateTimeType(object pObject);

        object ChanageType(object pValue, Type pConvertsionType);
        object ChanageType(string pValue, Type pConvertsionType);
        object ChanageType(string[] pValue, Type pConvertsionType);

        T ChanageType<T>(object value);

        string ConvertExceptionToString(Exception pException);

        /// <summary>
        /// 是否Web应用程序
        /// </summary>
        bool IsWebApplication();
    }
}
