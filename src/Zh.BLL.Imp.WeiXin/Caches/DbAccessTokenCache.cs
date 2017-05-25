using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Cache;
using Zh.WeiXin.BLL.Caches;
using Zh.BLL.Define.ServiceContexts;
using Zh.DAL.Define;
using Zh.Framework.Exceptions;

namespace Zh.BLL.Imp.WeiXin.Caches
{
    /// <summary>
    /// 微信AccessToken 数据库缓存类
    /// </summary>
    public class DbAccessTokenCache : IGetAccessTokenCache
    {
        public DbAccessTokenCache(Guid weiXinApplicationId)
        {
            this.WeiXinApplicationId = weiXinApplicationId;
        }
        public Guid WeiXinApplicationId { get; set; }
        ServiceContext _ServiceContext = new ServiceContext();
        public Zh.WeiXin.BLL.API.Entities.GetAccessTokenResult Get(string appId)
        {
            var weiXinSiteInfo = _ServiceContext.ICWXWeiXinApplicationService.FindById(this.WeiXinApplicationId);
            if (weiXinSiteInfo == null)
            {
                throw new BaseException(string.Format("ID({0})微信关联程序数据为空", this.WeiXinApplicationId));
            }
          
            if (weiXinSiteInfo.IsAccessTokenExpire) return null;
            return new Zh.WeiXin.BLL.API.Entities.GetAccessTokenResult()
            {
                access_token = weiXinSiteInfo.AccessToken,
                expires_in = weiXinSiteInfo.AccessTokenExpireInSeconds
            };
        }

        public void Set(string key, Zh.WeiXin.BLL.API.Entities.GetAccessTokenResult getAccessTokenResult)
        {
            var weiXinSiteInfo = _ServiceContext.ICWXWeiXinApplicationService.FindById(this.WeiXinApplicationId);
            if (weiXinSiteInfo == null)
            {
                throw new BaseException(string.Format("ID({0})微信关联程序数据为空", this.WeiXinApplicationId));
            }
         
            weiXinSiteInfo.AccessTokenUpdateDateTime = DateTime.Now;
            _ServiceContext.ICWXWeiXinApplicationService.Update(weiXinSiteInfo);
        }
    }
}
