using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.IocTool;
using Zh.BLL.Define.Contracts;

namespace Zh.BLL.Define.ServiceContexts
{
    public partial class ServiceContext
    {

        IWeiXinQRCodePromotionActivityConfigService _IWeiXinQRCodePromotionActivityConfigService;
        /// <summary>
        /// 微信二维码推广活动配置逻辑集合契约接口
        /// </summary>
        public IWeiXinQRCodePromotionActivityConfigService IWeiXinQRCodePromotionActivityConfigService
        {
            get
            {
                if (_IWeiXinQRCodePromotionActivityConfigService == null)
                {
                    _IWeiXinQRCodePromotionActivityConfigService = this.BLLIocTool.Get<IWeiXinQRCodePromotionActivityConfigService>();
                }
                return _IWeiXinQRCodePromotionActivityConfigService;
            }
        }
        IWeiXinQRCodePromotionActivitySendRedPackService _IWeiXinQRCodePromotionActivitySendRedPackService;
        /// <summary>
        /// 微信二维码推广活动发放红包逻辑集合契约接口
        /// </summary>
        public IWeiXinQRCodePromotionActivitySendRedPackService IWeiXinQRCodePromotionActivitySendRedPackService
        {
            get
            {
                if (_IWeiXinQRCodePromotionActivitySendRedPackService == null)
                {
                    _IWeiXinQRCodePromotionActivitySendRedPackService = this.BLLIocTool.Get<IWeiXinQRCodePromotionActivitySendRedPackService>();
                }
                return _IWeiXinQRCodePromotionActivitySendRedPackService;
            }
        }

    }
}
