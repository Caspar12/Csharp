/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层接口集合Context文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
using Zh.DAL.Define;
using Zh.DAL.Define.Contracts;
using Zh.Framework.Tools.IocTool;
using Zh.BLL.Define.Contracts;
namespace Zh.BLL.Define.ServiceContexts
{
    /// <summary>
    /// 逻辑层接口集合
    /// </summary>
    public partial class ServiceContext
    {
        /// <summary>
        /// 契约接口IoC接口
        /// </summary>
        IIocTool BLLIocTool = Zh.Framework.Tools.ToolFactory.BLLIoc;

        IActivityACMatchService _IActivityACMatchService;
        /// <summary>
        /// Activity_AC_Match(对抗类比赛表)表逻辑契约接口
        /// </summary>
        public IActivityACMatchService IActivityACMatchService
        {
            get
            {
                if (_IActivityACMatchService == null)
                {
                    _IActivityACMatchService = this.BLLIocTool.Get<IActivityACMatchService>();
                }
                return _IActivityACMatchService;
            }
        }

        IActivityACScoreGuessRecordService _IActivityACScoreGuessRecordService;
        /// <summary>
        /// Activity_AC_ScoreGuessRecord(对抗类比赛竞猜比分)表逻辑契约接口
        /// </summary>
        public IActivityACScoreGuessRecordService IActivityACScoreGuessRecordService
        {
            get
            {
                if (_IActivityACScoreGuessRecordService == null)
                {
                    _IActivityACScoreGuessRecordService = this.BLLIocTool.Get<IActivityACScoreGuessRecordService>();
                }
                return _IActivityACScoreGuessRecordService;
            }
        }

        IActivityACWinnerGuessRecordService _IActivityACWinnerGuessRecordService;
        /// <summary>
        /// Activity_AC_WinnerGuessRecord(积分竞猜记录)表逻辑契约接口
        /// </summary>
        public IActivityACWinnerGuessRecordService IActivityACWinnerGuessRecordService
        {
            get
            {
                if (_IActivityACWinnerGuessRecordService == null)
                {
                    _IActivityACWinnerGuessRecordService = this.BLLIocTool.Get<IActivityACWinnerGuessRecordService>();
                }
                return _IActivityACWinnerGuessRecordService;
            }
        }

        IActivityAttentionService _IActivityAttentionService;
        /// <summary>
        /// Activity_Attention()表逻辑契约接口
        /// </summary>
        public IActivityAttentionService IActivityAttentionService
        {
            get
            {
                if (_IActivityAttentionService == null)
                {
                    _IActivityAttentionService = this.BLLIocTool.Get<IActivityAttentionService>();
                }
                return _IActivityAttentionService;
            }
        }

        IActivityChampionGuessRecordService _IActivityChampionGuessRecordService;
        /// <summary>
        /// Activity_ChampionGuessRecord(冠军竞猜记录)表逻辑契约接口
        /// </summary>
        public IActivityChampionGuessRecordService IActivityChampionGuessRecordService
        {
            get
            {
                if (_IActivityChampionGuessRecordService == null)
                {
                    _IActivityChampionGuessRecordService = this.BLLIocTool.Get<IActivityChampionGuessRecordService>();
                }
                return _IActivityChampionGuessRecordService;
            }
        }

        IActivityHistoryService _IActivityHistoryService;
        /// <summary>
        /// Activity_History(活动抽奖历史表)表逻辑契约接口
        /// </summary>
        public IActivityHistoryService IActivityHistoryService
        {
            get
            {
                if (_IActivityHistoryService == null)
                {
                    _IActivityHistoryService = this.BLLIocTool.Get<IActivityHistoryService>();
                }
                return _IActivityHistoryService;
            }
        }

        IActivityLotteryMainService _IActivityLotteryMainService;
        /// <summary>
        /// Activity_LotteryMain(活动表)表逻辑契约接口
        /// </summary>
        public IActivityLotteryMainService IActivityLotteryMainService
        {
            get
            {
                if (_IActivityLotteryMainService == null)
                {
                    _IActivityLotteryMainService = this.BLLIocTool.Get<IActivityLotteryMainService>();
                }
                return _IActivityLotteryMainService;
            }
        }

        IActivityMainService _IActivityMainService;
        /// <summary>
        /// Activity_Main(活动表)表逻辑契约接口
        /// </summary>
        public IActivityMainService IActivityMainService
        {
            get
            {
                if (_IActivityMainService == null)
                {
                    _IActivityMainService = this.BLLIocTool.Get<IActivityMainService>();
                }
                return _IActivityMainService;
            }
        }

        IActivityMainToUserService _IActivityMainToUserService;
        /// <summary>
        /// Activity_MainToUser(用户参与活动记录表)表逻辑契约接口
        /// </summary>
        public IActivityMainToUserService IActivityMainToUserService
        {
            get
            {
                if (_IActivityMainToUserService == null)
                {
                    _IActivityMainToUserService = this.BLLIocTool.Get<IActivityMainToUserService>();
                }
                return _IActivityMainToUserService;
            }
        }

        IActivityPrizeService _IActivityPrizeService;
        /// <summary>
        /// Activity_Prize(活动奖品表)表逻辑契约接口
        /// </summary>
        public IActivityPrizeService IActivityPrizeService
        {
            get
            {
                if (_IActivityPrizeService == null)
                {
                    _IActivityPrizeService = this.BLLIocTool.Get<IActivityPrizeService>();
                }
                return _IActivityPrizeService;
            }
        }

        IActivityTeamService _IActivityTeamService;
        /// <summary>
        /// Activity_Team(队伍)表逻辑契约接口
        /// </summary>
        public IActivityTeamService IActivityTeamService
        {
            get
            {
                if (_IActivityTeamService == null)
                {
                    _IActivityTeamService = this.BLLIocTool.Get<IActivityTeamService>();
                }
                return _IActivityTeamService;
            }
        }

        IActivityUserExtendInfoService _IActivityUserExtendInfoService;
        /// <summary>
        /// Activity_UserExtendInfo(活动用户信息扩展表)表逻辑契约接口
        /// </summary>
        public IActivityUserExtendInfoService IActivityUserExtendInfoService
        {
            get
            {
                if (_IActivityUserExtendInfoService == null)
                {
                    _IActivityUserExtendInfoService = this.BLLIocTool.Get<IActivityUserExtendInfoService>();
                }
                return _IActivityUserExtendInfoService;
            }
        }

        IActivityUserPrizeService _IActivityUserPrizeService;
        /// <summary>
        /// Activity_UserPrize(活动中奖人员表)表逻辑契约接口
        /// </summary>
        public IActivityUserPrizeService IActivityUserPrizeService
        {
            get
            {
                if (_IActivityUserPrizeService == null)
                {
                    _IActivityUserPrizeService = this.BLLIocTool.Get<IActivityUserPrizeService>();
                }
                return _IActivityUserPrizeService;
            }
        }

        IAdsingleService _IAdsingleService;
        /// <summary>
        /// Ad_single()表逻辑契约接口
        /// </summary>
        public IAdsingleService IAdsingleService
        {
            get
            {
                if (_IAdsingleService == null)
                {
                    _IAdsingleService = this.BLLIocTool.Get<IAdsingleService>();
                }
                return _IAdsingleService;
            }
        }

        IAdBannerService _IAdBannerService;
        /// <summary>
        /// AdBanner()表逻辑契约接口
        /// </summary>
        public IAdBannerService IAdBannerService
        {
            get
            {
                if (_IAdBannerService == null)
                {
                    _IAdBannerService = this.BLLIocTool.Get<IAdBannerService>();
                }
                return _IAdBannerService;
            }
        }

        IAdTemplateService _IAdTemplateService;
        /// <summary>
        /// AdTemplate()表逻辑契约接口
        /// </summary>
        public IAdTemplateService IAdTemplateService
        {
            get
            {
                if (_IAdTemplateService == null)
                {
                    _IAdTemplateService = this.BLLIocTool.Get<IAdTemplateService>();
                }
                return _IAdTemplateService;
            }
        }

        IArticleMainService _IArticleMainService;
        /// <summary>
        /// Article_Main(文章表)表逻辑契约接口
        /// </summary>
        public IArticleMainService IArticleMainService
        {
            get
            {
                if (_IArticleMainService == null)
                {
                    _IArticleMainService = this.BLLIocTool.Get<IArticleMainService>();
                }
                return _IArticleMainService;
            }
        }

        IArticleMainToArticleService _IArticleMainToArticleService;
        /// <summary>
        /// Article_MainToArticle()表逻辑契约接口
        /// </summary>
        public IArticleMainToArticleService IArticleMainToArticleService
        {
            get
            {
                if (_IArticleMainToArticleService == null)
                {
                    _IArticleMainToArticleService = this.BLLIocTool.Get<IArticleMainToArticleService>();
                }
                return _IArticleMainToArticleService;
            }
        }

        IArticleMainToBrandService _IArticleMainToBrandService;
        /// <summary>
        /// Article_MainToBrand()表逻辑契约接口
        /// </summary>
        public IArticleMainToBrandService IArticleMainToBrandService
        {
            get
            {
                if (_IArticleMainToBrandService == null)
                {
                    _IArticleMainToBrandService = this.BLLIocTool.Get<IArticleMainToBrandService>();
                }
                return _IArticleMainToBrandService;
            }
        }

        IAuthAdministratorRoleRefService _IAuthAdministratorRoleRefService;
        /// <summary>
        /// Auth_AdministratorRoleRef(后台账号与角色关系表)表逻辑契约接口
        /// </summary>
        public IAuthAdministratorRoleRefService IAuthAdministratorRoleRefService
        {
            get
            {
                if (_IAuthAdministratorRoleRefService == null)
                {
                    _IAuthAdministratorRoleRefService = this.BLLIocTool.Get<IAuthAdministratorRoleRefService>();
                }
                return _IAuthAdministratorRoleRefService;
            }
        }

        IAuthPermissionService _IAuthPermissionService;
        /// <summary>
        /// Auth_Permission(权限表)表逻辑契约接口
        /// </summary>
        public IAuthPermissionService IAuthPermissionService
        {
            get
            {
                if (_IAuthPermissionService == null)
                {
                    _IAuthPermissionService = this.BLLIocTool.Get<IAuthPermissionService>();
                }
                return _IAuthPermissionService;
            }
        }

        IAuthPermissionResourceRefService _IAuthPermissionResourceRefService;
        /// <summary>
        /// Auth_PermissionResourceRef(权限资源关系表)表逻辑契约接口
        /// </summary>
        public IAuthPermissionResourceRefService IAuthPermissionResourceRefService
        {
            get
            {
                if (_IAuthPermissionResourceRefService == null)
                {
                    _IAuthPermissionResourceRefService = this.BLLIocTool.Get<IAuthPermissionResourceRefService>();
                }
                return _IAuthPermissionResourceRefService;
            }
        }

        IAuthPermissionRoleRefService _IAuthPermissionRoleRefService;
        /// <summary>
        /// Auth_PermissionRoleRef(权限与角色关系表)表逻辑契约接口
        /// </summary>
        public IAuthPermissionRoleRefService IAuthPermissionRoleRefService
        {
            get
            {
                if (_IAuthPermissionRoleRefService == null)
                {
                    _IAuthPermissionRoleRefService = this.BLLIocTool.Get<IAuthPermissionRoleRefService>();
                }
                return _IAuthPermissionRoleRefService;
            }
        }

        IAuthResourceService _IAuthResourceService;
        /// <summary>
        /// Auth_Resource(权限资源表)表逻辑契约接口
        /// </summary>
        public IAuthResourceService IAuthResourceService
        {
            get
            {
                if (_IAuthResourceService == null)
                {
                    _IAuthResourceService = this.BLLIocTool.Get<IAuthResourceService>();
                }
                return _IAuthResourceService;
            }
        }

        IAuthRoleService _IAuthRoleService;
        /// <summary>
        /// Auth_Role(权限角色表)表逻辑契约接口
        /// </summary>
        public IAuthRoleService IAuthRoleService
        {
            get
            {
                if (_IAuthRoleService == null)
                {
                    _IAuthRoleService = this.BLLIocTool.Get<IAuthRoleService>();
                }
                return _IAuthRoleService;
            }
        }

        IBBSCommentService _IBBSCommentService;
        /// <summary>
        /// BBS_Comment(评论内容表)表逻辑契约接口
        /// </summary>
        public IBBSCommentService IBBSCommentService
        {
            get
            {
                if (_IBBSCommentService == null)
                {
                    _IBBSCommentService = this.BLLIocTool.Get<IBBSCommentService>();
                }
                return _IBBSCommentService;
            }
        }

