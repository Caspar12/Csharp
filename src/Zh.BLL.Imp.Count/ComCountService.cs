/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据接口契约文件
 * 文件由模板生成
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
using Zh.DAL.Base.Define;
using Zh.BLL.Base.Define;
using Zh.BLL.Define.Entities;
using System.Collections.Generic;
using Zh.DAL.Base.Define.Query;
using Zh.Framework.Entities;
using Zh.DAL.Define.Contracts;
using Zh.BLL.Define.Contracts;

namespace Zh.BLL.Imp.Count
{
    public partial class ComCountService : Zh.BLL.Define.Contracts.Imp.ComCountService, IComCountService
    {
        public string TableName { get; set; }

        public Framework.Entities.GenericExecResult<IList<ComCountDto>> FindByTargetId(Guid targetId, string table = null)
        {
            table = string.IsNullOrEmpty(table) ? TableName : table;
            var where = Where.Create().Eq("TargetId", targetId).EqIfNotNull("TableName", table);
            var list = this.FindByProperties(where);
            return new GenericExecResult<IList<ComCountDto>>()
            {
                Success = true,
                Data = list
            };
        }
        public GenericExecResult<ComCountDto> FindFirstOrDefaultByTargetIdAndCategoryId(Guid targetId, string categoryId, string table = null)
        {
            table = string.IsNullOrEmpty(table) ? TableName : table;
            Com_Count entity = this.IBaseDao.FirstOrDefault<Com_Count>(
                Where.Create()
                .Eq("TargetId", targetId)
                .Eq("CategoryId", categoryId)
                .EqIfNotNull("TableName", table)
           );
            var dtoList = MapToDto(entity);
            return new Framework.Entities.GenericExecResult<ComCountDto>()
            {
                Data = dtoList,
                Success = true
            };
        }

        public Framework.Entities.GenericExecResult<ComCountDto> Add(Guid id, int count = 1, string table = null)
        {

            var entity = this.FindById(id);
            if (entity == null)
            {
                entity = new ComCountDto()
                {
                    Id = id,
                    Count = 0,
                    TargetId = id,
                    CreatedDatetime = DateTime.Now,
                    TableName = string.IsNullOrEmpty(table) ? TableName : table
                };
                this.Insert(entity);
            }

            entity.Count += count;
            var updateEntity = this.Update(entity);

            return new Framework.Entities.GenericExecResult<ComCountDto>()
            {
                Data = updateEntity,
                Success = true
            };
        }

        public Framework.Entities.GenericExecResult<ComCountDto> Add(Guid targetId, string categoryId = null, int count = 1, string table = null)
        {
            table = string.IsNullOrEmpty(table) ? TableName : table;
            var entity = this.IBaseDao.FirstOrDefault<Com_Count>(
                Where.Create()
                .Eq("TargetId", targetId)
                .Eq("CategoryId", categoryId)
                .EqIfNotNull("TableName", table)
            );
            if (entity == null)
            {
                entity = new Com_Count()
                {
                    Id = Guid.NewGuid(),
                    Count = 0,
                    TargetId = targetId,
                    CreatedDatetime = DateTime.Now,
                    TableName = table,
                    CategoryId = categoryId
                };
                this.IBaseDao.Insert(entity);
            }
            entity.Count += count;
            var updateEntity = this.IBaseDao.Update(entity);
            var dto = MapToDto(updateEntity);
            return new Framework.Entities.GenericExecResult<ComCountDto>()
            {
                Data = dto,
                Success = true
            };
        }
        public int Test()
        {
            return 1;
        }



        public string Test1(string paramA = "aaa")
        {
            return paramA;
        }

        public string Test2(List<string> a)
        {
            return a.Count.ToString();
        }
        public string Test3(List<Guid> a)
        {
            return a.Count.ToString();
        }
    }
}
