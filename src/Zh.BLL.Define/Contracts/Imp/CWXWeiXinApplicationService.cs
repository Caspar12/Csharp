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
using Zh.WeiXin.BLL.API;
using Zh.Framework.Tools;
using Zh.Framework.Exceptions;
using Zh.BLL.Define.Contracts.Imp.Caches;

namespace Zh.BLL.Define.Contracts.Imp
{
    public partial class CWXWeiXinApplicationService : GenericContextService<CWXWeiXinApplicationDto, CWX_WeiXinApplication>,
        ICWXWeiXinApplicationService
    {
        WeiXinAPIContext _WeiXinAPIContext;
        /// <summary>
        /// 注入微信API,不注入获取默认
        /// </summary>
        WeiXinAPIContext WeiXinAPIContext
        {
            get
            {
                if (_WeiXinAPIContext == null)
                {
                    _WeiXinAPIContext = ToolFactory.BLLIoc.Get<WeiXinAPIContext>();
                }
                return _WeiXinAPIContext;
            }
            set
            {
                _WeiXinAPIContext = value;
            }
        }
        public string GetAccessToken(Guid id)
        {
            var weiXinWebSiteInfo = this.ServiceContext.ICWXWeiXinApplicationService.FindById(id);
            if (weiXinWebSiteInfo == null)
            {
                throw new BaseException(string.Format("ID({0})微信关联程序数据为空", id));
            }
            var appId = weiXinWebSiteInfo.AppID;
            var appSecret = weiXinWebSiteInfo.AppSecret;
            WeiXinAPIContext.IBasicAPI.IGetAccessTokenCache = new DbAccessTokenCache(id);
            var getAccessTokenResult = _WeiXinAPIContext.IBasicAPI.GetAccessToken(appId, appSecret);
            var accessToken = getAccessTokenResult.access_token;            
            return accessToken;
        }
    }
}