        IBBSCommentExtInfoService _IBBSCommentExtInfoService;
        /// <summary>
        /// BBS_CommentExtInfo(评论汇总表)表逻辑契约接口
        /// </summary>
        public IBBSCommentExtInfoService IBBSCommentExtInfoService
        {
            get
            {
                if (_IBBSCommentExtInfoService == null)
                {
                    _IBBSCommentExtInfoService = this.BLLIocTool.Get<IBBSCommentExtInfoService>();
                }
                return _IBBSCommentExtInfoService;
            }
        }

        IBBSCommentSupportRecordService _IBBSCommentSupportRecordService;
        /// <summary>
        /// BBS_CommentSupportRecord(评论支持记录表)表逻辑契约接口
        /// </summary>
        public IBBSCommentSupportRecordService IBBSCommentSupportRecordService
        {
            get
            {
                if (_IBBSCommentSupportRecordService == null)
                {
                    _IBBSCommentSupportRecordService = this.BLLIocTool.Get<IBBSCommentSupportRecordService>();
                }
                return _IBBSCommentSupportRecordService;
            }
        }

        IBBSCommentTypeService _IBBSCommentTypeService;
        /// <summary>
        /// BBS_CommentType(评论类型表)表逻辑契约接口
        /// </summary>
        public IBBSCommentTypeService IBBSCommentTypeService
        {
            get
            {
                if (_IBBSCommentTypeService == null)
                {
                    _IBBSCommentTypeService = this.BLLIocTool.Get<IBBSCommentTypeService>();
                }
                return _IBBSCommentTypeService;
            }
        }

        IBookingCarInfoToActivityOrdersService _IBookingCarInfoToActivityOrdersService;
        /// <summary>
        /// Booking_CarInfoToActivityOrders(预约活动订单表)表逻辑契约接口
        /// </summary>
        public IBookingCarInfoToActivityOrdersService IBookingCarInfoToActivityOrdersService
        {
            get
            {
                if (_IBookingCarInfoToActivityOrdersService == null)
                {
                    _IBookingCarInfoToActivityOrdersService = this.BLLIocTool.Get<IBookingCarInfoToActivityOrdersService>();
                }
                return _IBookingCarInfoToActivityOrdersService;
            }
        }

        ICarAirConditionerAndRefrigeratorConfigService _ICarAirConditionerAndRefrigeratorConfigService;
        /// <summary>
        /// Car_AirConditionerAndRefrigeratorConfig(车辆空调与冰箱配置)表逻辑契约接口
        /// </summary>
        public ICarAirConditionerAndRefrigeratorConfigService ICarAirConditionerAndRefrigeratorConfigService
        {
            get
            {
                if (_ICarAirConditionerAndRefrigeratorConfigService == null)
                {
                    _ICarAirConditionerAndRefrigeratorConfigService = this.BLLIocTool.Get<ICarAirConditionerAndRefrigeratorConfigService>();
                }
                return _ICarAirConditionerAndRefrigeratorConfigService;
            }
        }

        ICarAutoHomeRefService _ICarAutoHomeRefService;
        /// <summary>
        /// Car_AutoHome_Ref(汽车之家关系表)表逻辑契约接口
        /// </summary>
        public ICarAutoHomeRefService ICarAutoHomeRefService
        {
            get
            {
                if (_ICarAutoHomeRefService == null)
                {
                    _ICarAutoHomeRefService = this.BLLIocTool.Get<ICarAutoHomeRefService>();
                }
                return _ICarAutoHomeRefService;
            }
        }

        ICarBrandService _ICarBrandService;
        /// <summary>
        /// Car_Brand(车辆品牌)表逻辑契约接口
        /// </summary>
        public ICarBrandService ICarBrandService
        {
            get
            {
                if (_ICarBrandService == null)
                {
                    _ICarBrandService = this.BLLIocTool.Get<ICarBrandService>();
                }
                return _ICarBrandService;
            }
        }

        ICarBrandImageService _ICarBrandImageService;
        /// <summary>
        /// Car_BrandImage( )表逻辑契约接口
        /// </summary>
        public ICarBrandImageService ICarBrandImageService
        {
            get
            {
                if (_ICarBrandImageService == null)
                {
                    _ICarBrandImageService = this.BLLIocTool.Get<ICarBrandImageService>();
                }
                return _ICarBrandImageService;
            }
        }

        ICarBrandToDistributorService _ICarBrandToDistributorService;
        /// <summary>
        /// Car_BrandToDistributor(品牌与经销商关系表)表逻辑契约接口
        /// </summary>
        public ICarBrandToDistributorService ICarBrandToDistributorService
        {
            get
            {
                if (_ICarBrandToDistributorService == null)
                {
                    _ICarBrandToDistributorService = this.BLLIocTool.Get<ICarBrandToDistributorService>();
                }
                return _ICarBrandToDistributorService;
            }
        }

        ICarColorService _ICarColorService;
        /// <summary>
        /// Car_Color(车辆颜色)表逻辑契约接口
        /// </summary>
        public ICarColorService ICarColorService
        {
            get
            {
                if (_ICarColorService == null)
                {
                    _ICarColorService = this.BLLIocTool.Get<ICarColorService>();
                }
                return _ICarColorService;
            }
        }

        ICarControlConfigService _ICarControlConfigService;
        /// <summary>
        /// Car_ControlConfig(车辆操控配置)表逻辑契约接口
        /// </summary>
        public ICarControlConfigService ICarControlConfigService
        {
            get
            {
                if (_ICarControlConfigService == null)
                {
                    _ICarControlConfigService = this.BLLIocTool.Get<ICarControlConfigService>();
                }
                return _ICarControlConfigService;
            }
        }

        ICarDistributorService _ICarDistributorService;
        /// <summary>
        /// Car_Distributor(车辆经销商)表逻辑契约接口
        /// </summary>
        public ICarDistributorService ICarDistributorService
        {
            get
            {
                if (_ICarDistributorService == null)
                {
                    _ICarDistributorService = this.BLLIocTool.Get<ICarDistributorService>();
                }
                return _ICarDistributorService;
            }
        }

        ICarDistributorImageService _ICarDistributorImageService;
        /// <summary>
        /// Car_DistributorImage( )表逻辑契约接口
        /// </summary>
        public ICarDistributorImageService ICarDistributorImageService
        {
            get
            {
                if (_ICarDistributorImageService == null)
                {
                    _ICarDistributorImageService = this.BLLIocTool.Get<ICarDistributorImageService>();
                }
                return _ICarDistributorImageService;
            }
        }

        ICarDomainConfigService _ICarDomainConfigService;
        /// <summary>
        /// Car_Domain_Config(车辆域配置)表逻辑契约接口
        /// </summary>
        public ICarDomainConfigService ICarDomainConfigService
        {
            get
            {
                if (_ICarDomainConfigService == null)
                {
                    _ICarDomainConfigService = this.BLLIocTool.Get<ICarDomainConfigService>();
                }
                return _ICarDomainConfigService;
            }
        }

        ICarEnquiryService _ICarEnquiryService;
        /// <summary>
        /// Car_Enquiry()表逻辑契约接口
        /// </summary>
        public ICarEnquiryService ICarEnquiryService
        {
            get
            {
                if (_ICarEnquiryService == null)
                {
                    _ICarEnquiryService = this.BLLIocTool.Get<ICarEnquiryService>();
                }
                return _ICarEnquiryService;
            }
        }

        ICarExchangeService _ICarExchangeService;
        /// <summary>
        /// Car_Exchange()表逻辑契约接口
        /// </summary>
        public ICarExchangeService ICarExchangeService
        {
            get
            {
                if (_ICarExchangeService == null)
                {
                    _ICarExchangeService = this.BLLIocTool.Get<ICarExchangeService>();
                }
                return _ICarExchangeService;
            }
        }

        ICarExternalConfigService _ICarExternalConfigService;
        /// <summary>
        /// Car_ExternalConfig(外部配置)表逻辑契约接口
        /// </summary>
        public ICarExternalConfigService ICarExternalConfigService
        {
            get
            {
                if (_ICarExternalConfigService == null)
                {
                    _ICarExternalConfigService = this.BLLIocTool.Get<ICarExternalConfigService>();
                }
                return _ICarExternalConfigService;
            }
        }

        ICarHighTechConfigService _ICarHighTechConfigService;
        /// <summary>
        /// Car_HighTechConfig(车辆高科技配置)表逻辑契约接口
        /// </summary>
        public ICarHighTechConfigService ICarHighTechConfigService
        {
            get
            {
                if (_ICarHighTechConfigService == null)
                {
                    _ICarHighTechConfigService = this.BLLIocTool.Get<ICarHighTechConfigService>();
                }
                return _ICarHighTechConfigService;
            }
        }

        ICarImageService _ICarImageService;
        /// <summary>
        /// Car_Image(车辆图片表)表逻辑契约接口
        /// </summary>
        public ICarImageService ICarImageService
        {
            get
            {
                if (_ICarImageService == null)
                {
                    _ICarImageService = this.BLLIocTool.Get<ICarImageService>();
                }
                return _ICarImageService;
            }
        }

        ICarInternalConfigService _ICarInternalConfigService;
        /// <summary>
        /// Car_InternalConfig(内部配置)表逻辑契约接口
        /// </summary>
        public ICarInternalConfigService ICarInternalConfigService
        {
            get
            {
                if (_ICarInternalConfigService == null)
                {
                    _ICarInternalConfigService = this.BLLIocTool.Get<ICarInternalConfigService>();
                }
                return _ICarInternalConfigService;
            }
        }

        ICarlightsConfigService _ICarlightsConfigService;
        /// <summary>
        /// Car_lightsConfig(车辆灯光配置)表逻辑契约接口
        /// </summary>
        public ICarlightsConfigService ICarlightsConfigService
        {
            get
            {
                if (_ICarlightsConfigService == null)
                {
                    _ICarlightsConfigService = this.BLLIocTool.Get<ICarlightsConfigService>();
                }
                return _ICarlightsConfigService;
            }
        }

        ICarMainService _ICarMainService;
        /// <summary>
        /// Car_Main(车辆主表)表逻辑契约接口
        /// </summary>
        public ICarMainService ICarMainService
        {
            get
            {
                if (_ICarMainService == null)
                {
                    _ICarMainService = this.BLLIocTool.Get<ICarMainService>();
                }
                return _ICarMainService;
            }
        }

        ICarMainCommentService _ICarMainCommentService;
        /// <summary>
        /// Car_Main_Comment(车辆评论表)表逻辑契约接口
        /// </summary>
        public ICarMainCommentService ICarMainCommentService
        {
            get
            {
                if (_ICarMainCommentService == null)
                {
                    _ICarMainCommentService = this.BLLIocTool.Get<ICarMainCommentService>();
                }
                return _ICarMainCommentService;
            }
        }

        ICarMainImageService _ICarMainImageService;
        /// <summary>
        /// Car_Main_Image( )表逻辑契约接口
        /// </summary>
        public ICarMainImageService ICarMainImageService
        {
            get
            {
                if (_ICarMainImageService == null)
                {
                    _ICarMainImageService = this.BLLIocTool.Get<ICarMainImageService>();
                }
                return _ICarMainImageService;
            }
        }

        ICarMainVideoService _ICarMainVideoService;
        /// <summary>
        /// Car_Main_Video( )表逻辑契约接口
        /// </summary>
        public ICarMainVideoService ICarMainVideoService
        {
            get
            {
                if (_ICarMainVideoService == null)
                {
                    _ICarMainVideoService = this.BLLIocTool.Get<ICarMainVideoService>();
                }
                return _ICarMainVideoService;
            }
        }

        ICarMainItemService _ICarMainItemService;
        /// <summary>
        /// Car_MainItem(指定车辆表)表逻辑契约接口
        /// </summary>
        public ICarMainItemService ICarMainItemService
        {
            get
            {
                if (_ICarMainItemService == null)
                {
                    _ICarMainItemService = this.BLLIocTool.Get<ICarMainItemService>();
                }
                return _ICarMainItemService;
            }
        }

        ICarMainItemBaseService _ICarMainItemBaseService;
        /// <summary>
        /// Car_MainItem_Base(车辆基本参数)表逻辑契约接口
        /// </summary>
        public ICarMainItemBaseService ICarMainItemBaseService
        {
            get
            {
                if (_ICarMainItemBaseService == null)
                {
                    _ICarMainItemBaseService = this.BLLIocTool.Get<ICarMainItemBaseService>();
                }
                return _ICarMainItemBaseService;
            }
        }

