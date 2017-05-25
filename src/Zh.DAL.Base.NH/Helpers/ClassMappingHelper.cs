using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Cfg;
using Zh.Framework.Tools;
using Spring.Data.NHibernate;
using NHibernate.Mapping;

namespace Zh.DAL.Base.NH.Helpers
{
    public class ClassMappingHelper : IClassMappingHelper
    {
        public ClassMappingHelper() { }
        public ClassMappingHelper(string localSessionFactoryObjectId)
        {
            this.LocalSessionFactoryObjectId = localSessionFactoryObjectId;
        }
        /// <summary>
        /// 必须注入的Spring.Data.NHibernate.LocalSessionFactoryObject对象Spring Id属性
        /// </summary>
        public string LocalSessionFactoryObjectId { get; set; }
        Configuration _NHConfiguration;
        protected NHibernate.Cfg.Configuration NHConfiguration
        {
            get
            {
                if (_NHConfiguration == null)
                {
                    var l = ToolFactory.DALIoc.Get<LocalSessionFactoryObject>("&" + this.LocalSessionFactoryObjectId);
                    _NHConfiguration = l.Configuration;
                }
                return _NHConfiguration;
            }
        }
        /// <summary>
        /// 获取映射实体类型映射关系
        /// </summary>
        /// <typeparam name="T">映射实体类型</typeparam>
        /// <returns>映射关系</returns>
        public PersistentClass GetClassMapping<T>()
        {
            return NHConfiguration.GetClassMapping(typeof(T));
        }
        /// <summary>
        /// 获取映射实体类型映射关系
        /// </summary>
        /// <param name="type">映射实体类型</param>
        /// <returns>映射关系</returns>
        public PersistentClass GetClassMapping(Type type)
        {
            return NHConfiguration.GetClassMapping(type);
        }
        /// <summary>
        /// 获取映射实体T类型与映射实体T2类型的关联属性
        /// </summary>
        /// <typeparam name="T">映射实体类型</typeparam>
        /// <typeparam name="T2">映射实体类型</typeparam>
        /// <returns>映射实体T类型的关联属性</returns>
        public IList<NHibernate.Mapping.Property> GetAssociationProperties<T, T2>()
        {
            var tClassMapping = GetClassMapping<T>();
            var t2ClassMapping = GetClassMapping<T2>();
            var t2Type = typeof(T2);
            var tProperties = GetProperties<T>();
            var result = new List<Property>();
            foreach (var tProperty in tProperties)
            {
                if (tProperty.Type.IsAssociationType && tProperty.Type.ReturnedClass.UnderlyingSystemType == t2Type)
                {
                    result.Add(tProperty);
                }
            }
            return result;
        }
        /// <summary>
        /// 获取映射实体类型的全部映射关系属性
        /// </summary>
        /// <typeparam name="T">映射实体类型</typeparam>
        /// <returns>全部映射关系属性</returns>
        public IList<Property> GetProperties<T>()
        {
            var tType = typeof(T);
            var cm = GetClassMapping<T>();
            List<Property> result = new List<Property>();
            var tTypeProperties = tType.GetProperties();
            foreach (var tTypeProperty in tTypeProperties)
            {
                var mProp = cm.GetProperty(tTypeProperty.Name);
                result.Add(mProp);
            }
            return result;
        }
        /// <summary>
        /// 获取映射实体类型的主键映射属性
        /// </summary>
        /// <param name="type">实体类型</param>
        /// <returns></returns>
        public Property GetIdentifierProperty(Type type)
        {
            return GetClassMapping(type).IdentifierProperty;
        }
        /// <summary>
        /// 获取映射实体类型的主键映射属性
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <returns></returns>
        public NHibernate.Mapping.Property GetIdentifierProperty<T>()
        {
            return GetIdentifierProperty(typeof(T));
        }
        /// <summary>
        /// 获取映射实体类型的主键映射属性的值
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public object GetIdentifierPropertyValue(object entity)
        {
            var entityType = entity.GetType();
            return GetIdentifierProperty(entityType).GetGetter(entityType).Get(entity);
        }
    }
}
