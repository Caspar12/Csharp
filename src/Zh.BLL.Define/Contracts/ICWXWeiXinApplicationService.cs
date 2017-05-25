/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层接口契约文件 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.BLL.Define.Entities;
using Zh.BLL.Base.Define;
namespace Zh.BLL.Define.Contracts
{
    public partial interface ICWXWeiXinApplicationService : IBaseService<CWXWeiXinApplicationDto, CWX_WeiXinApplication>
    {
        /// <summary>
        /// 获取微信关联程序的微信调用凭证accessToken
        /// </summary>
        /// <param name="id">微信关联程序id</param>
        /// <returns></returns>
          string GetAccessToken(Guid id);
    }
}