        ICarMainItemBodyWorkService _ICarMainItemBodyWorkService;
        /// <summary>
        /// Car_MainItem_BodyWork(车辆车身参数)表逻辑契约接口
        /// </summary>
        public ICarMainItemBodyWorkService ICarMainItemBodyWorkService
        {
            get
            {
                if (_ICarMainItemBodyWorkService == null)
                {
                    _ICarMainItemBodyWorkService = this.BLLIocTool.Get<ICarMainItemBodyWorkService>();
                }
                return _ICarMainItemBodyWorkService;
            }
        }

        ICarMainItemBrakingOfWheelService _ICarMainItemBrakingOfWheelService;
        /// <summary>
        /// Car_MainItem_BrakingOfWheel(车轮制动参数)表逻辑契约接口
        /// </summary>
        public ICarMainItemBrakingOfWheelService ICarMainItemBrakingOfWheelService
        {
            get
            {
                if (_ICarMainItemBrakingOfWheelService == null)
                {
                    _ICarMainItemBrakingOfWheelService = this.BLLIocTool.Get<ICarMainItemBrakingOfWheelService>();
                }
                return _ICarMainItemBrakingOfWheelService;
            }
        }

        ICarMainItemChassisSteeringService _ICarMainItemChassisSteeringService;
        /// <summary>
        /// Car_MainItem_ChassisSteering(车辆底盘转向参数)表逻辑契约接口
        /// </summary>
        public ICarMainItemChassisSteeringService ICarMainItemChassisSteeringService
        {
            get
            {
                if (_ICarMainItemChassisSteeringService == null)
                {
                    _ICarMainItemChassisSteeringService = this.BLLIocTool.Get<ICarMainItemChassisSteeringService>();
                }
                return _ICarMainItemChassisSteeringService;
            }
        }

        ICarMainItemEngineService _ICarMainItemEngineService;
        /// <summary>
        /// Car_MainItem_Engine(车辆发动机参数)表逻辑契约接口
        /// </summary>
        public ICarMainItemEngineService ICarMainItemEngineService
        {
            get
            {
                if (_ICarMainItemEngineService == null)
                {
                    _ICarMainItemEngineService = this.BLLIocTool.Get<ICarMainItemEngineService>();
                }
                return _ICarMainItemEngineService;
            }
        }

        ICarMainItemGearBoxService _ICarMainItemGearBoxService;
        /// <summary>
        /// Car_MainItem_GearBox(车辆变速箱参数)表逻辑契约接口
        /// </summary>
        public ICarMainItemGearBoxService ICarMainItemGearBoxService
        {
            get
            {
                if (_ICarMainItemGearBoxService == null)
                {
                    _ICarMainItemGearBoxService = this.BLLIocTool.Get<ICarMainItemGearBoxService>();
                }
                return _ICarMainItemGearBoxService;
            }
        }

        ICarMainItemModelService _ICarMainItemModelService;
        /// <summary>
        /// Car_MainItem_Model(车型表)表逻辑契约接口
        /// </summary>
        public ICarMainItemModelService ICarMainItemModelService
        {
            get
            {
                if (_ICarMainItemModelService == null)
                {
                    _ICarMainItemModelService = this.BLLIocTool.Get<ICarMainItemModelService>();
                }
                return _ICarMainItemModelService;
            }
        }

        ICarMainItemSeriesService _ICarMainItemSeriesService;
        /// <summary>
        /// Car_MainItem_Series(车型系统表)表逻辑契约接口
        /// </summary>
        public ICarMainItemSeriesService ICarMainItemSeriesService
        {
            get
            {
                if (_ICarMainItemSeriesService == null)
                {
                    _ICarMainItemSeriesService = this.BLLIocTool.Get<ICarMainItemSeriesService>();
                }
                return _ICarMainItemSeriesService;
            }
        }

        ICarMainItemToExColorService _ICarMainItemToExColorService;
        /// <summary>
        /// Car_MainItemToExColor(车辆外观颜色关系表)表逻辑契约接口
        /// </summary>
        public ICarMainItemToExColorService ICarMainItemToExColorService
        {
            get
            {
                if (_ICarMainItemToExColorService == null)
                {
                    _ICarMainItemToExColorService = this.BLLIocTool.Get<ICarMainItemToExColorService>();
                }
                return _ICarMainItemToExColorService;
            }
        }

        ICarMainItemToInColorService _ICarMainItemToInColorService;
        /// <summary>
        /// Car_MainItemToInColor(车辆内观颜色关系表)表逻辑契约接口
        /// </summary>
        public ICarMainItemToInColorService ICarMainItemToInColorService
        {
            get
            {
                if (_ICarMainItemToInColorService == null)
                {
                    _ICarMainItemToInColorService = this.BLLIocTool.Get<ICarMainItemToInColorService>();
                }
                return _ICarMainItemToInColorService;
            }
        }

        ICarMainItemToModelService _ICarMainItemToModelService;
        /// <summary>
        /// Car_MainItemToModel(车辆与车型关系表)表逻辑契约接口
        /// </summary>
        public ICarMainItemToModelService ICarMainItemToModelService
        {
            get
            {
                if (_ICarMainItemToModelService == null)
                {
                    _ICarMainItemToModelService = this.BLLIocTool.Get<ICarMainItemToModelService>();
                }
                return _ICarMainItemToModelService;
            }
        }

        ICarMainToStoreMainRefService _ICarMainToStoreMainRefService;
        /// <summary>
        /// Car_MainToStore_MainRef(抽象关系表)表逻辑契约接口
        /// </summary>
        public ICarMainToStoreMainRefService ICarMainToStoreMainRefService
        {
            get
            {
                if (_ICarMainToStoreMainRefService == null)
                {
                    _ICarMainToStoreMainRefService = this.BLLIocTool.Get<ICarMainToStoreMainRefService>();
                }
                return _ICarMainToStoreMainRefService;
            }
        }

        ICarMultiMediaConfigService _ICarMultiMediaConfigService;
        /// <summary>
        /// Car_MultiMediaConfig(车辆多媒体配置)表逻辑契约接口
        /// </summary>
        public ICarMultiMediaConfigService ICarMultiMediaConfigService
        {
            get
            {
                if (_ICarMultiMediaConfigService == null)
                {
                    _ICarMultiMediaConfigService = this.BLLIocTool.Get<ICarMultiMediaConfigService>();
                }
                return _ICarMultiMediaConfigService;
            }
        }

        ICarOtherGoodCarService _ICarOtherGoodCarService;
        /// <summary>
        /// Car_OtherGoodCar(其它重磅好车表)表逻辑契约接口
        /// </summary>
        public ICarOtherGoodCarService ICarOtherGoodCarService
        {
            get
            {
                if (_ICarOtherGoodCarService == null)
                {
                    _ICarOtherGoodCarService = this.BLLIocTool.Get<ICarOtherGoodCarService>();
                }
                return _ICarOtherGoodCarService;
            }
        }

        ICarSeatConfigService _ICarSeatConfigService;
        /// <summary>
        /// Car_SeatConfig(座椅配置)表逻辑契约接口
        /// </summary>
        public ICarSeatConfigService ICarSeatConfigService
        {
            get
            {
                if (_ICarSeatConfigService == null)
                {
                    _ICarSeatConfigService = this.BLLIocTool.Get<ICarSeatConfigService>();
                }
                return _ICarSeatConfigService;
            }
        }

        ICarSecurityEquipService _ICarSecurityEquipService;
        /// <summary>
        /// Car_SecurityEquip(车辆安全装备)表逻辑契约接口
        /// </summary>
        public ICarSecurityEquipService ICarSecurityEquipService
        {
            get
            {
                if (_ICarSecurityEquipService == null)
                {
                    _ICarSecurityEquipService = this.BLLIocTool.Get<ICarSecurityEquipService>();
                }
                return _ICarSecurityEquipService;
            }
        }

        ICarWindowAndRearviewConfigService _ICarWindowAndRearviewConfigService;
        /// <summary>
        /// Car_WindowAndRearviewConfig(车辆玻璃/后视镜配置)表逻辑契约接口
        /// </summary>
        public ICarWindowAndRearviewConfigService ICarWindowAndRearviewConfigService
        {
            get
            {
                if (_ICarWindowAndRearviewConfigService == null)
                {
                    _ICarWindowAndRearviewConfigService = this.BLLIocTool.Get<ICarWindowAndRearviewConfigService>();
                }
                return _ICarWindowAndRearviewConfigService;
            }
        }

        ICategoryMainService _ICategoryMainService;
        /// <summary>
        /// Category_Main(分类表)表逻辑契约接口
        /// </summary>
        public ICategoryMainService ICategoryMainService
        {
            get
            {
                if (_ICategoryMainService == null)
                {
                    _ICategoryMainService = this.BLLIocTool.Get<ICategoryMainService>();
                }
                return _ICategoryMainService;
            }
        }

        IComAbstractLeftTableService _IComAbstractLeftTableService;
        /// <summary>
        /// Com_AbstractLeftTable(抽象左表)表逻辑契约接口
        /// </summary>
        public IComAbstractLeftTableService IComAbstractLeftTableService
        {
            get
            {
                if (_IComAbstractLeftTableService == null)
                {
                    _IComAbstractLeftTableService = this.BLLIocTool.Get<IComAbstractLeftTableService>();
                }
                return _IComAbstractLeftTableService;
            }
        }

        IComAbstractLeftTableToRightTableRefService _IComAbstractLeftTableToRightTableRefService;
        /// <summary>
        /// Com_AbstractLeftTableToRightTableRef(抽象关系表)表逻辑契约接口
        /// </summary>
        public IComAbstractLeftTableToRightTableRefService IComAbstractLeftTableToRightTableRefService
        {
            get
            {
                if (_IComAbstractLeftTableToRightTableRefService == null)
                {
                    _IComAbstractLeftTableToRightTableRefService = this.BLLIocTool.Get<IComAbstractLeftTableToRightTableRefService>();
                }
                return _IComAbstractLeftTableToRightTableRefService;
            }
        }

        IComAbstractRightTableService _IComAbstractRightTableService;
        /// <summary>
        /// Com_AbstractRightTable(抽象右表)表逻辑契约接口
        /// </summary>
        public IComAbstractRightTableService IComAbstractRightTableService
        {
            get
            {
                if (_IComAbstractRightTableService == null)
                {
                    _IComAbstractRightTableService = this.BLLIocTool.Get<IComAbstractRightTableService>();
                }
                return _IComAbstractRightTableService;
            }
        }

        IComClickService _IComClickService;
        /// <summary>
        /// Com_Click(点击表)表逻辑契约接口
        /// </summary>
        public IComClickService IComClickService
        {
            get
            {
                if (_IComClickService == null)
                {
                    _IComClickService = this.BLLIocTool.Get<IComClickService>();
                }
                return _IComClickService;
            }
        }

        IComConfigMainService _IComConfigMainService;
        /// <summary>
        /// Com_ConfigMain(通用配置表)表逻辑契约接口
        /// </summary>
        public IComConfigMainService IComConfigMainService
        {
            get
            {
                if (_IComConfigMainService == null)
                {
                    _IComConfigMainService = this.BLLIocTool.Get<IComConfigMainService>();
                }
                return _IComConfigMainService;
            }
        }

        IComCountService _IComCountService;
        /// <summary>
        /// Com_Count(独立计数器主表)表逻辑契约接口
        /// </summary>
        public IComCountService IComCountService
        {
            get
            {
                if (_IComCountService == null)
                {
                    _IComCountService = this.BLLIocTool.Get<IComCountService>();
                }
                return _IComCountService;
            }
        }

        IComDisplayInfoService _IComDisplayInfoService;
        /// <summary>
        /// Com_DisplayInfo(通用展示信息关联表)表逻辑契约接口
        /// </summary>
        public IComDisplayInfoService IComDisplayInfoService
        {
            get
            {
                if (_IComDisplayInfoService == null)
                {
                    _IComDisplayInfoService = this.BLLIocTool.Get<IComDisplayInfoService>();
                }
                return _IComDisplayInfoService;
            }
        }

        IComDisplayTypeService _IComDisplayTypeService;
        /// <summary>
        /// Com_DisplayType(通用展示类型表)表逻辑契约接口
        /// </summary>
        public IComDisplayTypeService IComDisplayTypeService
        {
            get
            {
                if (_IComDisplayTypeService == null)
                {
                    _IComDisplayTypeService = this.BLLIocTool.Get<IComDisplayTypeService>();
                }
                return _IComDisplayTypeService;
            }
        }

