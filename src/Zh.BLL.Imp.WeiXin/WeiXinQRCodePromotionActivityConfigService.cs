using System;
using System.Collections.Generic;
using System.Text;
using Zh.BLL.Define.Contracts.Imp;
using Zh.Framework.Entities;
using Zh.BLL.Define.ServiceContexts;
using Zh.DAL.Define.Entities;
using Zh.BLL.Define.Entities;
using Zh.BLL.Entities;
using Zh.BLL.Define.Contracts;
using Zh.Framework.Exceptions;

namespace Zh.BLL.Imp.WeiXin
{
    public class WeiXinQRCodePromotionActivityConfigService : IWeiXinQRCodePromotionActivityConfigService
    {
        static WeiXinQRCodePromotionActivityConfig DEFAULT_CONFIG = new WeiXinQRCodePromotionActivityConfig()
        {
            FollowPoints = 1,
            DefaultExchangeMenoey = 1 * 100,
            DefaultUsePoints = 10,
            NewTemporaryQRCodeImageExpireInSeconds = 60 * 60 * 24 * 30,
            IsFollowPublicWeiXinAccountHasPoints = true,
            IsTemporary = true,
            QRCodeActionName = WeiXinQRCodeDto.ACTION_NAME_QR_SCENE,
            GetFollowPulicWeiXinAccountPointsType = GetFollowPulicWeiXinAccountPointsEnum.NewUnique,
            RedPackActivityName = "扫码关注得红包",
            RedPackClientIP = "122.13.65.151",
            RedPackRemark = "朋友扫码关注,红包大派送活动",
            RedPackSendName = "978车生活",
            RedPackWishing = "感谢您参加朋友扫码关注,红包大派送活动",
            CertFilePwd = "1321815801",

        };
        public WeiXinQRCodePromotionActivityConfig CreateOrGet(Guid webApplicationId)
        {
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("weiXinApplicationId不能为空");
            }
            ServiceContext context = new ServiceContext();

            return context.IComConfigMainService.GetOrCreate<WeiXinQRCodePromotionActivityConfig>(webApplicationId, DEFAULT_CONFIG);
        }


    }
}
