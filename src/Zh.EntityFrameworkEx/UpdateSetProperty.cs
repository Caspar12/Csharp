using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Zh.EntityFrameworkEx
{
    /// <summary>
    /// 设置更新的对象属性
    /// </summary>
    public interface UpdateSetProperty<TEntity> where TEntity : class, new()
    {
        /// <summary>
        /// 设置需要更新的属性
        /// </summary>
        /// <typeparam name="TProperty">属性类型</typeparam>
        /// <param name="property">属性的表达式</param>
        /// <param name="value">属性值</param>
        /// <returns></returns>
        UpdateSetProperty<TEntity> SetProperty<TProperty>(Expression<Func<TEntity, TProperty>> property, TProperty value);
        /// <summary>
        /// 调用关联的DbContext的SaveChanges方法
        /// </summary>
        void SaveChanges();
        /// <summary>
        /// 获取实体对象实例
        /// </summary>
        TEntity Entity { get; }
    }
}