        IComMaxIdService _IComMaxIdService;
        /// <summary>
        /// Com_MaxId(通用生成无重复数据值表)表逻辑契约接口
        /// </summary>
        public IComMaxIdService IComMaxIdService
        {
            get
            {
                if (_IComMaxIdService == null)
                {
                    _IComMaxIdService = this.BLLIocTool.Get<IComMaxIdService>();
                }
                return _IComMaxIdService;
            }
        }

        IComObjectToTagService _IComObjectToTagService;
        /// <summary>
        /// Com_ObjectToTag(对象关联标签表)表逻辑契约接口
        /// </summary>
        public IComObjectToTagService IComObjectToTagService
        {
            get
            {
                if (_IComObjectToTagService == null)
                {
                    _IComObjectToTagService = this.BLLIocTool.Get<IComObjectToTagService>();
                }
                return _IComObjectToTagService;
            }
        }

        IComSiteObjectToTagService _IComSiteObjectToTagService;
        /// <summary>
        /// Com_SiteObjectToTag(对象关联标签表)表逻辑契约接口
        /// </summary>
        public IComSiteObjectToTagService IComSiteObjectToTagService
        {
            get
            {
                if (_IComSiteObjectToTagService == null)
                {
                    _IComSiteObjectToTagService = this.BLLIocTool.Get<IComSiteObjectToTagService>();
                }
                return _IComSiteObjectToTagService;
            }
        }

        IComTagService _IComTagService;
        /// <summary>
        /// Com_Tag(标签表)表逻辑契约接口
        /// </summary>
        public IComTagService IComTagService
        {
            get
            {
                if (_IComTagService == null)
                {
                    _IComTagService = this.BLLIocTool.Get<IComTagService>();
                }
                return _IComTagService;
            }
        }

        ICommonAddressAreaService _ICommonAddressAreaService;
        /// <summary>
        /// Common_Address_Area(镇级)表逻辑契约接口
        /// </summary>
        public ICommonAddressAreaService ICommonAddressAreaService
        {
            get
            {
                if (_ICommonAddressAreaService == null)
                {
                    _ICommonAddressAreaService = this.BLLIocTool.Get<ICommonAddressAreaService>();
                }
                return _ICommonAddressAreaService;
            }
        }

        ICommonAddressCityService _ICommonAddressCityService;
        /// <summary>
        /// Common_Address_City(市区)表逻辑契约接口
        /// </summary>
        public ICommonAddressCityService ICommonAddressCityService
        {
            get
            {
                if (_ICommonAddressCityService == null)
                {
                    _ICommonAddressCityService = this.BLLIocTool.Get<ICommonAddressCityService>();
                }
                return _ICommonAddressCityService;
            }
        }

        ICommonAddressProvinceService _ICommonAddressProvinceService;
        /// <summary>
        /// Common_Address_Province(省份)表逻辑契约接口
        /// </summary>
        public ICommonAddressProvinceService ICommonAddressProvinceService
        {
            get
            {
                if (_ICommonAddressProvinceService == null)
                {
                    _ICommonAddressProvinceService = this.BLLIocTool.Get<ICommonAddressProvinceService>();
                }
                return _ICommonAddressProvinceService;
            }
        }

        ICommonUploadsService _ICommonUploadsService;
        /// <summary>
        /// Common_Uploads()表逻辑契约接口
        /// </summary>
        public ICommonUploadsService ICommonUploadsService
        {
            get
            {
                if (_ICommonUploadsService == null)
                {
                    _ICommonUploadsService = this.BLLIocTool.Get<ICommonUploadsService>();
                }
                return _ICommonUploadsService;
            }
        }

        IConfigHotCityService _IConfigHotCityService;
        /// <summary>
        /// Config_HotCity(热门城市)表逻辑契约接口
        /// </summary>
        public IConfigHotCityService IConfigHotCityService
        {
            get
            {
                if (_IConfigHotCityService == null)
                {
                    _IConfigHotCityService = this.BLLIocTool.Get<IConfigHotCityService>();
                }
                return _IConfigHotCityService;
            }
        }

        ICWXExplorationActivityMainService _ICWXExplorationActivityMainService;
        /// <summary>
        /// CWX_ExplorationActivity_Main(活动表)表逻辑契约接口
        /// </summary>
        public ICWXExplorationActivityMainService ICWXExplorationActivityMainService
        {
            get
            {
                if (_ICWXExplorationActivityMainService == null)
                {
                    _ICWXExplorationActivityMainService = this.BLLIocTool.Get<ICWXExplorationActivityMainService>();
                }
                return _ICWXExplorationActivityMainService;
            }
        }

        ICWXExplorationActivityOrderUserService _ICWXExplorationActivityOrderUserService;
        /// <summary>
        /// CWX_ExplorationActivity_OrderUser(活动表)表逻辑契约接口
        /// </summary>
        public ICWXExplorationActivityOrderUserService ICWXExplorationActivityOrderUserService
        {
            get
            {
                if (_ICWXExplorationActivityOrderUserService == null)
                {
                    _ICWXExplorationActivityOrderUserService = this.BLLIocTool.Get<ICWXExplorationActivityOrderUserService>();
                }
                return _ICWXExplorationActivityOrderUserService;
            }
        }

        ICWXLotteryHistoryService _ICWXLotteryHistoryService;
        /// <summary>
        /// CWX_LotteryHistory(活动抽奖历史表)表逻辑契约接口
        /// </summary>
        public ICWXLotteryHistoryService ICWXLotteryHistoryService
        {
            get
            {
                if (_ICWXLotteryHistoryService == null)
                {
                    _ICWXLotteryHistoryService = this.BLLIocTool.Get<ICWXLotteryHistoryService>();
                }
                return _ICWXLotteryHistoryService;
            }
        }

        ICWXLotteryMainService _ICWXLotteryMainService;
        /// <summary>
        /// CWX_LotteryMain(活动表)表逻辑契约接口
        /// </summary>
        public ICWXLotteryMainService ICWXLotteryMainService
        {
            get
            {
                if (_ICWXLotteryMainService == null)
                {
                    _ICWXLotteryMainService = this.BLLIocTool.Get<ICWXLotteryMainService>();
                }
                return _ICWXLotteryMainService;
            }
        }

        ICWXLotteryPrizeService _ICWXLotteryPrizeService;
        /// <summary>
        /// CWX_LotteryPrize(活动奖品表)表逻辑契约接口
        /// </summary>
        public ICWXLotteryPrizeService ICWXLotteryPrizeService
        {
            get
            {
                if (_ICWXLotteryPrizeService == null)
                {
                    _ICWXLotteryPrizeService = this.BLLIocTool.Get<ICWXLotteryPrizeService>();
                }
                return _ICWXLotteryPrizeService;
            }
        }

        ICWXLotteryUserPrizeService _ICWXLotteryUserPrizeService;
        /// <summary>
        /// CWX_LotteryUserPrize(活动中奖人员表)表逻辑契约接口
        /// </summary>
        public ICWXLotteryUserPrizeService ICWXLotteryUserPrizeService
        {
            get
            {
                if (_ICWXLotteryUserPrizeService == null)
                {
                    _ICWXLotteryUserPrizeService = this.BLLIocTool.Get<ICWXLotteryUserPrizeService>();
                }
                return _ICWXLotteryUserPrizeService;
            }
        }

        ICWXRepairOrderService _ICWXRepairOrderService;
        /// <summary>
        /// CWX_RepairOrder()表逻辑契约接口
        /// </summary>
        public ICWXRepairOrderService ICWXRepairOrderService
        {
            get
            {
                if (_ICWXRepairOrderService == null)
                {
                    _ICWXRepairOrderService = this.BLLIocTool.Get<ICWXRepairOrderService>();
                }
                return _ICWXRepairOrderService;
            }
        }

        ICWXWeiXinApplicationService _ICWXWeiXinApplicationService;
        /// <summary>
        /// CWX_WeiXinApplication(微信程序信息表)表逻辑契约接口
        /// </summary>
        public ICWXWeiXinApplicationService ICWXWeiXinApplicationService
        {
            get
            {
                if (_ICWXWeiXinApplicationService == null)
                {
                    _ICWXWeiXinApplicationService = this.BLLIocTool.Get<ICWXWeiXinApplicationService>();
                }
                return _ICWXWeiXinApplicationService;
            }
        }

        ICWXWeiXinMenuService _ICWXWeiXinMenuService;
        /// <summary>
        /// CWX_WeiXinMenu(微信菜单表)表逻辑契约接口
        /// </summary>
        public ICWXWeiXinMenuService ICWXWeiXinMenuService
        {
            get
            {
                if (_ICWXWeiXinMenuService == null)
                {
                    _ICWXWeiXinMenuService = this.BLLIocTool.Get<ICWXWeiXinMenuService>();
                }
                return _ICWXWeiXinMenuService;
            }
        }

        IDisplayHomePriceChartService _IDisplayHomePriceChartService;
        /// <summary>
        /// Display_HomePriceChart(首页报价表)表逻辑契约接口
        /// </summary>
        public IDisplayHomePriceChartService IDisplayHomePriceChartService
        {
            get
            {
                if (_IDisplayHomePriceChartService == null)
                {
                    _IDisplayHomePriceChartService = this.BLLIocTool.Get<IDisplayHomePriceChartService>();
                }
                return _IDisplayHomePriceChartService;
            }
        }

        IDisplayHomePriceChartDistributorAdvertService _IDisplayHomePriceChartDistributorAdvertService;
        /// <summary>
        /// Display_HomePriceChartDistributorAdvert(首页报价经销商广告表)表逻辑契约接口
        /// </summary>
        public IDisplayHomePriceChartDistributorAdvertService IDisplayHomePriceChartDistributorAdvertService
        {
            get
            {
                if (_IDisplayHomePriceChartDistributorAdvertService == null)
                {
                    _IDisplayHomePriceChartDistributorAdvertService = this.BLLIocTool.Get<IDisplayHomePriceChartDistributorAdvertService>();
                }
                return _IDisplayHomePriceChartDistributorAdvertService;
            }
        }

        IDisplayHomePriceChartTypeService _IDisplayHomePriceChartTypeService;
        /// <summary>
        /// Display_HomePriceChartType(首页报价类型表)表逻辑契约接口
        /// </summary>
        public IDisplayHomePriceChartTypeService IDisplayHomePriceChartTypeService
        {
            get
            {
                if (_IDisplayHomePriceChartTypeService == null)
                {
                    _IDisplayHomePriceChartTypeService = this.BLLIocTool.Get<IDisplayHomePriceChartTypeService>();
                }
                return _IDisplayHomePriceChartTypeService;
            }
        }

        IDisplayIndexAdvertService _IDisplayIndexAdvertService;
        /// <summary>
        /// Display_IndexAdvert(首页广告)表逻辑契约接口
        /// </summary>
        public IDisplayIndexAdvertService IDisplayIndexAdvertService
        {
            get
            {
                if (_IDisplayIndexAdvertService == null)
                {
                    _IDisplayIndexAdvertService = this.BLLIocTool.Get<IDisplayIndexAdvertService>();
                }
                return _IDisplayIndexAdvertService;
            }
        }

        IDisplayPhotoAlbumsService _IDisplayPhotoAlbumsService;
        /// <summary>
        /// Display_PhotoAlbums(相册表)表逻辑契约接口
        /// </summary>
        public IDisplayPhotoAlbumsService IDisplayPhotoAlbumsService
        {
            get
            {
                if (_IDisplayPhotoAlbumsService == null)
                {
                    _IDisplayPhotoAlbumsService = this.BLLIocTool.Get<IDisplayPhotoAlbumsService>();
                }
                return _IDisplayPhotoAlbumsService;
            }
        }

        IDisplayPhotoAlbumsToPhotosService _IDisplayPhotoAlbumsToPhotosService;
        /// <summary>
        /// Display_PhotoAlbumsToPhotos(相册表)表逻辑契约接口
        /// </summary>
        public IDisplayPhotoAlbumsToPhotosService IDisplayPhotoAlbumsToPhotosService
        {
            get
            {
                if (_IDisplayPhotoAlbumsToPhotosService == null)
                {
                    _IDisplayPhotoAlbumsToPhotosService = this.BLLIocTool.Get<IDisplayPhotoAlbumsToPhotosService>();
                }
                return _IDisplayPhotoAlbumsToPhotosService;
            }
        }

        IDisplayPhotoAlbumsTypeService _IDisplayPhotoAlbumsTypeService;
        /// <summary>
        /// Display_PhotoAlbumsType(相册类型表)表逻辑契约接口
        /// </summary>
        public IDisplayPhotoAlbumsTypeService IDisplayPhotoAlbumsTypeService
        {
            get
            {
                if (_IDisplayPhotoAlbumsTypeService == null)
                {
                    _IDisplayPhotoAlbumsTypeService = this.BLLIocTool.Get<IDisplayPhotoAlbumsTypeService>();
                }
                return _IDisplayPhotoAlbumsTypeService;
            }
        }

