/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据接口契约文件
 * 文件由模板生成
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.DAL.Base.Define;
using Zh.DAL.Base.Define.Query;
using Zh.BLL.Base.Define;
using Zh.BLL.Define.Entities;

namespace Zh.BLL.Define.Contracts.Imp
{
    public partial class ComClickService : GenericContextService<ComClickDto, Com_Click>, IComClickService
    {

        public void CreateAndQuery()
        {
            var newComClick = new ComClickDto();
            var id = Guid.NewGuid();
            var m1 = this.ServiceContext.IComClickService.CreateOrGet("test");
            var m2 = this.ServiceContext.IComClickService.CreateOrGet("test");
            throw new Exception();
        }

        public ComClickDto CreateOrGet(string category)
        {
            var m = this.FirstOrDefault(
                Where.Create()
                .Eq("Category", category)
            );
            if (m == null)
            {
                var newComClick = new ComClickDto();
                newComClick.ID = Guid.NewGuid();
                newComClick.ClickCount = 1;
                newComClick.Category = "test";
                this.InsertOrUpdate(newComClick);
                var where = Where.Create()
            .Eq("Category", category);
                var m1 = this.FirstOrDefault(
                    where
                );
                var m2 = this.FindById(newComClick.ID);
                return newComClick;
            }
            return m;
        }
    }
}
