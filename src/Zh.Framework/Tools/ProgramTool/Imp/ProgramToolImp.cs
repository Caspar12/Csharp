/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Web;
using System.Collections;
using System.Reflection;

namespace Zh.Framework.Tools.ProgramTool.Imp
{
    public class ProgramToolImp : IProgramTool
    {
        public bool IsStringType(object pObject)
        {
            return pObject.GetType() == typeof(string);
        }

        public bool IsDoubleType(object pObject)
        {
            return pObject.GetType() == typeof(double);
        }

        public bool IsFloatType(object pObject)
        {
            return pObject.GetType() == typeof(float);
        }

        public bool IsDecimalType(object pObject)
        {
            return pObject.GetType() == typeof(decimal);
        }

        public bool IsIntegerType(object pObject)
        {
            return pObject.GetType() == typeof(int);

        }

        public bool IsNumericType(object pObject)
        {
            return
                    IsDecimalType(pObject) ||
                    IsIntegerType(pObject) ||
                    IsDoubleType(pObject) ||
                    IsFloatType(pObject);
        }

        public bool IsDateTimeType(object pObject)
        {
            return pObject.GetType() == typeof(DateTime);
        }


        public object ChanageType(object pValue, Type pConvertsionType)
        {
            var iEnumerableType = typeof(IEnumerable);
            var isMultiValue = 
                (
                    pValue.GetType().IsArray || 
                    iEnumerableType.IsAssignableFrom(pValue.GetType())
                 ) && pValue.GetType() != typeof(string);
            if (iEnumerableType.IsAssignableFrom(pConvertsionType) && pConvertsionType != typeof(string))
            {
                if (pConvertsionType.IsArray)
                {
                    var resultObj = new ArrayList();
                    var underType = pConvertsionType.GetElementType();
                    if (isMultiValue)
                    {
                        var iEnumerableValue = (IEnumerable)pValue;

                        foreach (var itemValue in iEnumerableValue)
                        {
                            object realValue = null;
                            try
                            {
                                realValue = ChanageType(itemValue, underType);
                            }
                            catch { }
                            if (realValue == null) continue;
                            resultObj.Add(realValue);

                        }
                    }
                    else
                    {
                        object realValue = null;
                        try
                        {
                            realValue = ChanageType(pValue, underType);
                        }
                        catch { }
                        if (realValue != null) resultObj.Add(realValue);
                    }
                    return resultObj.ToArray(underType);
                }
                else
                {
                    var resultObj = Activator.CreateInstance(pConvertsionType);
                    var resultType = resultObj.GetType();
                    MethodInfo resultAddMethod;
                    var underType = typeof(object);
                    if (pConvertsionType.IsGenericType)
                    {
                        underType = pConvertsionType.GetGenericArguments()[0];
                    }
                    resultAddMethod = resultType.GetMethod("Add");
                
                    if (isMultiValue)
                    {
                        var iEnumerableValue = (IEnumerable)pValue;
                        var i = 0;
                        foreach (var itemValue in iEnumerableValue)
                        {
                            object realValue = null;
                            try
                            {
                                realValue = ChanageType(itemValue, underType);
                            }
                            catch { }
                            if (realValue == null) continue;
                            resultAddMethod.Invoke(resultObj, new object[] { realValue });
                            i++;
                        }
                    }
                    else
                    {
                        object realValue = null;
                        try
                        {
                            realValue = ChanageType(pValue, underType);
                        }
                        catch { }
                        if (realValue != null) resultAddMethod.Invoke(resultObj, new object[] { realValue });
                    } 
                    return resultObj;
                }
            }
            //判断convertsionType类型是否为泛型，因为nullable是泛型类,
            if (pConvertsionType.IsGenericType &&
                //判断convertsionType是否为nullable泛型类
                pConvertsionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (pValue == null || pValue.ToString().Length == 0)
                {
                    return null;
                }

                //如果convertsionType为nullable类，声明一个NullableConverter类，该类提供从Nullable类到基础基元类型的转换
                NullableConverter nullableConverter = new NullableConverter(pConvertsionType);
                //将convertsionType转换为nullable对的基础基元类型
                pConvertsionType = nullableConverter.UnderlyingType;
            }
            if (pConvertsionType == typeof(Guid) && pValue is string)
            {
                var newValue = new Guid(pValue.ToString());
                return newValue;
            }
            return Convert.ChangeType(pValue, pConvertsionType);
        }

        public object ChanageType(string pValue, Type pConvertsionType)
        {
            return ChanageType((object)pValue, pConvertsionType);
        }
        public object ChanageType(string[] pValue, Type pConvertsionType)
        {
            if (pValue.Length == 1)
            {
                return ChanageType(pValue[0], pConvertsionType);
            }
            else
            {
                return ChanageType((object)pValue, pConvertsionType);
            }
        }

        public string ConvertExceptionToString(Exception pException)
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine("[Message]");
            msg.AppendLine(pException.Message);
            msg.AppendLine();
            msg.AppendLine("[Source]");
            msg.AppendLine(pException.Source);
            msg.AppendLine();
            msg.AppendLine("[StackTrace]");
            msg.AppendLine(pException.StackTrace);
            msg.AppendLine();
            if (pException.InnerException != null)
            {
                msg.AppendLine(ConvertExceptionToString(pException.InnerException));
            }
            return msg.ToString();
        }

        public bool IsWebApplication()
        {
            return HttpContext.Current != null;
        }


        public T ChanageType<T>(object value)
        {
            var o = this.ChanageType(value, value.GetType());
            if (o == null) return default(T);
            return (T)o;
        }
    }
}