        IdtAdbannerService _IdtAdbannerService;
        /// <summary>
        /// dt_Adbanner()表逻辑契约接口
        /// </summary>
        public IdtAdbannerService IdtAdbannerService
        {
            get
            {
                if (_IdtAdbannerService == null)
                {
                    _IdtAdbannerService = this.BLLIocTool.Get<IdtAdbannerService>();
                }
                return _IdtAdbannerService;
            }
        }

        IdtAdministratorService _IdtAdministratorService;
        /// <summary>
        /// dt_Administrator()表逻辑契约接口
        /// </summary>
        public IdtAdministratorService IdtAdministratorService
        {
            get
            {
                if (_IdtAdministratorService == null)
                {
                    _IdtAdministratorService = this.BLLIocTool.Get<IdtAdministratorService>();
                }
                return _IdtAdministratorService;
            }
        }

        IdtAdvertisingService _IdtAdvertisingService;
        /// <summary>
        /// dt_Advertising()表逻辑契约接口
        /// </summary>
        public IdtAdvertisingService IdtAdvertisingService
        {
            get
            {
                if (_IdtAdvertisingService == null)
                {
                    _IdtAdvertisingService = this.BLLIocTool.Get<IdtAdvertisingService>();
                }
                return _IdtAdvertisingService;
            }
        }

        IdtAllReviewsService _IdtAllReviewsService;
        /// <summary>
        /// dt_AllReviews()表逻辑契约接口
        /// </summary>
        public IdtAllReviewsService IdtAllReviewsService
        {
            get
            {
                if (_IdtAllReviewsService == null)
                {
                    _IdtAllReviewsService = this.BLLIocTool.Get<IdtAllReviewsService>();
                }
                return _IdtAllReviewsService;
            }
        }

        IdtArticleService _IdtArticleService;
        /// <summary>
        /// dt_Article()表逻辑契约接口
        /// </summary>
        public IdtArticleService IdtArticleService
        {
            get
            {
                if (_IdtArticleService == null)
                {
                    _IdtArticleService = this.BLLIocTool.Get<IdtArticleService>();
                }
                return _IdtArticleService;
            }
        }

        IdtChannelService _IdtChannelService;
        /// <summary>
        /// dt_Channel()表逻辑契约接口
        /// </summary>
        public IdtChannelService IdtChannelService
        {
            get
            {
                if (_IdtChannelService == null)
                {
                    _IdtChannelService = this.BLLIocTool.Get<IdtChannelService>();
                }
                return _IdtChannelService;
            }
        }

        IdtContentsService _IdtContentsService;
        /// <summary>
        /// dt_Contents()表逻辑契约接口
        /// </summary>
        public IdtContentsService IdtContentsService
        {
            get
            {
                if (_IdtContentsService == null)
                {
                    _IdtContentsService = this.BLLIocTool.Get<IdtContentsService>();
                }
                return _IdtContentsService;
            }
        }

        IdtDownloadsService _IdtDownloadsService;
        /// <summary>
        /// dt_Downloads()表逻辑契约接口
        /// </summary>
        public IdtDownloadsService IdtDownloadsService
        {
            get
            {
                if (_IdtDownloadsService == null)
                {
                    _IdtDownloadsService = this.BLLIocTool.Get<IdtDownloadsService>();
                }
                return _IdtDownloadsService;
            }
        }

        IdtFeedbackService _IdtFeedbackService;
        /// <summary>
        /// dt_Feedback()表逻辑契约接口
        /// </summary>
        public IdtFeedbackService IdtFeedbackService
        {
            get
            {
                if (_IdtFeedbackService == null)
                {
                    _IdtFeedbackService = this.BLLIocTool.Get<IdtFeedbackService>();
                }
                return _IdtFeedbackService;
            }
        }

        IdtLinksService _IdtLinksService;
        /// <summary>
        /// dt_Links()表逻辑契约接口
        /// </summary>
        public IdtLinksService IdtLinksService
        {
            get
            {
                if (_IdtLinksService == null)
                {
                    _IdtLinksService = this.BLLIocTool.Get<IdtLinksService>();
                }
                return _IdtLinksService;
            }
        }

        IdtMessageCountStaticService _IdtMessageCountStaticService;
        /// <summary>
        /// dt_MessageCountStatic()表逻辑契约接口
        /// </summary>
        public IdtMessageCountStaticService IdtMessageCountStaticService
        {
            get
            {
                if (_IdtMessageCountStaticService == null)
                {
                    _IdtMessageCountStaticService = this.BLLIocTool.Get<IdtMessageCountStaticService>();
                }
                return _IdtMessageCountStaticService;
            }
        }

        IdtPicturesService _IdtPicturesService;
        /// <summary>
        /// dt_Pictures()表逻辑契约接口
        /// </summary>
        public IdtPicturesService IdtPicturesService
        {
            get
            {
                if (_IdtPicturesService == null)
                {
                    _IdtPicturesService = this.BLLIocTool.Get<IdtPicturesService>();
                }
                return _IdtPicturesService;
            }
        }

        IdtPicturesAlbumService _IdtPicturesAlbumService;
        /// <summary>
        /// dt_PicturesAlbum()表逻辑契约接口
        /// </summary>
        public IdtPicturesAlbumService IdtPicturesAlbumService
        {
            get
            {
                if (_IdtPicturesAlbumService == null)
                {
                    _IdtPicturesAlbumService = this.BLLIocTool.Get<IdtPicturesAlbumService>();
                }
                return _IdtPicturesAlbumService;
            }
        }

        IdtPicturesExtensionService _IdtPicturesExtensionService;
        /// <summary>
        /// dt_PicturesExtension()表逻辑契约接口
        /// </summary>
        public IdtPicturesExtensionService IdtPicturesExtensionService
        {
            get
            {
                if (_IdtPicturesExtensionService == null)
                {
                    _IdtPicturesExtensionService = this.BLLIocTool.Get<IdtPicturesExtensionService>();
                }
                return _IdtPicturesExtensionService;
            }
        }

        IdtPicturesFieldService _IdtPicturesFieldService;
        /// <summary>
        /// dt_PicturesField()表逻辑契约接口
        /// </summary>
        public IdtPicturesFieldService IdtPicturesFieldService
        {
            get
            {
                if (_IdtPicturesFieldService == null)
                {
                    _IdtPicturesFieldService = this.BLLIocTool.Get<IdtPicturesFieldService>();
                }
                return _IdtPicturesFieldService;
            }
        }

        IdtSystemLogService _IdtSystemLogService;
        /// <summary>
        /// dt_SystemLog()表逻辑契约接口
        /// </summary>
        public IdtSystemLogService IdtSystemLogService
        {
            get
            {
                if (_IdtSystemLogService == null)
                {
                    _IdtSystemLogService = this.BLLIocTool.Get<IdtSystemLogService>();
                }
                return _IdtSystemLogService;
            }
        }

        ILeagueInfoService _ILeagueInfoService;
        /// <summary>
        /// LeagueInfo()表逻辑契约接口
        /// </summary>
        public ILeagueInfoService ILeagueInfoService
        {
            get
            {
                if (_ILeagueInfoService == null)
                {
                    _ILeagueInfoService = this.BLLIocTool.Get<ILeagueInfoService>();
                }
                return _ILeagueInfoService;
            }
        }

        IMaintImageService _IMaintImageService;
        /// <summary>
        /// Maint_Image()表逻辑契约接口
        /// </summary>
        public IMaintImageService IMaintImageService
        {
            get
            {
                if (_IMaintImageService == null)
                {
                    _IMaintImageService = this.BLLIocTool.Get<IMaintImageService>();
                }
                return _IMaintImageService;
            }
        }

        IMaintMainService _IMaintMainService;
        /// <summary>
        /// Maint_Main()表逻辑契约接口
        /// </summary>
        public IMaintMainService IMaintMainService
        {
            get
            {
                if (_IMaintMainService == null)
                {
                    _IMaintMainService = this.BLLIocTool.Get<IMaintMainService>();
                }
                return _IMaintMainService;
            }
        }

        IMaintMaintItemService _IMaintMaintItemService;
        /// <summary>
        /// Maint_MaintItem()表逻辑契约接口
        /// </summary>
        public IMaintMaintItemService IMaintMaintItemService
        {
            get
            {
                if (_IMaintMaintItemService == null)
                {
                    _IMaintMaintItemService = this.BLLIocTool.Get<IMaintMaintItemService>();
                }
                return _IMaintMaintItemService;
            }
        }

        IMallAdvertisementService _IMallAdvertisementService;
        /// <summary>
        /// Mall_Advertisement()表逻辑契约接口
        /// </summary>
        public IMallAdvertisementService IMallAdvertisementService
        {
            get
            {
                if (_IMallAdvertisementService == null)
                {
                    _IMallAdvertisementService = this.BLLIocTool.Get<IMallAdvertisementService>();
                }
                return _IMallAdvertisementService;
            }
        }

        IMallGoodsService _IMallGoodsService;
        /// <summary>
        /// Mall_Goods()表逻辑契约接口
        /// </summary>
        public IMallGoodsService IMallGoodsService
        {
            get
            {
                if (_IMallGoodsService == null)
                {
                    _IMallGoodsService = this.BLLIocTool.Get<IMallGoodsService>();
                }
                return _IMallGoodsService;
            }
        }

        IMallGoodsImgService _IMallGoodsImgService;
        /// <summary>
        /// Mall_GoodsImg()表逻辑契约接口
        /// </summary>
        public IMallGoodsImgService IMallGoodsImgService
        {
            get
            {
                if (_IMallGoodsImgService == null)
                {
                    _IMallGoodsImgService = this.BLLIocTool.Get<IMallGoodsImgService>();
                }
                return _IMallGoodsImgService;
            }
        }

        IMemberAccountService _IMemberAccountService;
        /// <summary>
        /// Member_Account(会员账号信息)表逻辑契约接口
        /// </summary>
        public IMemberAccountService IMemberAccountService
        {
            get
            {
                if (_IMemberAccountService == null)
                {
                    _IMemberAccountService = this.BLLIocTool.Get<IMemberAccountService>();
                }
                return _IMemberAccountService;
            }
        }

        IMemberCarInfoService _IMemberCarInfoService;
        /// <summary>
        /// Member_CarInfo(会员车辆信息)表逻辑契约接口
        /// </summary>
        public IMemberCarInfoService IMemberCarInfoService
        {
            get
            {
                if (_IMemberCarInfoService == null)
                {
                    _IMemberCarInfoService = this.BLLIocTool.Get<IMemberCarInfoService>();
                }
                return _IMemberCarInfoService;
            }
        }

        IMemberEmailUpdateHistoryService _IMemberEmailUpdateHistoryService;
        /// <summary>
        /// Member_EmailUpdateHistory(会员账号信息)表逻辑契约接口
        /// </summary>
        public IMemberEmailUpdateHistoryService IMemberEmailUpdateHistoryService
        {
            get
            {
                if (_IMemberEmailUpdateHistoryService == null)
                {
                    _IMemberEmailUpdateHistoryService = this.BLLIocTool.Get<IMemberEmailUpdateHistoryService>();
                }
                return _IMemberEmailUpdateHistoryService;
            }
        }

        IMemberProfileService _IMemberProfileService;
        /// <summary>
        /// Member_Profile(会员资料表)表逻辑契约接口
        /// </summary>
        public IMemberProfileService IMemberProfileService
        {
            get
            {
                if (_IMemberProfileService == null)
                {
                    _IMemberProfileService = this.BLLIocTool.Get<IMemberProfileService>();
                }
                return _IMemberProfileService;
            }
        }

        IMemberProfileToSiteService _IMemberProfileToSiteService;
        /// <summary>
        /// Member_ProfileToSite(会员开通站点信息)表逻辑契约接口
        /// </summary>
        public IMemberProfileToSiteService IMemberProfileToSiteService
        {
            get
            {
                if (_IMemberProfileToSiteService == null)
                {
                    _IMemberProfileToSiteService = this.BLLIocTool.Get<IMemberProfileToSiteService>();
                }
                return _IMemberProfileToSiteService;
            }
        }

        IMemberProfileToSiteCarService _IMemberProfileToSiteCarService;
        /// <summary>
        /// Member_ProfileToSiteCar()表逻辑契约接口
        /// </summary>
        public IMemberProfileToSiteCarService IMemberProfileToSiteCarService
        {
            get
            {
                if (_IMemberProfileToSiteCarService == null)
                {
                    _IMemberProfileToSiteCarService = this.BLLIocTool.Get<IMemberProfileToSiteCarService>();
                }
                return _IMemberProfileToSiteCarService;
            }
        }

