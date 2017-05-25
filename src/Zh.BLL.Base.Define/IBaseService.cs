using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Entities;
using Zh.DAL.Base.Define.Query;
using Zh.DAL.Base.Define.Entities;
using Zh.DAL.Base.Define;

namespace Zh.BLL.Base.Define
{
    public interface IBaseService<TDto, TDbEntity> where TDbEntity : class where TDto :class
    {
        TDto FindById(object id);
        TDto Insert(TDto dto);
        TDto InsertOrUpdate(TDto dto);
        TDto Update(TDto dto);
        TDto Delete(object id);
        TDto Delete(TDto dto);
        IList<TDto> FindAll();
        IList<TDto> FindByProperty(string propertyName, object value);
        TDto FirstOrDefault(string propertyName, object value);
        IList<TDto> FindByProperties(DAL.Base.Define.Query.IWhereGetter where);
        TDto FirstOrDefault(DAL.Base.Define.Query.IWhereGetter where);
        GenericPageResult<TDto> Page(DAL.Base.Define.Query.IOrderByGetter orderBys, DAL.Base.Define.Query.IWhereGetter where, int pageIndex = 1, int pageSize = 10);
        IList<TDto> Top(int firstIndex, int maxSize, IOrderByGetter orderByGetter, IWhereGetter where = null);
        TResult Max<TResult>(string propertyName, IWhereGetter where = null);
        TResult Min<TResult>(string propertyName, IWhereGetter where = null);
        TResult Avg<TResult>(string propertyName, IWhereGetter where = null);
        TResult Sum<TResult>(string propertyName, IWhereGetter where = null);
        TResult Count<TResult>(string propertyName, IWhereGetter where = null);
    }
}
