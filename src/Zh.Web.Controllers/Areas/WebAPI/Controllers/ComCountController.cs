using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zh.Web.Controllers.Base;
using Zh.BLL.Define.Contracts;
using Zh.Framework.Tools;
using Zh.BLL.Base.Define;
using Zh.Web.Base.Helpers;
using Zh.Framework.Tools.ValidatorTool;
using Zh.Framework.Entities;

namespace Zh.Web.Controllers.Areas.WebAPI.Controllers
{
    public class ComCountController : BaseController
    {
        IComCountService _IComCountService;
        protected IComCountService IComCountService
        {
            get
            {
                if (_IComCountService == null)
                {
                    _IComCountService = ServiceFactory.Get<IComCountService>();
                }
                return _IComCountService;
            }
        }

        public Guid? Id { get; set; }
        public Guid? TargetId { get; set; }
        public string CategoryId { get; set; }
        int _Count = 1;
        public int Count { get { return _Count; } set { _Count = value; } }
        public string Table { get; set; }
        public virtual ActionResult Add()
        {
            var id = Id;
            var targetId = this.TargetId;
            var categoryId = this.CategoryId;
            if (id.HasValue)
            {
                var r = IComCountService.Add(id.Value, this.Count, this.Table);
                return this.ResponseJson(r);
            }
            else if (targetId.HasValue && IValidatorTool.IsNotEmpty(categoryId))
            {
                var r = IComCountService.Add(targetId.Value, categoryId, this.Count, this.Table);
                return this.ResponseJson(r);
            }
            else
            {
                return ResponseJson(new GenericExecResult<object>()
                {
                    Success = false,
                    Message = "请输入相应的参数id或targetId与categoryId"
                });
            }
        }
        public virtual ActionResult Find()
        {
            if (this.Id.HasValue)
            {
                var r = IComCountService.FindById(this.Id.Value);
                return this.ResponseJson(r);
            }
            else if (TargetId.HasValue && IValidatorTool.IsNotEmpty(CategoryId))
            {
                var r = IComCountService.FindFirstOrDefaultByTargetIdAndCategoryId(this.TargetId.Value, this.CategoryId, this.Table);
                return this.ResponseJson(r);
            }
            else if (this.TargetId.HasValue)
            {
                var r = IComCountService.FindByTargetId(this.TargetId.Value, this.Table);
                return this.ResponseJson(r);
            }
            else
            {
                return ResponseJson(new GenericExecResult<object>()
                {
                    Success = false,
                    Message = "请输入相应的参数id或targetId与categoryId"
                });
            }
        }
    }
}