        IMemberMessageService _IMemberMessageService;
        /// <summary>
        /// MemberMessage()表逻辑契约接口
        /// </summary>
        public IMemberMessageService IMemberMessageService
        {
            get
            {
                if (_IMemberMessageService == null)
                {
                    _IMemberMessageService = this.BLLIocTool.Get<IMemberMessageService>();
                }
                return _IMemberMessageService;
            }
        }

        IMemberMessageReciverService _IMemberMessageReciverService;
        /// <summary>
        /// MemberMessageReciver()表逻辑契约接口
        /// </summary>
        public IMemberMessageReciverService IMemberMessageReciverService
        {
            get
            {
                if (_IMemberMessageReciverService == null)
                {
                    _IMemberMessageReciverService = this.BLLIocTool.Get<IMemberMessageReciverService>();
                }
                return _IMemberMessageReciverService;
            }
        }

        IPluginsDataRefService _IPluginsDataRefService;
        /// <summary>
        /// Plugins_Data_Ref(第三方数据映射表)表逻辑契约接口
        /// </summary>
        public IPluginsDataRefService IPluginsDataRefService
        {
            get
            {
                if (_IPluginsDataRefService == null)
                {
                    _IPluginsDataRefService = this.BLLIocTool.Get<IPluginsDataRefService>();
                }
                return _IPluginsDataRefService;
            }
        }

        IPrestigeImpressionService _IPrestigeImpressionService;
        /// <summary>
        /// Prestige_Impression(口啤印象表)表逻辑契约接口
        /// </summary>
        public IPrestigeImpressionService IPrestigeImpressionService
        {
            get
            {
                if (_IPrestigeImpressionService == null)
                {
                    _IPrestigeImpressionService = this.BLLIocTool.Get<IPrestigeImpressionService>();
                }
                return _IPrestigeImpressionService;
            }
        }

        IPrestigePostService _IPrestigePostService;
        /// <summary>
        /// Prestige_Post(车辆口碑帖子)表逻辑契约接口
        /// </summary>
        public IPrestigePostService IPrestigePostService
        {
            get
            {
                if (_IPrestigePostService == null)
                {
                    _IPrestigePostService = this.BLLIocTool.Get<IPrestigePostService>();
                }
                return _IPrestigePostService;
            }
        }

        IPrestigePostCollectionService _IPrestigePostCollectionService;
        /// <summary>
        /// Prestige_PostCollection(口碑收藏表)表逻辑契约接口
        /// </summary>
        public IPrestigePostCollectionService IPrestigePostCollectionService
        {
            get
            {
                if (_IPrestigePostCollectionService == null)
                {
                    _IPrestigePostCollectionService = this.BLLIocTool.Get<IPrestigePostCollectionService>();
                }
                return _IPrestigePostCollectionService;
            }
        }

        IPrestigePostImageService _IPrestigePostImageService;
        /// <summary>
        /// Prestige_PostImage(口碑图片表)表逻辑契约接口
        /// </summary>
        public IPrestigePostImageService IPrestigePostImageService
        {
            get
            {
                if (_IPrestigePostImageService == null)
                {
                    _IPrestigePostImageService = this.BLLIocTool.Get<IPrestigePostImageService>();
                }
                return _IPrestigePostImageService;
            }
        }

        IPromotionActivityService _IPromotionActivityService;
        /// <summary>
        /// Promotion_Activity()表逻辑契约接口
        /// </summary>
        public IPromotionActivityService IPromotionActivityService
        {
            get
            {
                if (_IPromotionActivityService == null)
                {
                    _IPromotionActivityService = this.BLLIocTool.Get<IPromotionActivityService>();
                }
                return _IPromotionActivityService;
            }
        }

        IPromotionActivityToCarSalesPromitionService _IPromotionActivityToCarSalesPromitionService;
        /// <summary>
        /// Promotion_Activity_To_CarSalesPromition()表逻辑契约接口
        /// </summary>
        public IPromotionActivityToCarSalesPromitionService IPromotionActivityToCarSalesPromitionService
        {
            get
            {
                if (_IPromotionActivityToCarSalesPromitionService == null)
                {
                    _IPromotionActivityToCarSalesPromitionService = this.BLLIocTool.Get<IPromotionActivityToCarSalesPromitionService>();
                }
                return _IPromotionActivityToCarSalesPromitionService;
            }
        }

        IRepairOrdersService _IRepairOrdersService;
        /// <summary>
        /// Repair_Orders(维修消费记录)表逻辑契约接口
        /// </summary>
        public IRepairOrdersService IRepairOrdersService
        {
            get
            {
                if (_IRepairOrdersService == null)
                {
                    _IRepairOrdersService = this.BLLIocTool.Get<IRepairOrdersService>();
                }
                return _IRepairOrdersService;
            }
        }

        IRepairSetService _IRepairSetService;
        /// <summary>
        /// Repair_Set(维修套餐表)表逻辑契约接口
        /// </summary>
        public IRepairSetService IRepairSetService
        {
            get
            {
                if (_IRepairSetService == null)
                {
                    _IRepairSetService = this.BLLIocTool.Get<IRepairSetService>();
                }
                return _IRepairSetService;
            }
        }

        IRepairSetTodtFeedbackService _IRepairSetTodtFeedbackService;
        /// <summary>
        /// Repair_SetTodt_Feedback(维修套餐预约关系表)表逻辑契约接口
        /// </summary>
        public IRepairSetTodtFeedbackService IRepairSetTodtFeedbackService
        {
            get
            {
                if (_IRepairSetTodtFeedbackService == null)
                {
                    _IRepairSetTodtFeedbackService = this.BLLIocTool.Get<IRepairSetTodtFeedbackService>();
                }
                return _IRepairSetTodtFeedbackService;
            }
        }

        IRepairSetToTCarServiceService _IRepairSetToTCarServiceService;
        /// <summary>
        /// Repair_SetToT_CarService(维修套餐对维修工时表)表逻辑契约接口
        /// </summary>
        public IRepairSetToTCarServiceService IRepairSetToTCarServiceService
        {
            get
            {
                if (_IRepairSetToTCarServiceService == null)
                {
                    _IRepairSetToTCarServiceService = this.BLLIocTool.Get<IRepairSetToTCarServiceService>();
                }
                return _IRepairSetToTCarServiceService;
            }
        }

        IRepairSetToTCounterPartService _IRepairSetToTCounterPartService;
        /// <summary>
        /// Repair_SetToT_CounterPart(维修套餐对维修配件表)表逻辑契约接口
        /// </summary>
        public IRepairSetToTCounterPartService IRepairSetToTCounterPartService
        {
            get
            {
                if (_IRepairSetToTCounterPartService == null)
                {
                    _IRepairSetToTCounterPartService = this.BLLIocTool.Get<IRepairSetToTCounterPartService>();
                }
                return _IRepairSetToTCounterPartService;
            }
        }

        IRepairSetTripDistanceService _IRepairSetTripDistanceService;
        /// <summary>
        /// Repair_SetTripDistance(维修套餐行驶里程表)表逻辑契约接口
        /// </summary>
        public IRepairSetTripDistanceService IRepairSetTripDistanceService
        {
            get
            {
                if (_IRepairSetTripDistanceService == null)
                {
                    _IRepairSetTripDistanceService = this.BLLIocTool.Get<IRepairSetTripDistanceService>();
                }
                return _IRepairSetTripDistanceService;
            }
        }

        IRepairSetTripTimeService _IRepairSetTripTimeService;
        /// <summary>
        /// Repair_SetTripTime(维修套餐行驶时间表)表逻辑契约接口
        /// </summary>
        public IRepairSetTripTimeService IRepairSetTripTimeService
        {
            get
            {
                if (_IRepairSetTripTimeService == null)
                {
                    _IRepairSetTripTimeService = this.BLLIocTool.Get<IRepairSetTripTimeService>();
                }
                return _IRepairSetTripTimeService;
            }
        }

        ISiteCarImageService _ISiteCarImageService;
        /// <summary>
        /// Site_CarImage(汽车之家关系表)表逻辑契约接口
        /// </summary>
        public ISiteCarImageService ISiteCarImageService
        {
            get
            {
                if (_ISiteCarImageService == null)
                {
                    _ISiteCarImageService = this.BLLIocTool.Get<ISiteCarImageService>();
                }
                return _ISiteCarImageService;
            }
        }

        ISmsMainService _ISmsMainService;
        /// <summary>
        /// Sms_Main(短信表)表逻辑契约接口
        /// </summary>
        public ISmsMainService ISmsMainService
        {
            get
            {
                if (_ISmsMainService == null)
                {
                    _ISmsMainService = this.BLLIocTool.Get<ISmsMainService>();
                }
                return _ISmsMainService;
            }
        }

        IStoreCommentService _IStoreCommentService;
        /// <summary>
        /// Store_Comment( )表逻辑契约接口
        /// </summary>
        public IStoreCommentService IStoreCommentService
        {
            get
            {
                if (_IStoreCommentService == null)
                {
                    _IStoreCommentService = this.BLLIocTool.Get<IStoreCommentService>();
                }
                return _IStoreCommentService;
            }
        }

        IStoreMainService _IStoreMainService;
        /// <summary>
        /// Store_Main()表逻辑契约接口
        /// </summary>
        public IStoreMainService IStoreMainService
        {
            get
            {
                if (_IStoreMainService == null)
                {
                    _IStoreMainService = this.BLLIocTool.Get<IStoreMainService>();
                }
                return _IStoreMainService;
            }
        }

        IStoreMainBrandService _IStoreMainBrandService;
        /// <summary>
        /// Store_MainBrand()表逻辑契约接口
        /// </summary>
        public IStoreMainBrandService IStoreMainBrandService
        {
            get
            {
                if (_IStoreMainBrandService == null)
                {
                    _IStoreMainBrandService = this.BLLIocTool.Get<IStoreMainBrandService>();
                }
                return _IStoreMainBrandService;
            }
        }

        IStoreMainGoodCarService _IStoreMainGoodCarService;
        /// <summary>
        /// Store_MainGoodCar( )表逻辑契约接口
        /// </summary>
        public IStoreMainGoodCarService IStoreMainGoodCarService
        {
            get
            {
                if (_IStoreMainGoodCarService == null)
                {
                    _IStoreMainGoodCarService = this.BLLIocTool.Get<IStoreMainGoodCarService>();
                }
                return _IStoreMainGoodCarService;
            }
        }

        IStoreMainImageService _IStoreMainImageService;
        /// <summary>
        /// Store_MainImage( )表逻辑契约接口
        /// </summary>
        public IStoreMainImageService IStoreMainImageService
        {
            get
            {
                if (_IStoreMainImageService == null)
                {
                    _IStoreMainImageService = this.BLLIocTool.Get<IStoreMainImageService>();
                }
                return _IStoreMainImageService;
            }
        }

        IStoreOrderDrivingTestService _IStoreOrderDrivingTestService;
        /// <summary>
        /// Store_OrderDrivingTest( )表逻辑契约接口
        /// </summary>
        public IStoreOrderDrivingTestService IStoreOrderDrivingTestService
        {
            get
            {
                if (_IStoreOrderDrivingTestService == null)
                {
                    _IStoreOrderDrivingTestService = this.BLLIocTool.Get<IStoreOrderDrivingTestService>();
                }
                return _IStoreOrderDrivingTestService;
            }
        }

        ISysCenterToSiteTableService _ISysCenterToSiteTableService;
        /// <summary>
        /// Sys_CenterToSiteTable()表逻辑契约接口
        /// </summary>
        public ISysCenterToSiteTableService ISysCenterToSiteTableService
        {
            get
            {
                if (_ISysCenterToSiteTableService == null)
                {
                    _ISysCenterToSiteTableService = this.BLLIocTool.Get<ISysCenterToSiteTableService>();
                }
                return _ISysCenterToSiteTableService;
            }
        }

        ITActivityService _ITActivityService;
        /// <summary>
        /// T_Activity()表逻辑契约接口
        /// </summary>
        public ITActivityService ITActivityService
        {
            get
            {
                if (_ITActivityService == null)
                {
                    _ITActivityService = this.BLLIocTool.Get<ITActivityService>();
                }
                return _ITActivityService;
            }
        }

        ITActivityGuestItemService _ITActivityGuestItemService;
        /// <summary>
        /// T_ActivityGuestItem()表逻辑契约接口
        /// </summary>
        public ITActivityGuestItemService ITActivityGuestItemService
        {
            get
            {
                if (_ITActivityGuestItemService == null)
                {
                    _ITActivityGuestItemService = this.BLLIocTool.Get<ITActivityGuestItemService>();
                }
                return _ITActivityGuestItemService;
            }
        }

