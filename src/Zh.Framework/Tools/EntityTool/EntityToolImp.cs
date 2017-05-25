/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.EntityTool.BindingTool.NVCollectionBinder;
using System.Reflection;
using Zh.Framework.Helpers;

namespace Zh.Framework.Tools.EntityTool
{
    public class EntityToolImp : IEntityTool
    {
        public INVCollectionBinder CreateINVCollectionBinder(System.Collections.Specialized.NameValueCollection pNameValueCollection)
        {
            return new NVCollectionBinderImp(pNameValueCollection);
        }

        public TDest Map<TSrc, TDest>(TSrc src)
            where TSrc : class
            where TDest : class
        {
            var destObj = Activator.CreateInstance<TDest>();
            return MapTo<TSrc, TDest>(src, destObj);
        }

        public IList<TDest> Map<TSrc, TDest>(IEnumerable<TSrc> src)
            where TSrc : class
            where TDest : class
        {
            return EntityMapper.Map<TSrc, TDest>(src);
        }

        public void SetProperty(object obj, string propertyPath, object value)
        {
            var propertyPathArr = propertyPath.Split('.');
            foreach (var property in propertyPathArr)
            {
                var bindingFlags = BindingFlags.IgnoreCase | BindingFlags.Instance |
                    BindingFlags.Public | BindingFlags.SetProperty;
                obj.GetType().GetProperty(property, bindingFlags);
            }
        }

        public TDest MapTo<TSrc, TDest>(TSrc src, TDest dest)
        {
            if (src == null)
            {
                return dest;
            }
            var srcType = typeof(TSrc);
            var destType = typeof(TDest);
            var destObj = dest;
            var destProperties = destType.GetProperties();
            foreach (var destProperty in destProperties)
            {
                if (!destProperty.CanWrite) continue;

                var srcProperty = srcType.GetProperty(destProperty.Name);

                if (srcProperty == null) continue;

                if (srcProperty.CanRead == false) continue;

                if (srcProperty.PropertyType != destProperty.PropertyType) continue;

                if (ReflectorHelper.IsBaseValueType(srcProperty.PropertyType) == false) continue;

                var srcPropertyValueObj = srcProperty.GetValue(src, null);

                destProperty.SetValue(destObj, srcPropertyValueObj, null);
            }
            return destObj;
        }
    }
}
