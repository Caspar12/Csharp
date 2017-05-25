using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.DAL.Base.NH.Helpers
{
    public interface IClassMappingHelper
    {
        System.Collections.Generic.IList<NHibernate.Mapping.Property> GetAssociationProperties<T, T2>();
        NHibernate.Mapping.PersistentClass GetClassMapping(Type type);
        NHibernate.Mapping.PersistentClass GetClassMapping<T>();
        System.Collections.Generic.IList<NHibernate.Mapping.Property> GetProperties<T>();
        /// <summary>
        /// 获取映射实体类型的主键映射属性
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <returns></returns>
        NHibernate.Mapping.Property GetIdentifierProperty<T>();
        /// <summary>
        /// 获取映射实体类型的主键映射属性
        /// </summary>
        /// <param name="type">实体类型</param>
        /// <returns></returns>
        NHibernate.Mapping.Property GetIdentifierProperty(Type type);
        /// <summary>
        /// 获取映射实体类型的主键映射属性的值
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        object GetIdentifierPropertyValue(object entity);
    }
}