        ITAdditionServiceService _ITAdditionServiceService;
        /// <summary>
        /// T_AdditionService()表逻辑契约接口
        /// </summary>
        public ITAdditionServiceService ITAdditionServiceService
        {
            get
            {
                if (_ITAdditionServiceService == null)
                {
                    _ITAdditionServiceService = this.BLLIocTool.Get<ITAdditionServiceService>();
                }
                return _ITAdditionServiceService;
            }
        }

        ItareaService _ItareaService;
        /// <summary>
        /// t_area()表逻辑契约接口
        /// </summary>
        public ItareaService ItareaService
        {
            get
            {
                if (_ItareaService == null)
                {
                    _ItareaService = this.BLLIocTool.Get<ItareaService>();
                }
                return _ItareaService;
            }
        }

        Itarea2Service _Itarea2Service;
        /// <summary>
        /// t_area2()表逻辑契约接口
        /// </summary>
        public Itarea2Service Itarea2Service
        {
            get
            {
                if (_Itarea2Service == null)
                {
                    _Itarea2Service = this.BLLIocTool.Get<Itarea2Service>();
                }
                return _Itarea2Service;
            }
        }

        ITCarBrandService _ITCarBrandService;
        /// <summary>
        /// T_CarBrand()表逻辑契约接口
        /// </summary>
        public ITCarBrandService ITCarBrandService
        {
            get
            {
                if (_ITCarBrandService == null)
                {
                    _ITCarBrandService = this.BLLIocTool.Get<ITCarBrandService>();
                }
                return _ITCarBrandService;
            }
        }

        ITCarItemService _ITCarItemService;
        /// <summary>
        /// T_CarItem()表逻辑契约接口
        /// </summary>
        public ITCarItemService ITCarItemService
        {
            get
            {
                if (_ITCarItemService == null)
                {
                    _ITCarItemService = this.BLLIocTool.Get<ITCarItemService>();
                }
                return _ITCarItemService;
            }
        }

        ITCarItemBrandService _ITCarItemBrandService;
        /// <summary>
        /// T_CarItemBrand()表逻辑契约接口
        /// </summary>
        public ITCarItemBrandService ITCarItemBrandService
        {
            get
            {
                if (_ITCarItemBrandService == null)
                {
                    _ITCarItemBrandService = this.BLLIocTool.Get<ITCarItemBrandService>();
                }
                return _ITCarItemBrandService;
            }
        }

        ITCarTypeService _ITCarTypeService;
        /// <summary>
        /// T_CarType()表逻辑契约接口
        /// </summary>
        public ITCarTypeService ITCarTypeService
        {
            get
            {
                if (_ITCarTypeService == null)
                {
                    _ITCarTypeService = this.BLLIocTool.Get<ITCarTypeService>();
                }
                return _ITCarTypeService;
            }
        }

        ITCarTypeBigService _ITCarTypeBigService;
        /// <summary>
        /// T_CarTypeBig()表逻辑契约接口
        /// </summary>
        public ITCarTypeBigService ITCarTypeBigService
        {
            get
            {
                if (_ITCarTypeBigService == null)
                {
                    _ITCarTypeBigService = this.BLLIocTool.Get<ITCarTypeBigService>();
                }
                return _ITCarTypeBigService;
            }
        }

        ITCarTypeBigLvService _ITCarTypeBigLvService;
        /// <summary>
        /// T_CarTypeBigLv()表逻辑契约接口
        /// </summary>
        public ITCarTypeBigLvService ITCarTypeBigLvService
        {
            get
            {
                if (_ITCarTypeBigLvService == null)
                {
                    _ITCarTypeBigLvService = this.BLLIocTool.Get<ITCarTypeBigLvService>();
                }
                return _ITCarTypeBigLvService;
            }
        }

        ItcityService _ItcityService;
        /// <summary>
        /// t_city()表逻辑契约接口
        /// </summary>
        public ItcityService ItcityService
        {
            get
            {
                if (_ItcityService == null)
                {
                    _ItcityService = this.BLLIocTool.Get<ItcityService>();
                }
                return _ItcityService;
            }
        }

        ITCustomerService _ITCustomerService;
        /// <summary>
        /// T_Customer()表逻辑契约接口
        /// </summary>
        public ITCustomerService ITCustomerService
        {
            get
            {
                if (_ITCustomerService == null)
                {
                    _ITCustomerService = this.BLLIocTool.Get<ITCustomerService>();
                }
                return _ITCustomerService;
            }
        }

        ITEmployeeService _ITEmployeeService;
        /// <summary>
        /// T_Employee()表逻辑契约接口
        /// </summary>
        public ITEmployeeService ITEmployeeService
        {
            get
            {
                if (_ITEmployeeService == null)
                {
                    _ITEmployeeService = this.BLLIocTool.Get<ITEmployeeService>();
                }
                return _ITEmployeeService;
            }
        }

        ITGuestService _ITGuestService;
        /// <summary>
        /// T_Guest()表逻辑契约接口
        /// </summary>
        public ITGuestService ITGuestService
        {
            get
            {
                if (_ITGuestService == null)
                {
                    _ITGuestService = this.BLLIocTool.Get<ITGuestService>();
                }
                return _ITGuestService;
            }
        }

        ITGuestContactService _ITGuestContactService;
        /// <summary>
        /// T_GuestContact()表逻辑契约接口
        /// </summary>
        public ITGuestContactService ITGuestContactService
        {
            get
            {
                if (_ITGuestContactService == null)
                {
                    _ITGuestContactService = this.BLLIocTool.Get<ITGuestContactService>();
                }
                return _ITGuestContactService;
            }
        }

        ITInfoManageService _ITInfoManageService;
        /// <summary>
        /// T_InfoManage()表逻辑契约接口
        /// </summary>
        public ITInfoManageService ITInfoManageService
        {
            get
            {
                if (_ITInfoManageService == null)
                {
                    _ITInfoManageService = this.BLLIocTool.Get<ITInfoManageService>();
                }
                return _ITInfoManageService;
            }
        }

        ITKeyManageService _ITKeyManageService;
        /// <summary>
        /// T_KeyManage()表逻辑契约接口
        /// </summary>
        public ITKeyManageService ITKeyManageService
        {
            get
            {
                if (_ITKeyManageService == null)
                {
                    _ITKeyManageService = this.BLLIocTool.Get<ITKeyManageService>();
                }
                return _ITKeyManageService;
            }
        }

        ITKeyManageContentService _ITKeyManageContentService;
        /// <summary>
        /// T_KeyManageContent()表逻辑契约接口
        /// </summary>
        public ITKeyManageContentService ITKeyManageContentService
        {
            get
            {
                if (_ITKeyManageContentService == null)
                {
                    _ITKeyManageContentService = this.BLLIocTool.Get<ITKeyManageContentService>();
                }
                return _ITKeyManageContentService;
            }
        }

        ITMemberLvService _ITMemberLvService;
        /// <summary>
        /// T_MemberLv()表逻辑契约接口
        /// </summary>
        public ITMemberLvService ITMemberLvService
        {
            get
            {
                if (_ITMemberLvService == null)
                {
                    _ITMemberLvService = this.BLLIocTool.Get<ITMemberLvService>();
                }
                return _ITMemberLvService;
            }
        }

        ITMessageCountService _ITMessageCountService;
        /// <summary>
        /// T_MessageCount()表逻辑契约接口
        /// </summary>
        public ITMessageCountService ITMessageCountService
        {
            get
            {
                if (_ITMessageCountService == null)
                {
                    _ITMessageCountService = this.BLLIocTool.Get<ITMessageCountService>();
                }
                return _ITMessageCountService;
            }
        }

        ITMessageRecordService _ITMessageRecordService;
        /// <summary>
        /// T_MessageRecord()表逻辑契约接口
        /// </summary>
        public ITMessageRecordService ITMessageRecordService
        {
            get
            {
                if (_ITMessageRecordService == null)
                {
                    _ITMessageRecordService = this.BLLIocTool.Get<ITMessageRecordService>();
                }
                return _ITMessageRecordService;
            }
        }

        ITNeedsService _ITNeedsService;
        /// <summary>
        /// T_Needs()表逻辑契约接口
        /// </summary>
        public ITNeedsService ITNeedsService
        {
            get
            {
                if (_ITNeedsService == null)
                {
                    _ITNeedsService = this.BLLIocTool.Get<ITNeedsService>();
                }
                return _ITNeedsService;
            }
        }

        ITNoticeService _ITNoticeService;
        /// <summary>
        /// T_Notice()表逻辑契约接口
        /// </summary>
        public ITNoticeService ITNoticeService
        {
            get
            {
                if (_ITNoticeService == null)
                {
                    _ITNoticeService = this.BLLIocTool.Get<ITNoticeService>();
                }
                return _ITNoticeService;
            }
        }

        ITNoticeReciverService _ITNoticeReciverService;
        /// <summary>
        /// T_NoticeReciver()表逻辑契约接口
        /// </summary>
        public ITNoticeReciverService ITNoticeReciverService
        {
            get
            {
                if (_ITNoticeReciverService == null)
                {
                    _ITNoticeReciverService = this.BLLIocTool.Get<ITNoticeReciverService>();
                }
                return _ITNoticeReciverService;
            }
        }

        ItprovinceService _ItprovinceService;
        /// <summary>
        /// t_province()表逻辑契约接口
        /// </summary>
        public ItprovinceService ItprovinceService
        {
            get
            {
                if (_ItprovinceService == null)
                {
                    _ItprovinceService = this.BLLIocTool.Get<ItprovinceService>();
                }
                return _ItprovinceService;
            }
        }

        ITSendMessageService _ITSendMessageService;
        /// <summary>
        /// T_SendMessage()表逻辑契约接口
        /// </summary>
        public ITSendMessageService ITSendMessageService
        {
            get
            {
                if (_ITSendMessageService == null)
                {
                    _ITSendMessageService = this.BLLIocTool.Get<ITSendMessageService>();
                }
                return _ITSendMessageService;
            }
        }

        ITSMSListService _ITSMSListService;
        /// <summary>
        /// T_SMSList()表逻辑契约接口
        /// </summary>
        public ITSMSListService ITSMSListService
        {
            get
            {
                if (_ITSMSListService == null)
                {
                    _ITSMSListService = this.BLLIocTool.Get<ITSMSListService>();
                }
                return _ITSMSListService;
            }
        }

        ITSystemConfigService _ITSystemConfigService;
        /// <summary>
        /// T_System_Config(系统设置)表逻辑契约接口
        /// </summary>
        public ITSystemConfigService ITSystemConfigService
        {
            get
            {
                if (_ITSystemConfigService == null)
                {
                    _ITSystemConfigService = this.BLLIocTool.Get<ITSystemConfigService>();
                }
                return _ITSystemConfigService;
            }
        }

        ITUsedCarBuyService _ITUsedCarBuyService;
        /// <summary>
        /// T_UsedCarBuy()表逻辑契约接口
        /// </summary>
        public ITUsedCarBuyService ITUsedCarBuyService
        {
            get
            {
                if (_ITUsedCarBuyService == null)
                {
                    _ITUsedCarBuyService = this.BLLIocTool.Get<ITUsedCarBuyService>();
                }
                return _ITUsedCarBuyService;
            }
        }

        ITUsedCarSellService _ITUsedCarSellService;
        /// <summary>
        /// T_UsedCarSell()表逻辑契约接口
        /// </summary>
        public ITUsedCarSellService ITUsedCarSellService
        {
            get
            {
                if (_ITUsedCarSellService == null)
                {
                    _ITUsedCarSellService = this.BLLIocTool.Get<ITUsedCarSellService>();
                }
                return _ITUsedCarSellService;
            }
        }

        ITalkPriceCategoryService _ITalkPriceCategoryService;
        /// <summary>
        /// TalkPrice_Category()表逻辑契约接口
        /// </summary>
        public ITalkPriceCategoryService ITalkPriceCategoryService
        {
            get
            {
                if (_ITalkPriceCategoryService == null)
                {
                    _ITalkPriceCategoryService = this.BLLIocTool.Get<ITalkPriceCategoryService>();
                }
                return _ITalkPriceCategoryService;
            }
        }

