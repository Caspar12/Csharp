using System;
using System.Collections.Generic;
using System.Text;
using Zh.BLL.Entities;

namespace Zh.BLL.Define.Contracts
{
    /// <summary>
    /// 微信二维码推广活动配置逻辑集合
    /// </summary>
    public interface IWeiXinQRCodePromotionActivityConfigService
    {
        WeiXinQRCodePromotionActivityConfig CreateOrGet(Guid weiXinAppId);
    }
}
