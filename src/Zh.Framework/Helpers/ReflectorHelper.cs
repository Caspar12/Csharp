using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using Zh.Framework.Session;

namespace Zh.Framework.Helpers
{
    public class ReflectorHelper
    {
        public static IList<MethodInfo> GetMethods(Type type, string name)
        {


            var result = new List<MethodInfo>();
            foreach (var item in type.GetMethods())
            {
                if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        /// <summary>
        /// 设置对象实例属性,支持属性路径写法.如：ParentProperty.ChildProperty
        /// </summary>
        /// <param name="obj">对象实例</param>
        /// <param name="propertyPath">属性路径</param>
        /// <param name="value">属性</param>
        /// <param name="index">索引</param>
        public static void SetProperty(object obj, string propertyPath, object value, object[] index = null)
        {
            var propertyPathArr = propertyPath.Split('.');
            var curPropInfoType = obj.GetType();
            PropertyInfo curPropInfo = null;
            object curObj = obj;
            for (var i = 0; i < propertyPathArr.Length; i++)
            {
                var curPropertyPath = propertyPathArr[i];
                curPropInfo = GetPropertyInfo(curPropInfoType, curPropertyPath);
                curPropInfoType = curPropInfo.PropertyType;
                if (i == propertyPathArr.Length - 1)
                {
                    curPropInfo.SetValue(curObj, value, null);
                }
                else
                {
                    var curObjPropValue = curPropInfo.GetValue(curObj, null);
                    if (curObjPropValue == null && curPropInfo.PropertyType.IsClass)
                    {
                        curObjPropValue = Activator.CreateInstance(curPropInfoType);
                        curPropInfo.SetValue(curObj, curObjPropValue, null);
                    }
                    curObj = curObjPropValue;
                }
            }
        }
        /// <summary>
        /// 获取对象实例属性,支持属性路径写法.如：ParentProperty.ChildProperty
        /// </summary>
        /// <param name="obj">对象实例</param>
        /// <param name="propertyPath">属性路径</param>
        /// <param name="bindingFlags">查找标志</param>
        /// <returns>属性</returns>
        public static object GetProperty(object obj, string propertyPath,
            BindingFlags bindingFlags = BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public)
        {
            var propertyPathArr = propertyPath.Split('.');
            var curPropInfoType = obj.GetType();
            PropertyInfo curPropInfo = null;
            object curObj = obj;
            for (var i = 0; i < propertyPathArr.Length; i++)
            {
                var curPropertyPath = propertyPathArr[i];
                curPropInfo = GetPropertyInfo(curPropInfoType, curPropertyPath);
                curPropInfoType = curPropInfo.PropertyType;
                curObj = curPropInfo.GetValue(curObj, null);
            }
            return curObj;
        }
        /// <summary>
        /// 获取反射属性类型
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="propertyPath">属性路径,如:ClassPropertyName.IntPropertyName或PropertyName</param>
        /// <param name="bindingFlags">查找属性类型的属性</param>
        /// <returns>属性类型</returns>
        public static PropertyInfo GetPropertyInfo(Type type, string propertyPath,
            BindingFlags bindingFlags = BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public)
        {
            var propertyPathArr = propertyPath.Split('.');
            var curType = type;
            PropertyInfo curPro = null;
            foreach (var property in propertyPathArr)
            {
                curPro = curType.GetProperty(property, bindingFlags);
                curType = curPro.PropertyType;
            }
            return curPro;
        }
        /// <summary>
        /// 获取反射属性类型
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="propertyPath">属性路径,如:ClassPropertyName.IntPropertyName或PropertyName</param>
        /// <param name="bindingFlags">查找属性类型的属性</param>
        /// <returns>属性类型或者为null</returns>
        public static PropertyInfo GetPropertyInfoOrDefault(Type type, string propertyPath,
               BindingFlags bindingFlags = BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public)
        {
            try
            {
                return GetPropertyInfo(type, propertyPath, bindingFlags);
            }
            catch
            {
                return null;
            }
        }

        public static List<Type> BaseValueTypes = new List<Type>() {
           typeof(int),
           typeof(Int16),
           typeof(Int32),
           typeof(Int64),
           typeof(UInt16),
           typeof(UInt32),
           typeof(UInt64),
           typeof(short),
           typeof(long),
           typeof(decimal),
           typeof(Decimal),
           typeof(double),
           typeof(Double),
           typeof(DateTime),
           typeof(Guid),
           typeof(string),
           typeof(String),
           typeof(bool),
           typeof(Boolean)
        };
        /// <summary>
        /// 是否基本数据值类型,例如:string,int,long,decimal,datetime,guid等
        /// </summary>
        /// <param name="type">类类型</param>
        /// <returns></returns>
        public static bool IsBaseValueType(Type type)
        {
            Type baseType = type;
            if (type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                NullableConverter nullableConverter = new NullableConverter(type);
                baseType = nullableConverter.UnderlyingType;
            }
            var baseValueTypes = BaseValueTypes;
            foreach (var item in baseValueTypes)
            {
                if (item == baseType)
                {
                    return true;
                }
            }
            return false;
        }


        public static T CreateInstance<T>(string type)
        {
            var obj = CreateInstance(type);
            if (obj == null)
            {
                return default(T);
            }
            return (T)obj;
        }

        public static object CreateInstance(string type)
        {
            var type_arr = type.Split(',');
            var assemblyName = type_arr[1];
            var typeName = type_arr[0];
            var obj = Activator.CreateInstance(assemblyName, typeName).Unwrap();
            return obj;
        }
    }
}