        ITalkPriceCategoryConnectCarBrandService _ITalkPriceCategoryConnectCarBrandService;
        /// <summary>
        /// TalkPrice_CategoryConnectCarBrand()表逻辑契约接口
        /// </summary>
        public ITalkPriceCategoryConnectCarBrandService ITalkPriceCategoryConnectCarBrandService
        {
            get
            {
                if (_ITalkPriceCategoryConnectCarBrandService == null)
                {
                    _ITalkPriceCategoryConnectCarBrandService = this.BLLIocTool.Get<ITalkPriceCategoryConnectCarBrandService>();
                }
                return _ITalkPriceCategoryConnectCarBrandService;
            }
        }

        ITalkPriceImageService _ITalkPriceImageService;
        /// <summary>
        /// TalkPrice_Image()表逻辑契约接口
        /// </summary>
        public ITalkPriceImageService ITalkPriceImageService
        {
            get
            {
                if (_ITalkPriceImageService == null)
                {
                    _ITalkPriceImageService = this.BLLIocTool.Get<ITalkPriceImageService>();
                }
                return _ITalkPriceImageService;
            }
        }

        ITalkPriceOrderService _ITalkPriceOrderService;
        /// <summary>
        /// TalkPrice_Order()表逻辑契约接口
        /// </summary>
        public ITalkPriceOrderService ITalkPriceOrderService
        {
            get
            {
                if (_ITalkPriceOrderService == null)
                {
                    _ITalkPriceOrderService = this.BLLIocTool.Get<ITalkPriceOrderService>();
                }
                return _ITalkPriceOrderService;
            }
        }

        ITalkPriceOrderSmsRecordService _ITalkPriceOrderSmsRecordService;
        /// <summary>
        /// TalkPrice_OrderSmsRecord(短信表)表逻辑契约接口
        /// </summary>
        public ITalkPriceOrderSmsRecordService ITalkPriceOrderSmsRecordService
        {
            get
            {
                if (_ITalkPriceOrderSmsRecordService == null)
                {
                    _ITalkPriceOrderSmsRecordService = this.BLLIocTool.Get<ITalkPriceOrderSmsRecordService>();
                }
                return _ITalkPriceOrderSmsRecordService;
            }
        }

        ITalkPriceRepairItemService _ITalkPriceRepairItemService;
        /// <summary>
        /// TalkPrice_RepairItem()表逻辑契约接口
        /// </summary>
        public ITalkPriceRepairItemService ITalkPriceRepairItemService
        {
            get
            {
                if (_ITalkPriceRepairItemService == null)
                {
                    _ITalkPriceRepairItemService = this.BLLIocTool.Get<ITalkPriceRepairItemService>();
                }
                return _ITalkPriceRepairItemService;
            }
        }

        ITalkPriceRepairItemCommentService _ITalkPriceRepairItemCommentService;
        /// <summary>
        /// TalkPrice_RepairItemComment( )表逻辑契约接口
        /// </summary>
        public ITalkPriceRepairItemCommentService ITalkPriceRepairItemCommentService
        {
            get
            {
                if (_ITalkPriceRepairItemCommentService == null)
                {
                    _ITalkPriceRepairItemCommentService = this.BLLIocTool.Get<ITalkPriceRepairItemCommentService>();
                }
                return _ITalkPriceRepairItemCommentService;
            }
        }

        IVideoMainService _IVideoMainService;
        /// <summary>
        /// Video_Main()表逻辑契约接口
        /// </summary>
        public IVideoMainService IVideoMainService
        {
            get
            {
                if (_IVideoMainService == null)
                {
                    _IVideoMainService = this.BLLIocTool.Get<IVideoMainService>();
                }
                return _IVideoMainService;
            }
        }

        IVideoMainToVideoService _IVideoMainToVideoService;
        /// <summary>
        /// Video_MainToVideo()表逻辑契约接口
        /// </summary>
        public IVideoMainToVideoService IVideoMainToVideoService
        {
            get
            {
                if (_IVideoMainToVideoService == null)
                {
                    _IVideoMainToVideoService = this.BLLIocTool.Get<IVideoMainToVideoService>();
                }
                return _IVideoMainToVideoService;
            }
        }

        IWebSiteService _IWebSiteService;
        /// <summary>
        /// WebSite()表逻辑契约接口
        /// </summary>
        public IWebSiteService IWebSiteService
        {
            get
            {
                if (_IWebSiteService == null)
                {
                    _IWebSiteService = this.BLLIocTool.Get<IWebSiteService>();
                }
                return _IWebSiteService;
            }
        }

        IWebSiteSkinColorService _IWebSiteSkinColorService;
        /// <summary>
        /// WebSiteSkinColor()表逻辑契约接口
        /// </summary>
        public IWebSiteSkinColorService IWebSiteSkinColorService
        {
            get
            {
                if (_IWebSiteSkinColorService == null)
                {
                    _IWebSiteSkinColorService = this.BLLIocTool.Get<IWebSiteSkinColorService>();
                }
                return _IWebSiteSkinColorService;
            }
        }

        IWebSiteTemplateSkinService _IWebSiteTemplateSkinService;
        /// <summary>
        /// WebSiteTemplateSkin()表逻辑契约接口
        /// </summary>
        public IWebSiteTemplateSkinService IWebSiteTemplateSkinService
        {
            get
            {
                if (_IWebSiteTemplateSkinService == null)
                {
                    _IWebSiteTemplateSkinService = this.BLLIocTool.Get<IWebSiteTemplateSkinService>();
                }
                return _IWebSiteTemplateSkinService;
            }
        }

        IWeiXinAccountToCenterAccountService _IWeiXinAccountToCenterAccountService;
        /// <summary>
        /// WeiXin_AccountToCenterAccount(微信账号对集群账号表)表逻辑契约接口
        /// </summary>
        public IWeiXinAccountToCenterAccountService IWeiXinAccountToCenterAccountService
        {
            get
            {
                if (_IWeiXinAccountToCenterAccountService == null)
                {
                    _IWeiXinAccountToCenterAccountService = this.BLLIocTool.Get<IWeiXinAccountToCenterAccountService>();
                }
                return _IWeiXinAccountToCenterAccountService;
            }
        }

        IWeiXinActivityService _IWeiXinActivityService;
        /// <summary>
        /// WeiXin_Activity(微活动报名表)表逻辑契约接口
        /// </summary>
        public IWeiXinActivityService IWeiXinActivityService
        {
            get
            {
                if (_IWeiXinActivityService == null)
                {
                    _IWeiXinActivityService = this.BLLIocTool.Get<IWeiXinActivityService>();
                }
                return _IWeiXinActivityService;
            }
        }

        IWeiXinActivityApplicantService _IWeiXinActivityApplicantService;
        /// <summary>
        /// WeiXin_Activity_Applicant(微活动报名表)表逻辑契约接口
        /// </summary>
        public IWeiXinActivityApplicantService IWeiXinActivityApplicantService
        {
            get
            {
                if (_IWeiXinActivityApplicantService == null)
                {
                    _IWeiXinActivityApplicantService = this.BLLIocTool.Get<IWeiXinActivityApplicantService>();
                }
                return _IWeiXinActivityApplicantService;
            }
        }

        IWeiXinArticlesService _IWeiXinArticlesService;
        /// <summary>
        /// WeiXin_Articles(微信文章表)表逻辑契约接口
        /// </summary>
        public IWeiXinArticlesService IWeiXinArticlesService
        {
            get
            {
                if (_IWeiXinArticlesService == null)
                {
                    _IWeiXinArticlesService = this.BLLIocTool.Get<IWeiXinArticlesService>();
                }
                return _IWeiXinArticlesService;
            }
        }

        IWeiXinMenusService _IWeiXinMenusService;
        /// <summary>
        /// WeiXin_Menus(微信菜单表)表逻辑契约接口
        /// </summary>
        public IWeiXinMenusService IWeiXinMenusService
        {
            get
            {
                if (_IWeiXinMenusService == null)
                {
                    _IWeiXinMenusService = this.BLLIocTool.Get<IWeiXinMenusService>();
                }
                return _IWeiXinMenusService;
            }
        }

        IWeiXinMenusArticlesRefService _IWeiXinMenusArticlesRefService;
        /// <summary>
        /// WeiXin_Menus_Articles_Ref(微信菜单与文章表)表逻辑契约接口
        /// </summary>
        public IWeiXinMenusArticlesRefService IWeiXinMenusArticlesRefService
        {
            get
            {
                if (_IWeiXinMenusArticlesRefService == null)
                {
                    _IWeiXinMenusArticlesRefService = this.BLLIocTool.Get<IWeiXinMenusArticlesRefService>();
                }
                return _IWeiXinMenusArticlesRefService;
            }
        }

        IWeiXinQRCodeService _IWeiXinQRCodeService;
        /// <summary>
        /// WeiXin_QRCode(微信二维码信息表)表逻辑契约接口
        /// </summary>
        public IWeiXinQRCodeService IWeiXinQRCodeService
        {
            get
            {
                if (_IWeiXinQRCodeService == null)
                {
                    _IWeiXinQRCodeService = this.BLLIocTool.Get<IWeiXinQRCodeService>();
                }
                return _IWeiXinQRCodeService;
            }
        }

        IWeiXinQRCodePromotionActivityAccountService _IWeiXinQRCodePromotionActivityAccountService;
        /// <summary>
        /// WeiXin_QRCodePromotionActivityAccount(微信参加二维码推广活动用户信息表)表逻辑契约接口
        /// </summary>
        public IWeiXinQRCodePromotionActivityAccountService IWeiXinQRCodePromotionActivityAccountService
        {
            get
            {
                if (_IWeiXinQRCodePromotionActivityAccountService == null)
                {
                    _IWeiXinQRCodePromotionActivityAccountService = this.BLLIocTool.Get<IWeiXinQRCodePromotionActivityAccountService>();
                }
                return _IWeiXinQRCodePromotionActivityAccountService;
            }
        }

        IWeiXinQRCodePromotionActivityAccountPointsHistoryService _IWeiXinQRCodePromotionActivityAccountPointsHistoryService;
        /// <summary>
        /// WeiXin_QRCodePromotionActivityAccountPointsHistory(微信参加二维码推广活动用户积分使用历史信息表)表逻辑契约接口
        /// </summary>
        public IWeiXinQRCodePromotionActivityAccountPointsHistoryService IWeiXinQRCodePromotionActivityAccountPointsHistoryService
        {
            get
            {
                if (_IWeiXinQRCodePromotionActivityAccountPointsHistoryService == null)
                {
                    _IWeiXinQRCodePromotionActivityAccountPointsHistoryService = this.BLLIocTool.Get<IWeiXinQRCodePromotionActivityAccountPointsHistoryService>();
                }
                return _IWeiXinQRCodePromotionActivityAccountPointsHistoryService;
            }
        }

        IWeiXinQRCodePromotionActivityMemberFromAccountService _IWeiXinQRCodePromotionActivityMemberFromAccountService;
        /// <summary>
        /// WeiXin_QRCodePromotionActivityMemberFromAccount(关注微信参加二维码推广活动用户的用户记录信息表)表逻辑契约接口
        /// </summary>
        public IWeiXinQRCodePromotionActivityMemberFromAccountService IWeiXinQRCodePromotionActivityMemberFromAccountService
        {
            get
            {
                if (_IWeiXinQRCodePromotionActivityMemberFromAccountService == null)
                {
                    _IWeiXinQRCodePromotionActivityMemberFromAccountService = this.BLLIocTool.Get<IWeiXinQRCodePromotionActivityMemberFromAccountService>();
                }
                return _IWeiXinQRCodePromotionActivityMemberFromAccountService;
            }
        }

        IWeiXinWebSiteInfoService _IWeiXinWebSiteInfoService;
        /// <summary>
        /// WeiXin_WebSiteInfo(站点微信信息表)表逻辑契约接口
        /// </summary>
        public IWeiXinWebSiteInfoService IWeiXinWebSiteInfoService
        {
            get
            {
                if (_IWeiXinWebSiteInfoService == null)
                {
                    _IWeiXinWebSiteInfoService = this.BLLIocTool.Get<IWeiXinWebSiteInfoService>();
                }
                return _IWeiXinWebSiteInfoService;
            }
        }
        IWeiXinMerchantBIllNoService _IWeiXinMerchantBIllNoService;
        /// <summary>
        /// WeiXin_MerchantBIllNo(微信商户账单号信息表)表逻辑契约接口
        /// </summary>
        public IWeiXinMerchantBIllNoService IWeiXinMerchantBIllNoService
        {
            get
            {
                if (_IWeiXinMerchantBIllNoService == null)
                {
                    _IWeiXinMerchantBIllNoService = this.BLLIocTool.Get<IWeiXinMerchantBIllNoService>();
                }
                return _IWeiXinMerchantBIllNoService;
            }
        }
    }
}