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
using Zh.Framework.Entities;
namespace Zh.BLL.Define.Contracts
{
    public partial interface IWeiXinQRCodeService : IBaseService< WeiXinQRCodeDto,WeiXin_QRCode>
    {
      
    }
}