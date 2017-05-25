/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据接口契约文件 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.DAL.Base.Define;
using Zh.DAL.Base.Define.Query;
using Zh.BLL.Base.Define;
using Zh.BLL.Define.Entities;
using Zh.Framework.Exceptions;
using Zh.DAL.Base.Define.Entities;
using Zh.Framework.Entities;
using Zh.BLL.Define;
using Zh.BLL.Define.Contracts;

namespace Zh.BLL.Imp.WeiXin
{
    public partial class WeiXinQRCodePromotionActivityAccountPointsHistoryService : GenericContextService<WeiXinQRCodePromotionActivityAccountPointsHistoryDto, WeiXin_QRCodePromotionActivityAccountPointsHistory>,
        IWeiXinQRCodePromotionActivityAccountPointsHistoryService
    {
        public GenericPageResult<WeiXinQRCodePromotionActivityAccountPointsHistoryDto> Find(Guid webApplicationId, string openId, int pageIndex = 1, int pageSize = 10)
        {
            if (this.IValidatorTool.IsEmpty(openId))
            {
                throw new BaseException("openId不能为空");
            }
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("webApplicationId不能为空");
            }
            var where = Where.Create().Eq("WebApplicationId", webApplicationId).Eq("OpenId", openId);
            var orderBy = OrderByHelper.Create().Desc("CreatedDate");
            var list = this.Page(orderBy, where, pageIndex, pageSize);
            return list;
        }
    }
}
