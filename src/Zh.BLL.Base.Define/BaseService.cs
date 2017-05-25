using System;
using System.Collections.Generic;
using System.Text;
using Zh.DAL.Base.Define;
using Zh.DAL.Base.Define.Entities;
using Zh.Framework.Tools.EntityTool;
using Zh.Framework.Tools;
using Zh.Framework.Tools.ValidatorTool;
using Zh.Framework.Entities;
using Zh.DAL.Base.Define.Query;

namespace Zh.BLL.Base.Define
{
    public class BaseService<TDto, TDbEntity> : AbstractBaseService, IBaseService<TDto, TDbEntity>
        where TDbEntity : class
        where TDto : class
    {

        public TDto MapToDto(TDbEntity entity)
        {
            var mapper = ToolFactory.Ioc.Get<IEntityTool>();
            return mapper.Map<TDbEntity, TDto>(entity);
        }
        public IList<TDto> MapToDto(IEnumerable<TDbEntity> entities)
        {
            var mapper = ToolFactory.Ioc.Get<IEntityTool>();
            return mapper.Map<TDbEntity, TDto>(entities);
        }
        public TDbEntity MapToDbEntity(TDto dto)
        {
            var mapper = ToolFactory.Ioc.Get<IEntityTool>();
            return mapper.Map<TDto, TDbEntity>(dto);
        }
        public IList<TDbEntity> MapToDbEntity(IEnumerable<TDto> dtos)
        {
            var mapper = ToolFactory.Ioc.Get<IEntityTool>();
            return mapper.Map<TDto, TDbEntity>(dtos);
        }

        public TDto FindById(object id)
        {
            var entity = this.IBaseDao.FindById<TDbEntity>(id);
            var dto = MapToDto(entity);
            return dto;
        }

        public TDto Insert(TDto dto)
        {
            var entity = MapToDbEntity(dto);
            var newEntity = this.IBaseDao.Insert(entity);
            this.IBaseDao.SaveChange();
            var newDto = MapToDto(newEntity);
            return newDto;
        }

        public TDto InsertOrUpdate(TDto dto)
        {
            var entity = MapToDbEntity(dto);
            var newEntity = this.IBaseDao.InsertOrUpdate(entity);
            this.IBaseDao.SaveChange();
            var newDto = MapToDto(newEntity);
            return newDto;
        }

        public TDto Update(TDto dto)
        {
            var entity = MapToDbEntity(dto);
            var newEntity = this.IBaseDao.Update(entity);
            this.IBaseDao.SaveChange();
            var newDto = MapToDto(newEntity);
            return newDto;
        }

        public TDto Delete(object id)
        {
            var deleteEntity = this.IBaseDao.Delete<TDbEntity>(id);
            this.IBaseDao.SaveChange();
            var newDto = MapToDto(deleteEntity);
            return newDto;
        }

        public TDto Delete(TDto dto)
        {
            var entity = MapToDbEntity(dto);
            var deleteEntity = this.IBaseDao.Delete(entity);
            this.IBaseDao.SaveChange();
            return dto;
        }

        public IList<TDto> FindAll()
        {
            var entities = this.IBaseDao.FindAll<TDbEntity>();
            var dtos = MapToDto(entities);
            return dtos;
        }

        public IList<TDto> FindByProperty(string propertyName, object value)
        {
            return this.FindByProperties(Where.Create().Eq(propertyName, value));
        }

        public IList<TDto> FindByProperties(DAL.Base.Define.Query.IWhereGetter where)
        {
            var entities = this.IBaseDao.FindByProperties<TDbEntity>(where);
            var dtos = MapToDto(entities);
            return dtos;
        }

        public GenericPageResult<TDto> Page(DAL.Base.Define.Query.IOrderByGetter orderBys, DAL.Base.Define.Query.IWhereGetter where, int pageIndex = 1, int pageSize = 10)
        {
            var pageEntity = this.IBaseDao.Page<TDbEntity>(orderBys, where, pageIndex, pageSize);
            var entity = pageEntity.Data;
            var dto = MapToDto(entity);
            return new GenericPageResult<TDto>()
            {
                Total = pageEntity.Total,
                PageIndex = pageEntity.PageIndex,
                PageSize = pageEntity.PageSize,
                Data = dto
            };
        }

        public IList<TDto> Top(int firstIndex, int maxSize, IOrderByGetter orderByGetter, IWhereGetter where = null)
        {
            var entities = this.IBaseDao.Top<TDbEntity>(firstIndex, maxSize, orderByGetter, where);
            var dtos = MapToDto(entities);
            return dtos;
        }
        public TDto FirstOrDefault(string propertyName, object value)
        {
            return this.FirstOrDefault(Where.Create().Eq(propertyName, value));
        }

        public TDto FirstOrDefault(IWhereGetter where)
        {
            var entity = this.IBaseDao.FirstOrDefault<TDbEntity>(where);
            if (entity == null)
            {
                return null;
            }
            var dto = MapToDto(entity);
            return dto;
        }

        public TResult Max<TResult>(string propertyName, IWhereGetter where = null)
        {
            return this.IBaseDao.Max<TDbEntity, TResult>(propertyName, where);
        }

        public TResult Min<TResult>(string propertyName, IWhereGetter where = null)
        {
            return this.IBaseDao.Min<TDbEntity, TResult>(propertyName, where);
        }

        public TResult Avg<TResult>(string propertyName, IWhereGetter where = null)
        {
            return this.IBaseDao.Avg<TDbEntity, TResult>(propertyName, where);
        }

        public TResult Sum<TResult>(string propertyName, IWhereGetter where = null)
        {
            return this.IBaseDao.Sum<TDbEntity, TResult>(propertyName, where);
        }

        public TResult Count<TResult>(string propertyName, IWhereGetter where = null)
        {
            return this.IBaseDao.Count<TDbEntity, TResult>(propertyName, where);
        }


    }
}
