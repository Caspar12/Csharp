/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Reflection;
using Zh.Framework.Helpers;

namespace Zh.Framework.Tools.EntityTool.BindingTool.NVCollectionBinder
{
    public class NVCollectionBinderImp : INVCollectionBinder
    {
        private NameValueCollection _NameValueCollection;

        public NVCollectionBinderImp(System.Collections.Specialized.NameValueCollection pNameValueCollection)
        {
            this._NameValueCollection = pNameValueCollection;
        }

        public T Bind<T>()
        {
            var type = typeof(T);

            return (T)Bind(type);
        }


        public T Bind<T>(T pObj)
        {
            var type = typeof(T);

            return (T)Bind((object)pObj);
        }


        public object Bind(object obj)
        {
            var type = obj.GetType();

            var iProgramTool = ToolFactory.CreateIProgramTool();

            foreach (var propertyPath in this._NameValueCollection.AllKeys)
            {
                if (string.IsNullOrEmpty(propertyPath)) continue;

                var nvValues = this._NameValueCollection.GetValues(propertyPath);

                if (nvValues == null || nvValues.Length == 0) continue;

                var bindingFlags = BindingFlags.IgnoreCase | BindingFlags.Instance |
                    BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty;

                var property = ReflectorHelper.GetPropertyInfoOrDefault(type, propertyPath, bindingFlags);

                if (property == null) continue;

                object realValue = null;
                var propertyType = property.PropertyType;

                try
                {
                    realValue = iProgramTool.ChanageType(nvValues, property.PropertyType);
                }
                catch
                {
                }

                if (realValue != null)
                {
                    ReflectorHelper.SetProperty(obj, propertyPath, realValue, null);
                }
            }
            return obj;
        }


        public object Bind(Type type)
        {
            var obj = Activator.CreateInstance(type);

            return Bind(obj);
        } 
    }
}
