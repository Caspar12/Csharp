﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Zh.EntityFrameworkEx.Utils
{
    public static class EntityFrameworkHelper
    {
        /// <summary>
        /// 获取主键的实体对象属性名称
        /// </summary>
        /// <returns></returns>
        public static List<string> GetPrimaryKeyPropertyNames<TEntity>()
        {
            List<string> result = new List<string>();
            GetPrimaryKeyPropertyInfos<TEntity>()
                .Where(p => Attribute.IsDefined(p, typeof(KeyAttribute))).ToList().ForEach(p =>
            {
                string name = p.Name;

                result.Add(name);
            });
            return result;
        }
        /// <summary>
        /// 获取主键类型属性
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public static List<PropertyInfo> GetPrimaryKeyPropertyInfos<TEntity>()
        {
            Type type = typeof(TEntity);
            PropertyInfo[] properties = type.GetProperties();
            List<PropertyInfo> result = new List<PropertyInfo>();
            properties.Where(p => Attribute.IsDefined(p, typeof(KeyAttribute))).ToList().ForEach(p =>
            {
                result.Add(p);
            });
            return result;
        }

        /// <summary>
        /// 设置单个主键属性的实体对象
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <param name="idValue"></param>
        public static void setPrimaryKeyPropertyValue<TEntity>(TEntity entity, object idValue)
        {
            List<PropertyInfo> propertyInfos = GetPrimaryKeyPropertyInfos<TEntity>();
            if (propertyInfos.Count <= 0)
            {
                throw new Exception("搜索不到主键属性");
            }
            if (propertyInfos.Count > 1)
            {
                throw new Exception("有多个主键属性");
            }

            PropertyInfo propertyInfo = propertyInfos[0];

            propertyInfo.SetValue(entity, idValue, null);
        }
    }
}