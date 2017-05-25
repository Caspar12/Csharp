/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 数据接口Context文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
using Zh.DAL.Define;
using Zh.DAL.Define.Contracts;
using Zh.Framework.Tools.IocTool;
namespace Zh.DAL.Define.DbContexts
{
    /// <summary>
    /// 数据访问层集合
    /// </summary>
    public partial class DbContext
    {
        /// <summary>
        /// 契约接口IoC接口
        /// </summary>
        public IIocTool DALIocTool = Zh.Framework.Tools.ToolFactory.DALIoc;

        IActivityACMatchDao _IActivityACMatchDao;
        /// <summary>
        /// Activity_AC_Match(对抗类比赛表)表契约接口
        /// </summary>
        public IActivityACMatchDao IActivityACMatchDao
        {
            get
            {
                if (_IActivityACMatchDao == null)
                {
                    _IActivityACMatchDao = this.DALIocTool.Get<IActivityACMatchDao>();
                }
                return _IActivityACMatchDao;
            }
        }

        IActivityACScoreGuessRecordDao _IActivityACScoreGuessRecordDao;
        /// <summary>
        /// Activity_AC_ScoreGuessRecord(对抗类比赛竞猜比分)表契约接口
        /// </summary>
        public IActivityACScoreGuessRecordDao IActivityACScoreGuessRecordDao
        {
            get
            {
                if (_IActivityACScoreGuessRecordDao == null)
                {
                    _IActivityACScoreGuessRecordDao = this.DALIocTool.Get<IActivityACScoreGuessRecordDao>();
                }
                return _IActivityACScoreGuessRecordDao;
            }
        }

        IActivityACWinnerGuessRecordDao _IActivityACWinnerGuessRecordDao;
        /// <summary>
        /// Activity_AC_WinnerGuessRecord(积分竞猜记录)表契约接口
        /// </summary>
        public IActivityACWinnerGuessRecordDao IActivityACWinnerGuessRecordDao
        {
            get
            {
                if (_IActivityACWinnerGuessRecordDao == null)
                {
                    _IActivityACWinnerGuessRecordDao = this.DALIocTool.Get<IActivityACWinnerGuessRecordDao>();
                }
                return _IActivityACWinnerGuessRecordDao;
            }
        }

        IActivityAttentionDao _IActivityAttentionDao;
        /// <summary>
        /// Activity_Attention()表契约接口
        /// </summary>
        public IActivityAttentionDao IActivityAttentionDao
        {
            get
            {
                if (_IActivityAttentionDao == null)
                {
                    _IActivityAttentionDao = this.DALIocTool.Get<IActivityAttentionDao>();
                }
                return _IActivityAttentionDao;
            }
        }

        IActivityChampionGuessRecordDao _IActivityChampionGuessRecordDao;
        /// <summary>
        /// Activity_ChampionGuessRecord(冠军竞猜记录)表契约接口
        /// </summary>
        public IActivityChampionGuessRecordDao IActivityChampionGuessRecordDao
        {
            get
            {
                if (_IActivityChampionGuessRecordDao == null)
                {
                    _IActivityChampionGuessRecordDao = this.DALIocTool.Get<IActivityChampionGuessRecordDao>();
                }
                return _IActivityChampionGuessRecordDao;
            }
        }

        IActivityHistoryDao _IActivityHistoryDao;
        /// <summary>
        /// Activity_History(活动抽奖历史表)表契约接口
        /// </summary>
        public IActivityHistoryDao IActivityHistoryDao
        {
            get
            {
                if (_IActivityHistoryDao == null)
                {
                    _IActivityHistoryDao = this.DALIocTool.Get<IActivityHistoryDao>();
                }
                return _IActivityHistoryDao;
            }
        }

        IActivityLotteryMainDao _IActivityLotteryMainDao;
        /// <summary>
        /// Activity_LotteryMain(活动表)表契约接口
        /// </summary>
        public IActivityLotteryMainDao IActivityLotteryMainDao
        {
            get
            {
                if (_IActivityLotteryMainDao == null)
                {
                    _IActivityLotteryMainDao = this.DALIocTool.Get<IActivityLotteryMainDao>();
                }
                return _IActivityLotteryMainDao;
            }
        }

        IActivityMainDao _IActivityMainDao;
        /// <summary>
        /// Activity_Main(活动表)表契约接口
        /// </summary>
        public IActivityMainDao IActivityMainDao
        {
            get
            {
                if (_IActivityMainDao == null)
                {
                    _IActivityMainDao = this.DALIocTool.Get<IActivityMainDao>();
                }
                return _IActivityMainDao;
            }
        }

        IActivityMainToUserDao _IActivityMainToUserDao;
        /// <summary>
        /// Activity_MainToUser(用户参与活动记录表)表契约接口
        /// </summary>
        public IActivityMainToUserDao IActivityMainToUserDao
        {
            get
            {
                if (_IActivityMainToUserDao == null)
                {
                    _IActivityMainToUserDao = this.DALIocTool.Get<IActivityMainToUserDao>();
                }
                return _IActivityMainToUserDao;
            }
        }

        IActivityPrizeDao _IActivityPrizeDao;
        /// <summary>
        /// Activity_Prize(活动奖品表)表契约接口
        /// </summary>
        public IActivityPrizeDao IActivityPrizeDao
        {
            get
            {
                if (_IActivityPrizeDao == null)
                {
                    _IActivityPrizeDao = this.DALIocTool.Get<IActivityPrizeDao>();
                }
                return _IActivityPrizeDao;
            }
        }

        IActivityTeamDao _IActivityTeamDao;
        /// <summary>
        /// Activity_Team(队伍)表契约接口
        /// </summary>
        public IActivityTeamDao IActivityTeamDao
        {
            get
            {
                if (_IActivityTeamDao == null)
                {
                    _IActivityTeamDao = this.DALIocTool.Get<IActivityTeamDao>();
                }
                return _IActivityTeamDao;
            }
        }

        IActivityUserExtendInfoDao _IActivityUserExtendInfoDao;
        /// <summary>
        /// Activity_UserExtendInfo(活动用户信息扩展表)表契约接口
        /// </summary>
        public IActivityUserExtendInfoDao IActivityUserExtendInfoDao
        {
            get
            {
                if (_IActivityUserExtendInfoDao == null)
                {
                    _IActivityUserExtendInfoDao = this.DALIocTool.Get<IActivityUserExtendInfoDao>();
                }
                return _IActivityUserExtendInfoDao;
            }
        }

        IActivityUserPrizeDao _IActivityUserPrizeDao;
        /// <summary>
        /// Activity_UserPrize(活动中奖人员表)表契约接口
        /// </summary>
        public IActivityUserPrizeDao IActivityUserPrizeDao
        {
            get
            {
                if (_IActivityUserPrizeDao == null)
                {
                    _IActivityUserPrizeDao = this.DALIocTool.Get<IActivityUserPrizeDao>();
                }
                return _IActivityUserPrizeDao;
            }
        }

        IAdsingleDao _IAdsingleDao;
        /// <summary>
        /// Ad_single()表契约接口
        /// </summary>
        public IAdsingleDao IAdsingleDao
        {
            get
            {
                if (_IAdsingleDao == null)
                {
                    _IAdsingleDao = this.DALIocTool.Get<IAdsingleDao>();
                }
                return _IAdsingleDao;
            }
        }

        IAdBannerDao _IAdBannerDao;
        /// <summary>
        /// AdBanner()表契约接口
        /// </summary>
        public IAdBannerDao IAdBannerDao
        {
            get
            {
                if (_IAdBannerDao == null)
                {
                    _IAdBannerDao = this.DALIocTool.Get<IAdBannerDao>();
                }
                return _IAdBannerDao;
            }
        }

        IAdTemplateDao _IAdTemplateDao;
        /// <summary>
        /// AdTemplate()表契约接口
        /// </summary>
        public IAdTemplateDao IAdTemplateDao
        {
            get
            {
                if (_IAdTemplateDao == null)
                {
                    _IAdTemplateDao = this.DALIocTool.Get<IAdTemplateDao>();
                }
                return _IAdTemplateDao;
            }
        }

        IArticleMainDao _IArticleMainDao;
        /// <summary>
        /// Article_Main(文章表)表契约接口
        /// </summary>
        public IArticleMainDao IArticleMainDao
        {
            get
            {
                if (_IArticleMainDao == null)
                {
                    _IArticleMainDao = this.DALIocTool.Get<IArticleMainDao>();
                }
                return _IArticleMainDao;
            }
        }

        IArticleMainToArticleDao _IArticleMainToArticleDao;
        /// <summary>
        /// Article_MainToArticle()表契约接口
        /// </summary>
        public IArticleMainToArticleDao IArticleMainToArticleDao
        {
            get
            {
                if (_IArticleMainToArticleDao == null)
                {
                    _IArticleMainToArticleDao = this.DALIocTool.Get<IArticleMainToArticleDao>();
                }
                return _IArticleMainToArticleDao;
            }
        }

        IArticleMainToBrandDao _IArticleMainToBrandDao;
        /// <summary>
        /// Article_MainToBrand()表契约接口
        /// </summary>
        public IArticleMainToBrandDao IArticleMainToBrandDao
        {
            get
            {
                if (_IArticleMainToBrandDao == null)
                {
                    _IArticleMainToBrandDao = this.DALIocTool.Get<IArticleMainToBrandDao>();
                }
                return _IArticleMainToBrandDao;
            }
        }

        IAuthAdministratorRoleRefDao _IAuthAdministratorRoleRefDao;
        /// <summary>
        /// Auth_AdministratorRoleRef(后台账号与角色关系表)表契约接口
        /// </summary>
        public IAuthAdministratorRoleRefDao IAuthAdministratorRoleRefDao
        {
            get
            {
                if (_IAuthAdministratorRoleRefDao == null)
                {
                    _IAuthAdministratorRoleRefDao = this.DALIocTool.Get<IAuthAdministratorRoleRefDao>();
                }
                return _IAuthAdministratorRoleRefDao;
            }
        }

        IAuthPermissionDao _IAuthPermissionDao;
        /// <summary>
        /// Auth_Permission(权限表)表契约接口
        /// </summary>
        public IAuthPermissionDao IAuthPermissionDao
        {
            get
            {
                if (_IAuthPermissionDao == null)
                {
                    _IAuthPermissionDao = this.DALIocTool.Get<IAuthPermissionDao>();
                }
                return _IAuthPermissionDao;
            }
        }

        IAuthPermissionResourceRefDao _IAuthPermissionResourceRefDao;
        /// <summary>
        /// Auth_PermissionResourceRef(权限资源关系表)表契约接口
        /// </summary>
        public IAuthPermissionResourceRefDao IAuthPermissionResourceRefDao
        {
            get
            {
                if (_IAuthPermissionResourceRefDao == null)
                {
                    _IAuthPermissionResourceRefDao = this.DALIocTool.Get<IAuthPermissionResourceRefDao>();
                }
                return _IAuthPermissionResourceRefDao;
            }
        }

        IAuthPermissionRoleRefDao _IAuthPermissionRoleRefDao;
        /// <summary>
        /// Auth_PermissionRoleRef(权限与角色关系表)表契约接口
        /// </summary>
        public IAuthPermissionRoleRefDao IAuthPermissionRoleRefDao
        {
            get
            {
                if (_IAuthPermissionRoleRefDao == null)
                {
                    _IAuthPermissionRoleRefDao = this.DALIocTool.Get<IAuthPermissionRoleRefDao>();
                }
                return _IAuthPermissionRoleRefDao;
            }
        }

        IAuthResourceDao _IAuthResourceDao;
        /// <summary>
        /// Auth_Resource(权限资源表)表契约接口
        /// </summary>
        public IAuthResourceDao IAuthResourceDao
        {
            get
            {
                if (_IAuthResourceDao == null)
                {
                    _IAuthResourceDao = this.DALIocTool.Get<IAuthResourceDao>();
                }
                return _IAuthResourceDao;
            }
        }

        IAuthRoleDao _IAuthRoleDao;
        /// <summary>
        /// Auth_Role(权限角色表)表契约接口
        /// </summary>
        public IAuthRoleDao IAuthRoleDao
        {
            get
            {
                if (_IAuthRoleDao == null)
                {
                    _IAuthRoleDao = this.DALIocTool.Get<IAuthRoleDao>();
                }
                return _IAuthRoleDao;
            }
        }

        IBBSCommentDao _IBBSCommentDao;
        /// <summary>
        /// BBS_Comment(评论内容表)表契约接口
        /// </summary>
        public IBBSCommentDao IBBSCommentDao
        {
            get
            {
                if (_IBBSCommentDao == null)
                {
                    _IBBSCommentDao = this.DALIocTool.Get<IBBSCommentDao>();
                }
                return _IBBSCommentDao;
            }
        }

        IBBSCommentExtInfoDao _IBBSCommentExtInfoDao;
        /// <summary>
        /// BBS_CommentExtInfo(评论汇总表)表契约接口
        /// </summary>
        public IBBSCommentExtInfoDao IBBSCommentExtInfoDao
        {
            get
            {
                if (_IBBSCommentExtInfoDao == null)
                {
                    _IBBSCommentExtInfoDao = this.DALIocTool.Get<IBBSCommentExtInfoDao>();
                }
                return _IBBSCommentExtInfoDao;
            }
        }

        IBBSCommentSupportRecordDao _IBBSCommentSupportRecordDao;
        /// <summary>
        /// BBS_CommentSupportRecord(评论支持记录表)表契约接口
        /// </summary>
        public IBBSCommentSupportRecordDao IBBSCommentSupportRecordDao
        {
            get
            {
                if (_IBBSCommentSupportRecordDao == null)
                {
                    _IBBSCommentSupportRecordDao = this.DALIocTool.Get<IBBSCommentSupportRecordDao>();
                }
                return _IBBSCommentSupportRecordDao;
            }
        }

        IBBSCommentTypeDao _IBBSCommentTypeDao;
        /// <summary>
        /// BBS_CommentType(评论类型表)表契约接口
        /// </summary>
        public IBBSCommentTypeDao IBBSCommentTypeDao
        {
            get
            {
                if (_IBBSCommentTypeDao == null)
                {
                    _IBBSCommentTypeDao = this.DALIocTool.Get<IBBSCommentTypeDao>();
                }
                return _IBBSCommentTypeDao;
            }
        }

        IBookingCarInfoToActivityOrdersDao _IBookingCarInfoToActivityOrdersDao;
        /// <summary>
        /// Booking_CarInfoToActivityOrders(预约活动订单表)表契约接口
        /// </summary>
        public IBookingCarInfoToActivityOrdersDao IBookingCarInfoToActivityOrdersDao
        {
            get
            {
                if (_IBookingCarInfoToActivityOrdersDao == null)
                {
                    _IBookingCarInfoToActivityOrdersDao = this.DALIocTool.Get<IBookingCarInfoToActivityOrdersDao>();
                }
                return _IBookingCarInfoToActivityOrdersDao;
            }
        }

        ICarAirConditionerAndRefrigeratorConfigDao _ICarAirConditionerAndRefrigeratorConfigDao;
        /// <summary>
        /// Car_AirConditionerAndRefrigeratorConfig(车辆空调与冰箱配置)表契约接口
        /// </summary>
        public ICarAirConditionerAndRefrigeratorConfigDao ICarAirConditionerAndRefrigeratorConfigDao
        {
            get
            {
                if (_ICarAirConditionerAndRefrigeratorConfigDao == null)
                {
                    _ICarAirConditionerAndRefrigeratorConfigDao = this.DALIocTool.Get<ICarAirConditionerAndRefrigeratorConfigDao>();
                }
                return _ICarAirConditionerAndRefrigeratorConfigDao;
            }
        }

        ICarAutoHomeRefDao _ICarAutoHomeRefDao;
        /// <summary>
        /// Car_AutoHome_Ref(汽车之家关系表)表契约接口
        /// </summary>
        public ICarAutoHomeRefDao ICarAutoHomeRefDao
        {
            get
            {
                if (_ICarAutoHomeRefDao == null)
                {
                    _ICarAutoHomeRefDao = this.DALIocTool.Get<ICarAutoHomeRefDao>();
                }
                return _ICarAutoHomeRefDao;
            }
        }

        ICarBrandDao _ICarBrandDao;
        /// <summary>
        /// Car_Brand(车辆品牌)表契约接口
        /// </summary>
        public ICarBrandDao ICarBrandDao
        {
            get
            {
                if (_ICarBrandDao == null)
                {
                    _ICarBrandDao = this.DALIocTool.Get<ICarBrandDao>();
                }
                return _ICarBrandDao;
            }
        }

        ICarBrandImageDao _ICarBrandImageDao;
        /// <summary>
        /// Car_BrandImage( )表契约接口
        /// </summary>
        public ICarBrandImageDao ICarBrandImageDao
        {
            get
            {
                if (_ICarBrandImageDao == null)
                {
                    _ICarBrandImageDao = this.DALIocTool.Get<ICarBrandImageDao>();
                }
                return _ICarBrandImageDao;
            }
        }

        ICarBrandToDistributorDao _ICarBrandToDistributorDao;
        /// <summary>
        /// Car_BrandToDistributor(品牌与经销商关系表)表契约接口
        /// </summary>
        public ICarBrandToDistributorDao ICarBrandToDistributorDao
        {
            get
            {
                if (_ICarBrandToDistributorDao == null)
                {
                    _ICarBrandToDistributorDao = this.DALIocTool.Get<ICarBrandToDistributorDao>();
                }
                return _ICarBrandToDistributorDao;
            }
        }

        ICarColorDao _ICarColorDao;
        /// <summary>
        /// Car_Color(车辆颜色)表契约接口
        /// </summary>
        public ICarColorDao ICarColorDao
        {
            get
            {
                if (_ICarColorDao == null)
                {
                    _ICarColorDao = this.DALIocTool.Get<ICarColorDao>();
                }
                return _ICarColorDao;
            }
        }

        ICarControlConfigDao _ICarControlConfigDao;
        /// <summary>
        /// Car_ControlConfig(车辆操控配置)表契约接口
        /// </summary>
        public ICarControlConfigDao ICarControlConfigDao
        {
            get
            {
                if (_ICarControlConfigDao == null)
                {
                    _ICarControlConfigDao = this.DALIocTool.Get<ICarControlConfigDao>();
                }
                return _ICarControlConfigDao;
            }
        }

        ICarDistributorDao _ICarDistributorDao;
        /// <summary>
        /// Car_Distributor(车辆经销商)表契约接口
        /// </summary>
        public ICarDistributorDao ICarDistributorDao
        {
            get
            {
                if (_ICarDistributorDao == null)
                {
                    _ICarDistributorDao = this.DALIocTool.Get<ICarDistributorDao>();
                }
                return _ICarDistributorDao;
            }
        }

        ICarDistributorImageDao _ICarDistributorImageDao;
        /// <summary>
        /// Car_DistributorImage( )表契约接口
        /// </summary>
        public ICarDistributorImageDao ICarDistributorImageDao
        {
            get
            {
                if (_ICarDistributorImageDao == null)
                {
                    _ICarDistributorImageDao = this.DALIocTool.Get<ICarDistributorImageDao>();
                }
                return _ICarDistributorImageDao;
            }
        }

        ICarDomainConfigDao _ICarDomainConfigDao;
        /// <summary>
        /// Car_Domain_Config(车辆域配置)表契约接口
        /// </summary>
        public ICarDomainConfigDao ICarDomainConfigDao
        {
            get
            {
                if (_ICarDomainConfigDao == null)
                {
                    _ICarDomainConfigDao = this.DALIocTool.Get<ICarDomainConfigDao>();
                }
                return _ICarDomainConfigDao;
            }
        }

        ICarEnquiryDao _ICarEnquiryDao;
        /// <summary>
        /// Car_Enquiry()表契约接口
        /// </summary>
        public ICarEnquiryDao ICarEnquiryDao
        {
            get
            {
                if (_ICarEnquiryDao == null)
                {
                    _ICarEnquiryDao = this.DALIocTool.Get<ICarEnquiryDao>();
                }
                return _ICarEnquiryDao;
            }
        }

        ICarExchangeDao _ICarExchangeDao;
        /// <summary>
        /// Car_Exchange()表契约接口
        /// </summary>
        public ICarExchangeDao ICarExchangeDao
        {
            get
            {
                if (_ICarExchangeDao == null)
                {
                    _ICarExchangeDao = this.DALIocTool.Get<ICarExchangeDao>();
                }
                return _ICarExchangeDao;
            }
        }

        ICarExternalConfigDao _ICarExternalConfigDao;
        /// <summary>
        /// Car_ExternalConfig(外部配置)表契约接口
        /// </summary>
        public ICarExternalConfigDao ICarExternalConfigDao
        {
            get
            {
                if (_ICarExternalConfigDao == null)
                {
                    _ICarExternalConfigDao = this.DALIocTool.Get<ICarExternalConfigDao>();
                }
                return _ICarExternalConfigDao;
            }
        }

        ICarHighTechConfigDao _ICarHighTechConfigDao;
        /// <summary>
        /// Car_HighTechConfig(车辆高科技配置)表契约接口
        /// </summary>
        public ICarHighTechConfigDao ICarHighTechConfigDao
        {
            get
            {
                if (_ICarHighTechConfigDao == null)
                {
                    _ICarHighTechConfigDao = this.DALIocTool.Get<ICarHighTechConfigDao>();
                }
                return _ICarHighTechConfigDao;
            }
        }

        ICarImageDao _ICarImageDao;
        /// <summary>
        /// Car_Image(车辆图片表)表契约接口
        /// </summary>
        public ICarImageDao ICarImageDao
        {
            get
            {
                if (_ICarImageDao == null)
                {
                    _ICarImageDao = this.DALIocTool.Get<ICarImageDao>();
                }
                return _ICarImageDao;
            }
        }

        ICarInternalConfigDao _ICarInternalConfigDao;
        /// <summary>
        /// Car_InternalConfig(内部配置)表契约接口
        /// </summary>
        public ICarInternalConfigDao ICarInternalConfigDao
        {
            get
            {
                if (_ICarInternalConfigDao == null)
                {
                    _ICarInternalConfigDao = this.DALIocTool.Get<ICarInternalConfigDao>();
                }
                return _ICarInternalConfigDao;
            }
        }

        ICarlightsConfigDao _ICarlightsConfigDao;
        /// <summary>
        /// Car_lightsConfig(车辆灯光配置)表契约接口
        /// </summary>
        public ICarlightsConfigDao ICarlightsConfigDao
        {
            get
            {
                if (_ICarlightsConfigDao == null)
                {
                    _ICarlightsConfigDao = this.DALIocTool.Get<ICarlightsConfigDao>();
                }
                return _ICarlightsConfigDao;
            }
        }

        ICarMainDao _ICarMainDao;
        /// <summary>
        /// Car_Main(车辆主表)表契约接口
        /// </summary>
        public ICarMainDao ICarMainDao
        {
            get
            {
                if (_ICarMainDao == null)
                {
                    _ICarMainDao = this.DALIocTool.Get<ICarMainDao>();
                }
                return _ICarMainDao;
            }
        }

        ICarMainCommentDao _ICarMainCommentDao;
        /// <summary>
        /// Car_Main_Comment(车辆评论表)表契约接口
        /// </summary>
        public ICarMainCommentDao ICarMainCommentDao
        {
            get
            {
                if (_ICarMainCommentDao == null)
                {
                    _ICarMainCommentDao = this.DALIocTool.Get<ICarMainCommentDao>();
                }
                return _ICarMainCommentDao;
            }
        }

        ICarMainImageDao _ICarMainImageDao;
        /// <summary>
        /// Car_Main_Image( )表契约接口
        /// </summary>
        public ICarMainImageDao ICarMainImageDao
        {
            get
            {
                if (_ICarMainImageDao == null)
                {
                    _ICarMainImageDao = this.DALIocTool.Get<ICarMainImageDao>();
                }
                return _ICarMainImageDao;
            }
        }

        ICarMainVideoDao _ICarMainVideoDao;
        /// <summary>
        /// Car_Main_Video( )表契约接口
        /// </summary>
        public ICarMainVideoDao ICarMainVideoDao
        {
            get
            {
                if (_ICarMainVideoDao == null)
                {
                    _ICarMainVideoDao = this.DALIocTool.Get<ICarMainVideoDao>();
                }
                return _ICarMainVideoDao;
            }
        }

        ICarMainItemDao _ICarMainItemDao;
        /// <summary>
        /// Car_MainItem(指定车辆表)表契约接口
        /// </summary>
        public ICarMainItemDao ICarMainItemDao
        {
            get
            {
                if (_ICarMainItemDao == null)
                {
                    _ICarMainItemDao = this.DALIocTool.Get<ICarMainItemDao>();
                }
                return _ICarMainItemDao;
            }
        }

        ICarMainItemBaseDao _ICarMainItemBaseDao;
        /// <summary>
        /// Car_MainItem_Base(车辆基本参数)表契约接口
        /// </summary>
        public ICarMainItemBaseDao ICarMainItemBaseDao
        {
            get
            {
                if (_ICarMainItemBaseDao == null)
                {
                    _ICarMainItemBaseDao = this.DALIocTool.Get<ICarMainItemBaseDao>();
                }
                return _ICarMainItemBaseDao;
            }
        }

        ICarMainItemBodyWorkDao _ICarMainItemBodyWorkDao;
        /// <summary>
        /// Car_MainItem_BodyWork(车辆车身参数)表契约接口
        /// </summary>
        public ICarMainItemBodyWorkDao ICarMainItemBodyWorkDao
        {
            get
            {
                if (_ICarMainItemBodyWorkDao == null)
                {
                    _ICarMainItemBodyWorkDao = this.DALIocTool.Get<ICarMainItemBodyWorkDao>();
                }
                return _ICarMainItemBodyWorkDao;
            }
        }

        ICarMainItemBrakingOfWheelDao _ICarMainItemBrakingOfWheelDao;
        /// <summary>
        /// Car_MainItem_BrakingOfWheel(车轮制动参数)表契约接口
        /// </summary>
        public ICarMainItemBrakingOfWheelDao ICarMainItemBrakingOfWheelDao
        {
            get
            {
                if (_ICarMainItemBrakingOfWheelDao == null)
                {
                    _ICarMainItemBrakingOfWheelDao = this.DALIocTool.Get<ICarMainItemBrakingOfWheelDao>();
                }
                return _ICarMainItemBrakingOfWheelDao;
            }
        }

        ICarMainItemChassisSteeringDao _ICarMainItemChassisSteeringDao;
        /// <summary>
        /// Car_MainItem_ChassisSteering(车辆底盘转向参数)表契约接口
        /// </summary>
        public ICarMainItemChassisSteeringDao ICarMainItemChassisSteeringDao
        {
            get
            {
                if (_ICarMainItemChassisSteeringDao == null)
                {
                    _ICarMainItemChassisSteeringDao = this.DALIocTool.Get<ICarMainItemChassisSteeringDao>();
                }
                return _ICarMainItemChassisSteeringDao;
            }
        }

        ICarMainItemEngineDao _ICarMainItemEngineDao;
        /// <summary>
        /// Car_MainItem_Engine(车辆发动机参数)表契约接口
        /// </summary>
        public ICarMainItemEngineDao ICarMainItemEngineDao
        {
            get
            {
                if (_ICarMainItemEngineDao == null)
                {
                    _ICarMainItemEngineDao = this.DALIocTool.Get<ICarMainItemEngineDao>();
                }
                return _ICarMainItemEngineDao;
            }
        }

        ICarMainItemGearBoxDao _ICarMainItemGearBoxDao;
        /// <summary>
        /// Car_MainItem_GearBox(车辆变速箱参数)表契约接口
        /// </summary>
        public ICarMainItemGearBoxDao ICarMainItemGearBoxDao
        {
            get
            {
                if (_ICarMainItemGearBoxDao == null)
                {
                    _ICarMainItemGearBoxDao = this.DALIocTool.Get<ICarMainItemGearBoxDao>();
                }
                return _ICarMainItemGearBoxDao;
            }
        }

        ICarMainItemModelDao _ICarMainItemModelDao;
        /// <summary>
        /// Car_MainItem_Model(车型表)表契约接口
        /// </summary>
        public ICarMainItemModelDao ICarMainItemModelDao
        {
            get
            {
                if (_ICarMainItemModelDao == null)
                {
                    _ICarMainItemModelDao = this.DALIocTool.Get<ICarMainItemModelDao>();
                }
                return _ICarMainItemModelDao;
            }
        }

        ICarMainItemSeriesDao _ICarMainItemSeriesDao;
        /// <summary>
        /// Car_MainItem_Series(车型系统表)表契约接口
        /// </summary>
        public ICarMainItemSeriesDao ICarMainItemSeriesDao
        {
            get
            {
                if (_ICarMainItemSeriesDao == null)
                {
                    _ICarMainItemSeriesDao = this.DALIocTool.Get<ICarMainItemSeriesDao>();
                }
                return _ICarMainItemSeriesDao;
            }
        }

        ICarMainItemToExColorDao _ICarMainItemToExColorDao;
        /// <summary>
        /// Car_MainItemToExColor(车辆外观颜色关系表)表契约接口
        /// </summary>
        public ICarMainItemToExColorDao ICarMainItemToExColorDao
        {
            get
            {
                if (_ICarMainItemToExColorDao == null)
                {
                    _ICarMainItemToExColorDao = this.DALIocTool.Get<ICarMainItemToExColorDao>();
                }
                return _ICarMainItemToExColorDao;
            }
        }

        ICarMainItemToInColorDao _ICarMainItemToInColorDao;
        /// <summary>
        /// Car_MainItemToInColor(车辆内观颜色关系表)表契约接口
        /// </summary>
        public ICarMainItemToInColorDao ICarMainItemToInColorDao
        {
            get
            {
                if (_ICarMainItemToInColorDao == null)
                {
                    _ICarMainItemToInColorDao = this.DALIocTool.Get<ICarMainItemToInColorDao>();
                }
                return _ICarMainItemToInColorDao;
            }
        }

        ICarMainItemToModelDao _ICarMainItemToModelDao;
        /// <summary>
        /// Car_MainItemToModel(车辆与车型关系表)表契约接口
        /// </summary>
        public ICarMainItemToModelDao ICarMainItemToModelDao
        {
            get
            {
                if (_ICarMainItemToModelDao == null)
                {
                    _ICarMainItemToModelDao = this.DALIocTool.Get<ICarMainItemToModelDao>();
                }
                return _ICarMainItemToModelDao;
            }
        }

        ICarMainToStoreMainRefDao _ICarMainToStoreMainRefDao;
        /// <summary>
        /// Car_MainToStore_MainRef(抽象关系表)表契约接口
        /// </summary>
        public ICarMainToStoreMainRefDao ICarMainToStoreMainRefDao
        {
            get
            {
                if (_ICarMainToStoreMainRefDao == null)
                {
                    _ICarMainToStoreMainRefDao = this.DALIocTool.Get<ICarMainToStoreMainRefDao>();
                }
                return _ICarMainToStoreMainRefDao;
            }
        }

        ICarMultiMediaConfigDao _ICarMultiMediaConfigDao;
        /// <summary>
        /// Car_MultiMediaConfig(车辆多媒体配置)表契约接口
        /// </summary>
        public ICarMultiMediaConfigDao ICarMultiMediaConfigDao
        {
            get
            {
                if (_ICarMultiMediaConfigDao == null)
                {
                    _ICarMultiMediaConfigDao = this.DALIocTool.Get<ICarMultiMediaConfigDao>();
                }
                return _ICarMultiMediaConfigDao;
            }
        }

        ICarOtherGoodCarDao _ICarOtherGoodCarDao;
        /// <summary>
        /// Car_OtherGoodCar(其它重磅好车表)表契约接口
        /// </summary>
        public ICarOtherGoodCarDao ICarOtherGoodCarDao
        {
            get
            {
                if (_ICarOtherGoodCarDao == null)
                {
                    _ICarOtherGoodCarDao = this.DALIocTool.Get<ICarOtherGoodCarDao>();
                }
                return _ICarOtherGoodCarDao;
            }
        }

        ICarSeatConfigDao _ICarSeatConfigDao;
        /// <summary>
        /// Car_SeatConfig(座椅配置)表契约接口
        /// </summary>
        public ICarSeatConfigDao ICarSeatConfigDao
        {
            get
            {
                if (_ICarSeatConfigDao == null)
                {
                    _ICarSeatConfigDao = this.DALIocTool.Get<ICarSeatConfigDao>();
                }
                return _ICarSeatConfigDao;
            }
        }

        ICarSecurityEquipDao _ICarSecurityEquipDao;
        /// <summary>
        /// Car_SecurityEquip(车辆安全装备)表契约接口
        /// </summary>
        public ICarSecurityEquipDao ICarSecurityEquipDao
        {
            get
            {
                if (_ICarSecurityEquipDao == null)
                {
                    _ICarSecurityEquipDao = this.DALIocTool.Get<ICarSecurityEquipDao>();
                }
                return _ICarSecurityEquipDao;
            }
        }

        ICarWindowAndRearviewConfigDao _ICarWindowAndRearviewConfigDao;
        /// <summary>
        /// Car_WindowAndRearviewConfig(车辆玻璃/后视镜配置)表契约接口
        /// </summary>
        public ICarWindowAndRearviewConfigDao ICarWindowAndRearviewConfigDao
        {
            get
            {
                if (_ICarWindowAndRearviewConfigDao == null)
                {
                    _ICarWindowAndRearviewConfigDao = this.DALIocTool.Get<ICarWindowAndRearviewConfigDao>();
                }
                return _ICarWindowAndRearviewConfigDao;
            }
        }

        ICategoryMainDao _ICategoryMainDao;
        /// <summary>
        /// Category_Main(分类表)表契约接口
        /// </summary>
        public ICategoryMainDao ICategoryMainDao
        {
            get
            {
                if (_ICategoryMainDao == null)
                {
                    _ICategoryMainDao = this.DALIocTool.Get<ICategoryMainDao>();
                }
                return _ICategoryMainDao;
            }
        }

        IComAbstractLeftTableDao _IComAbstractLeftTableDao;
        /// <summary>
        /// Com_AbstractLeftTable(抽象左表)表契约接口
        /// </summary>
        public IComAbstractLeftTableDao IComAbstractLeftTableDao
        {
            get
            {
                if (_IComAbstractLeftTableDao == null)
                {
                    _IComAbstractLeftTableDao = this.DALIocTool.Get<IComAbstractLeftTableDao>();
                }
                return _IComAbstractLeftTableDao;
            }
        }

        IComAbstractLeftTableToRightTableRefDao _IComAbstractLeftTableToRightTableRefDao;
        /// <summary>
        /// Com_AbstractLeftTableToRightTableRef(抽象关系表)表契约接口
        /// </summary>
        public IComAbstractLeftTableToRightTableRefDao IComAbstractLeftTableToRightTableRefDao
        {
            get
            {
                if (_IComAbstractLeftTableToRightTableRefDao == null)
                {
                    _IComAbstractLeftTableToRightTableRefDao = this.DALIocTool.Get<IComAbstractLeftTableToRightTableRefDao>();
                }
                return _IComAbstractLeftTableToRightTableRefDao;
            }
        }

        IComAbstractRightTableDao _IComAbstractRightTableDao;
        /// <summary>
        /// Com_AbstractRightTable(抽象右表)表契约接口
        /// </summary>
        public IComAbstractRightTableDao IComAbstractRightTableDao
        {
            get
            {
                if (_IComAbstractRightTableDao == null)
                {
                    _IComAbstractRightTableDao = this.DALIocTool.Get<IComAbstractRightTableDao>();
                }
                return _IComAbstractRightTableDao;
            }
        }

        IComClickDao _IComClickDao;
        /// <summary>
        /// Com_Click(点击表)表契约接口
        /// </summary>
        public IComClickDao IComClickDao
        {
            get
            {
                if (_IComClickDao == null)
                {
                    _IComClickDao = this.DALIocTool.Get<IComClickDao>();
                }
                return _IComClickDao;
            }
        }

        IComConfigMainDao _IComConfigMainDao;
        /// <summary>
        /// Com_ConfigMain(通用配置表)表契约接口
        /// </summary>
        public IComConfigMainDao IComConfigMainDao
        {
            get
            {
                if (_IComConfigMainDao == null)
                {
                    _IComConfigMainDao = this.DALIocTool.Get<IComConfigMainDao>();
                }
                return _IComConfigMainDao;
            }
        }

        IComCountDao _IComCountDao;
        /// <summary>
        /// Com_Count(独立计数器主表)表契约接口
        /// </summary>
        public IComCountDao IComCountDao
        {
            get
            {
                if (_IComCountDao == null)
                {
                    _IComCountDao = this.DALIocTool.Get<IComCountDao>();
                }
                return _IComCountDao;
            }
        }

        IComDisplayInfoDao _IComDisplayInfoDao;
        /// <summary>
        /// Com_DisplayInfo(通用展示信息关联表)表契约接口
        /// </summary>
        public IComDisplayInfoDao IComDisplayInfoDao
        {
            get
            {
                if (_IComDisplayInfoDao == null)
                {
                    _IComDisplayInfoDao = this.DALIocTool.Get<IComDisplayInfoDao>();
                }
                return _IComDisplayInfoDao;
            }
        }

        IComDisplayTypeDao _IComDisplayTypeDao;
        /// <summary>
        /// Com_DisplayType(通用展示类型表)表契约接口
        /// </summary>
        public IComDisplayTypeDao IComDisplayTypeDao
        {
            get
            {
                if (_IComDisplayTypeDao == null)
                {
                    _IComDisplayTypeDao = this.DALIocTool.Get<IComDisplayTypeDao>();
                }
                return _IComDisplayTypeDao;
            }
        }

        IComMaxIdDao _IComMaxIdDao;
        /// <summary>
        /// Com_MaxId(通用生成无重复数据值表)表契约接口
        /// </summary>
        public IComMaxIdDao IComMaxIdDao
        {
            get
            {
                if (_IComMaxIdDao == null)
                {
                    _IComMaxIdDao = this.DALIocTool.Get<IComMaxIdDao>();
                }
                return _IComMaxIdDao;
            }
        }

        IComObjectToTagDao _IComObjectToTagDao;
        /// <summary>
        /// Com_ObjectToTag(对象关联标签表)表契约接口
        /// </summary>
        public IComObjectToTagDao IComObjectToTagDao
        {
            get
            {
                if (_IComObjectToTagDao == null)
                {
                    _IComObjectToTagDao = this.DALIocTool.Get<IComObjectToTagDao>();
                }
                return _IComObjectToTagDao;
            }
        }

        IComSiteObjectToTagDao _IComSiteObjectToTagDao;
        /// <summary>
        /// Com_SiteObjectToTag(对象关联标签表)表契约接口
        /// </summary>
        public IComSiteObjectToTagDao IComSiteObjectToTagDao
        {
            get
            {
                if (_IComSiteObjectToTagDao == null)
                {
                    _IComSiteObjectToTagDao = this.DALIocTool.Get<IComSiteObjectToTagDao>();
                }
                return _IComSiteObjectToTagDao;
            }
        }

        IComTagDao _IComTagDao;
        /// <summary>
        /// Com_Tag(标签表)表契约接口
        /// </summary>
        public IComTagDao IComTagDao
        {
            get
            {
                if (_IComTagDao == null)
                {
                    _IComTagDao = this.DALIocTool.Get<IComTagDao>();
                }
                return _IComTagDao;
            }
        }

        ICommonAddressAreaDao _ICommonAddressAreaDao;
        /// <summary>
        /// Common_Address_Area(镇级)表契约接口
        /// </summary>
        public ICommonAddressAreaDao ICommonAddressAreaDao
        {
            get
            {
                if (_ICommonAddressAreaDao == null)
                {
                    _ICommonAddressAreaDao = this.DALIocTool.Get<ICommonAddressAreaDao>();
                }
                return _ICommonAddressAreaDao;
            }
        }

        ICommonAddressCityDao _ICommonAddressCityDao;
        /// <summary>
        /// Common_Address_City(市区)表契约接口
        /// </summary>
        public ICommonAddressCityDao ICommonAddressCityDao
        {
            get
            {
                if (_ICommonAddressCityDao == null)
                {
                    _ICommonAddressCityDao = this.DALIocTool.Get<ICommonAddressCityDao>();
                }
                return _ICommonAddressCityDao;
            }
        }

        ICommonAddressProvinceDao _ICommonAddressProvinceDao;
        /// <summary>
        /// Common_Address_Province(省份)表契约接口
        /// </summary>
        public ICommonAddressProvinceDao ICommonAddressProvinceDao
        {
            get
            {
                if (_ICommonAddressProvinceDao == null)
                {
                    _ICommonAddressProvinceDao = this.DALIocTool.Get<ICommonAddressProvinceDao>();
                }
                return _ICommonAddressProvinceDao;
            }
        }

        ICommonUploadsDao _ICommonUploadsDao;
        /// <summary>
        /// Common_Uploads()表契约接口
        /// </summary>
        public ICommonUploadsDao ICommonUploadsDao
        {
            get
            {
                if (_ICommonUploadsDao == null)
                {
                    _ICommonUploadsDao = this.DALIocTool.Get<ICommonUploadsDao>();
                }
                return _ICommonUploadsDao;
            }
        }

        IConfigHotCityDao _IConfigHotCityDao;
        /// <summary>
        /// Config_HotCity(热门城市)表契约接口
        /// </summary>
        public IConfigHotCityDao IConfigHotCityDao
        {
            get
            {
                if (_IConfigHotCityDao == null)
                {
                    _IConfigHotCityDao = this.DALIocTool.Get<IConfigHotCityDao>();
                }
                return _IConfigHotCityDao;
            }
        }

        ICWXExplorationActivityMainDao _ICWXExplorationActivityMainDao;
        /// <summary>
        /// CWX_ExplorationActivity_Main(活动表)表契约接口
        /// </summary>
        public ICWXExplorationActivityMainDao ICWXExplorationActivityMainDao
        {
            get
            {
                if (_ICWXExplorationActivityMainDao == null)
                {
                    _ICWXExplorationActivityMainDao = this.DALIocTool.Get<ICWXExplorationActivityMainDao>();
                }
                return _ICWXExplorationActivityMainDao;
            }
        }

        ICWXExplorationActivityOrderUserDao _ICWXExplorationActivityOrderUserDao;
        /// <summary>
        /// CWX_ExplorationActivity_OrderUser(活动表)表契约接口
        /// </summary>
        public ICWXExplorationActivityOrderUserDao ICWXExplorationActivityOrderUserDao
        {
            get
            {
                if (_ICWXExplorationActivityOrderUserDao == null)
                {
                    _ICWXExplorationActivityOrderUserDao = this.DALIocTool.Get<ICWXExplorationActivityOrderUserDao>();
                }
                return _ICWXExplorationActivityOrderUserDao;
            }
        }

        ICWXLotteryHistoryDao _ICWXLotteryHistoryDao;
        /// <summary>
        /// CWX_LotteryHistory(活动抽奖历史表)表契约接口
        /// </summary>
        public ICWXLotteryHistoryDao ICWXLotteryHistoryDao
        {
            get
            {
                if (_ICWXLotteryHistoryDao == null)
                {
                    _ICWXLotteryHistoryDao = this.DALIocTool.Get<ICWXLotteryHistoryDao>();
                }
                return _ICWXLotteryHistoryDao;
            }
        }

        ICWXLotteryMainDao _ICWXLotteryMainDao;
        /// <summary>
        /// CWX_LotteryMain(活动表)表契约接口
        /// </summary>
        public ICWXLotteryMainDao ICWXLotteryMainDao
        {
            get
            {
                if (_ICWXLotteryMainDao == null)
                {
                    _ICWXLotteryMainDao = this.DALIocTool.Get<ICWXLotteryMainDao>();
                }
                return _ICWXLotteryMainDao;
            }
        }

        ICWXLotteryPrizeDao _ICWXLotteryPrizeDao;
        /// <summary>
        /// CWX_LotteryPrize(活动奖品表)表契约接口
        /// </summary>
        public ICWXLotteryPrizeDao ICWXLotteryPrizeDao
        {
            get
            {
                if (_ICWXLotteryPrizeDao == null)
                {
                    _ICWXLotteryPrizeDao = this.DALIocTool.Get<ICWXLotteryPrizeDao>();
                }
                return _ICWXLotteryPrizeDao;
            }
        }

        ICWXLotteryUserPrizeDao _ICWXLotteryUserPrizeDao;
        /// <summary>
        /// CWX_LotteryUserPrize(活动中奖人员表)表契约接口
        /// </summary>
        public ICWXLotteryUserPrizeDao ICWXLotteryUserPrizeDao
        {
            get
            {
                if (_ICWXLotteryUserPrizeDao == null)
                {
                    _ICWXLotteryUserPrizeDao = this.DALIocTool.Get<ICWXLotteryUserPrizeDao>();
                }
                return _ICWXLotteryUserPrizeDao;
            }
        }

        ICWXRepairOrderDao _ICWXRepairOrderDao;
        /// <summary>
        /// CWX_RepairOrder()表契约接口
        /// </summary>
        public ICWXRepairOrderDao ICWXRepairOrderDao
        {
            get
            {
                if (_ICWXRepairOrderDao == null)
                {
                    _ICWXRepairOrderDao = this.DALIocTool.Get<ICWXRepairOrderDao>();
                }
                return _ICWXRepairOrderDao;
            }
        }

        ICWXWeiXinApplicationDao _ICWXWeiXinApplicationDao;
        /// <summary>
        /// CWX_WeiXinApplication(微信程序信息表)表契约接口
        /// </summary>
        public ICWXWeiXinApplicationDao ICWXWeiXinApplicationDao
        {
            get
            {
                if (_ICWXWeiXinApplicationDao == null)
                {
                    _ICWXWeiXinApplicationDao = this.DALIocTool.Get<ICWXWeiXinApplicationDao>();
                }
                return _ICWXWeiXinApplicationDao;
            }
        }

        ICWXWeiXinMenuDao _ICWXWeiXinMenuDao;
        /// <summary>
        /// CWX_WeiXinMenu(微信菜单表)表契约接口
        /// </summary>
        public ICWXWeiXinMenuDao ICWXWeiXinMenuDao
        {
            get
            {
                if (_ICWXWeiXinMenuDao == null)
                {
                    _ICWXWeiXinMenuDao = this.DALIocTool.Get<ICWXWeiXinMenuDao>();
                }
                return _ICWXWeiXinMenuDao;
            }
        }

        IDisplayHomePriceChartDao _IDisplayHomePriceChartDao;
        /// <summary>
        /// Display_HomePriceChart(首页报价表)表契约接口
        /// </summary>
        public IDisplayHomePriceChartDao IDisplayHomePriceChartDao
        {
            get
            {
                if (_IDisplayHomePriceChartDao == null)
                {
                    _IDisplayHomePriceChartDao = this.DALIocTool.Get<IDisplayHomePriceChartDao>();
                }
                return _IDisplayHomePriceChartDao;
            }
        }

        IDisplayHomePriceChartDistributorAdvertDao _IDisplayHomePriceChartDistributorAdvertDao;
        /// <summary>
        /// Display_HomePriceChartDistributorAdvert(首页报价经销商广告表)表契约接口
        /// </summary>
        public IDisplayHomePriceChartDistributorAdvertDao IDisplayHomePriceChartDistributorAdvertDao
        {
            get
            {
                if (_IDisplayHomePriceChartDistributorAdvertDao == null)
                {
                    _IDisplayHomePriceChartDistributorAdvertDao = this.DALIocTool.Get<IDisplayHomePriceChartDistributorAdvertDao>();
                }
                return _IDisplayHomePriceChartDistributorAdvertDao;
            }
        }

        IDisplayHomePriceChartTypeDao _IDisplayHomePriceChartTypeDao;
        /// <summary>
        /// Display_HomePriceChartType(首页报价类型表)表契约接口
        /// </summary>
        public IDisplayHomePriceChartTypeDao IDisplayHomePriceChartTypeDao
        {
            get
            {
                if (_IDisplayHomePriceChartTypeDao == null)
                {
                    _IDisplayHomePriceChartTypeDao = this.DALIocTool.Get<IDisplayHomePriceChartTypeDao>();
                }
                return _IDisplayHomePriceChartTypeDao;
            }
        }

        IDisplayIndexAdvertDao _IDisplayIndexAdvertDao;
        /// <summary>
        /// Display_IndexAdvert(首页广告)表契约接口
        /// </summary>
        public IDisplayIndexAdvertDao IDisplayIndexAdvertDao
        {
            get
            {
                if (_IDisplayIndexAdvertDao == null)
                {
                    _IDisplayIndexAdvertDao = this.DALIocTool.Get<IDisplayIndexAdvertDao>();
                }
                return _IDisplayIndexAdvertDao;
            }
        }

        IDisplayPhotoAlbumsDao _IDisplayPhotoAlbumsDao;
        /// <summary>
        /// Display_PhotoAlbums(相册表)表契约接口
        /// </summary>
        public IDisplayPhotoAlbumsDao IDisplayPhotoAlbumsDao
        {
            get
            {
                if (_IDisplayPhotoAlbumsDao == null)
                {
                    _IDisplayPhotoAlbumsDao = this.DALIocTool.Get<IDisplayPhotoAlbumsDao>();
                }
                return _IDisplayPhotoAlbumsDao;
            }
        }

        IDisplayPhotoAlbumsToPhotosDao _IDisplayPhotoAlbumsToPhotosDao;
        /// <summary>
        /// Display_PhotoAlbumsToPhotos(相册表)表契约接口
        /// </summary>
        public IDisplayPhotoAlbumsToPhotosDao IDisplayPhotoAlbumsToPhotosDao
        {
            get
            {
                if (_IDisplayPhotoAlbumsToPhotosDao == null)
                {
                    _IDisplayPhotoAlbumsToPhotosDao = this.DALIocTool.Get<IDisplayPhotoAlbumsToPhotosDao>();
                }
                return _IDisplayPhotoAlbumsToPhotosDao;
            }
        }

        IDisplayPhotoAlbumsTypeDao _IDisplayPhotoAlbumsTypeDao;
        /// <summary>
        /// Display_PhotoAlbumsType(相册类型表)表契约接口
        /// </summary>
        public IDisplayPhotoAlbumsTypeDao IDisplayPhotoAlbumsTypeDao
        {
            get
            {
                if (_IDisplayPhotoAlbumsTypeDao == null)
                {
                    _IDisplayPhotoAlbumsTypeDao = this.DALIocTool.Get<IDisplayPhotoAlbumsTypeDao>();
                }
                return _IDisplayPhotoAlbumsTypeDao;
            }
        }

        IdtAdbannerDao _IdtAdbannerDao;
        /// <summary>
        /// dt_Adbanner()表契约接口
        /// </summary>
        public IdtAdbannerDao IdtAdbannerDao
        {
            get
            {
                if (_IdtAdbannerDao == null)
                {
                    _IdtAdbannerDao = this.DALIocTool.Get<IdtAdbannerDao>();
                }
                return _IdtAdbannerDao;
            }
        }

        IdtAdministratorDao _IdtAdministratorDao;
        /// <summary>
        /// dt_Administrator()表契约接口
        /// </summary>
        public IdtAdministratorDao IdtAdministratorDao
        {
            get
            {
                if (_IdtAdministratorDao == null)
                {
                    _IdtAdministratorDao = this.DALIocTool.Get<IdtAdministratorDao>();
                }
                return _IdtAdministratorDao;
            }
        }

        IdtAdvertisingDao _IdtAdvertisingDao;
        /// <summary>
        /// dt_Advertising()表契约接口
        /// </summary>
        public IdtAdvertisingDao IdtAdvertisingDao
        {
            get
            {
                if (_IdtAdvertisingDao == null)
                {
                    _IdtAdvertisingDao = this.DALIocTool.Get<IdtAdvertisingDao>();
                }
                return _IdtAdvertisingDao;
            }
        }

        IdtAllReviewsDao _IdtAllReviewsDao;
        /// <summary>
        /// dt_AllReviews()表契约接口
        /// </summary>
        public IdtAllReviewsDao IdtAllReviewsDao
        {
            get
            {
                if (_IdtAllReviewsDao == null)
                {
                    _IdtAllReviewsDao = this.DALIocTool.Get<IdtAllReviewsDao>();
                }
                return _IdtAllReviewsDao;
            }
        }

        IdtArticleDao _IdtArticleDao;
        /// <summary>
        /// dt_Article()表契约接口
        /// </summary>
        public IdtArticleDao IdtArticleDao
        {
            get
            {
                if (_IdtArticleDao == null)
                {
                    _IdtArticleDao = this.DALIocTool.Get<IdtArticleDao>();
                }
                return _IdtArticleDao;
            }
        }

        IdtChannelDao _IdtChannelDao;
        /// <summary>
        /// dt_Channel()表契约接口
        /// </summary>
        public IdtChannelDao IdtChannelDao
        {
            get
            {
                if (_IdtChannelDao == null)
                {
                    _IdtChannelDao = this.DALIocTool.Get<IdtChannelDao>();
                }
                return _IdtChannelDao;
            }
        }

        IdtContentsDao _IdtContentsDao;
        /// <summary>
        /// dt_Contents()表契约接口
        /// </summary>
        public IdtContentsDao IdtContentsDao
        {
            get
            {
                if (_IdtContentsDao == null)
                {
                    _IdtContentsDao = this.DALIocTool.Get<IdtContentsDao>();
                }
                return _IdtContentsDao;
            }
        }

        IdtDownloadsDao _IdtDownloadsDao;
        /// <summary>
        /// dt_Downloads()表契约接口
        /// </summary>
        public IdtDownloadsDao IdtDownloadsDao
        {
            get
            {
                if (_IdtDownloadsDao == null)
                {
                    _IdtDownloadsDao = this.DALIocTool.Get<IdtDownloadsDao>();
                }
                return _IdtDownloadsDao;
            }
        }

        IdtFeedbackDao _IdtFeedbackDao;
        /// <summary>
        /// dt_Feedback()表契约接口
        /// </summary>
        public IdtFeedbackDao IdtFeedbackDao
        {
            get
            {
                if (_IdtFeedbackDao == null)
                {
                    _IdtFeedbackDao = this.DALIocTool.Get<IdtFeedbackDao>();
                }
                return _IdtFeedbackDao;
            }
        }

        IdtLinksDao _IdtLinksDao;
        /// <summary>
        /// dt_Links()表契约接口
        /// </summary>
        public IdtLinksDao IdtLinksDao
        {
            get
            {
                if (_IdtLinksDao == null)
                {
                    _IdtLinksDao = this.DALIocTool.Get<IdtLinksDao>();
                }
                return _IdtLinksDao;
            }
        }

        IdtMessageCountStaticDao _IdtMessageCountStaticDao;
        /// <summary>
        /// dt_MessageCountStatic()表契约接口
        /// </summary>
        public IdtMessageCountStaticDao IdtMessageCountStaticDao
        {
            get
            {
                if (_IdtMessageCountStaticDao == null)
                {
                    _IdtMessageCountStaticDao = this.DALIocTool.Get<IdtMessageCountStaticDao>();
                }
                return _IdtMessageCountStaticDao;
            }
        }

        IdtPicturesDao _IdtPicturesDao;
        /// <summary>
        /// dt_Pictures()表契约接口
        /// </summary>
        public IdtPicturesDao IdtPicturesDao
        {
            get
            {
                if (_IdtPicturesDao == null)
                {
                    _IdtPicturesDao = this.DALIocTool.Get<IdtPicturesDao>();
                }
                return _IdtPicturesDao;
            }
        }

        IdtPicturesAlbumDao _IdtPicturesAlbumDao;
        /// <summary>
        /// dt_PicturesAlbum()表契约接口
        /// </summary>
        public IdtPicturesAlbumDao IdtPicturesAlbumDao
        {
            get
            {
                if (_IdtPicturesAlbumDao == null)
                {
                    _IdtPicturesAlbumDao = this.DALIocTool.Get<IdtPicturesAlbumDao>();
                }
                return _IdtPicturesAlbumDao;
            }
        }

        IdtPicturesExtensionDao _IdtPicturesExtensionDao;
        /// <summary>
        /// dt_PicturesExtension()表契约接口
        /// </summary>
        public IdtPicturesExtensionDao IdtPicturesExtensionDao
        {
            get
            {
                if (_IdtPicturesExtensionDao == null)
                {
                    _IdtPicturesExtensionDao = this.DALIocTool.Get<IdtPicturesExtensionDao>();
                }
                return _IdtPicturesExtensionDao;
            }
        }

        IdtPicturesFieldDao _IdtPicturesFieldDao;
        /// <summary>
        /// dt_PicturesField()表契约接口
        /// </summary>
        public IdtPicturesFieldDao IdtPicturesFieldDao
        {
            get
            {
                if (_IdtPicturesFieldDao == null)
                {
                    _IdtPicturesFieldDao = this.DALIocTool.Get<IdtPicturesFieldDao>();
                }
                return _IdtPicturesFieldDao;
            }
        }

        IdtSystemLogDao _IdtSystemLogDao;
        /// <summary>
        /// dt_SystemLog()表契约接口
        /// </summary>
        public IdtSystemLogDao IdtSystemLogDao
        {
            get
            {
                if (_IdtSystemLogDao == null)
                {
                    _IdtSystemLogDao = this.DALIocTool.Get<IdtSystemLogDao>();
                }
                return _IdtSystemLogDao;
            }
        }

        ILeagueInfoDao _ILeagueInfoDao;
        /// <summary>
        /// LeagueInfo()表契约接口
        /// </summary>
        public ILeagueInfoDao ILeagueInfoDao
        {
            get
            {
                if (_ILeagueInfoDao == null)
                {
                    _ILeagueInfoDao = this.DALIocTool.Get<ILeagueInfoDao>();
                }
                return _ILeagueInfoDao;
            }
        }

        IMaintImageDao _IMaintImageDao;
        /// <summary>
        /// Maint_Image()表契约接口
        /// </summary>
        public IMaintImageDao IMaintImageDao
        {
            get
            {
                if (_IMaintImageDao == null)
                {
                    _IMaintImageDao = this.DALIocTool.Get<IMaintImageDao>();
                }
                return _IMaintImageDao;
            }
        }

        IMaintMainDao _IMaintMainDao;
        /// <summary>
        /// Maint_Main()表契约接口
        /// </summary>
        public IMaintMainDao IMaintMainDao
        {
            get
            {
                if (_IMaintMainDao == null)
                {
                    _IMaintMainDao = this.DALIocTool.Get<IMaintMainDao>();
                }
                return _IMaintMainDao;
            }
        }

        IMaintMaintItemDao _IMaintMaintItemDao;
        /// <summary>
        /// Maint_MaintItem()表契约接口
        /// </summary>
        public IMaintMaintItemDao IMaintMaintItemDao
        {
            get
            {
                if (_IMaintMaintItemDao == null)
                {
                    _IMaintMaintItemDao = this.DALIocTool.Get<IMaintMaintItemDao>();
                }
                return _IMaintMaintItemDao;
            }
        }

        IMallAdvertisementDao _IMallAdvertisementDao;
        /// <summary>
        /// Mall_Advertisement()表契约接口
        /// </summary>
        public IMallAdvertisementDao IMallAdvertisementDao
        {
            get
            {
                if (_IMallAdvertisementDao == null)
                {
                    _IMallAdvertisementDao = this.DALIocTool.Get<IMallAdvertisementDao>();
                }
                return _IMallAdvertisementDao;
            }
        }

        IMallGoodsDao _IMallGoodsDao;
        /// <summary>
        /// Mall_Goods()表契约接口
        /// </summary>
        public IMallGoodsDao IMallGoodsDao
        {
            get
            {
                if (_IMallGoodsDao == null)
                {
                    _IMallGoodsDao = this.DALIocTool.Get<IMallGoodsDao>();
                }
                return _IMallGoodsDao;
            }
        }

        IMallGoodsImgDao _IMallGoodsImgDao;
        /// <summary>
        /// Mall_GoodsImg()表契约接口
        /// </summary>
        public IMallGoodsImgDao IMallGoodsImgDao
        {
            get
            {
                if (_IMallGoodsImgDao == null)
                {
                    _IMallGoodsImgDao = this.DALIocTool.Get<IMallGoodsImgDao>();
                }
                return _IMallGoodsImgDao;
            }
        }

        IMemberAccountDao _IMemberAccountDao;
        /// <summary>
        /// Member_Account(会员账号信息)表契约接口
        /// </summary>
        public IMemberAccountDao IMemberAccountDao
        {
            get
            {
                if (_IMemberAccountDao == null)
                {
                    _IMemberAccountDao = this.DALIocTool.Get<IMemberAccountDao>();
                }
                return _IMemberAccountDao;
            }
        }

        IMemberCarInfoDao _IMemberCarInfoDao;
        /// <summary>
        /// Member_CarInfo(会员车辆信息)表契约接口
        /// </summary>
        public IMemberCarInfoDao IMemberCarInfoDao
        {
            get
            {
                if (_IMemberCarInfoDao == null)
                {
                    _IMemberCarInfoDao = this.DALIocTool.Get<IMemberCarInfoDao>();
                }
                return _IMemberCarInfoDao;
            }
        }

        IMemberEmailUpdateHistoryDao _IMemberEmailUpdateHistoryDao;
        /// <summary>
        /// Member_EmailUpdateHistory(会员账号信息)表契约接口
        /// </summary>
        public IMemberEmailUpdateHistoryDao IMemberEmailUpdateHistoryDao
        {
            get
            {
                if (_IMemberEmailUpdateHistoryDao == null)
                {
                    _IMemberEmailUpdateHistoryDao = this.DALIocTool.Get<IMemberEmailUpdateHistoryDao>();
                }
                return _IMemberEmailUpdateHistoryDao;
            }
        }

        IMemberProfileDao _IMemberProfileDao;
        /// <summary>
        /// Member_Profile(会员资料表)表契约接口
        /// </summary>
        public IMemberProfileDao IMemberProfileDao
        {
            get
            {
                if (_IMemberProfileDao == null)
                {
                    _IMemberProfileDao = this.DALIocTool.Get<IMemberProfileDao>();
                }
                return _IMemberProfileDao;
            }
        }

        IMemberProfileToSiteDao _IMemberProfileToSiteDao;
        /// <summary>
        /// Member_ProfileToSite(会员开通站点信息)表契约接口
        /// </summary>
        public IMemberProfileToSiteDao IMemberProfileToSiteDao
        {
            get
            {
                if (_IMemberProfileToSiteDao == null)
                {
                    _IMemberProfileToSiteDao = this.DALIocTool.Get<IMemberProfileToSiteDao>();
                }
                return _IMemberProfileToSiteDao;
            }
        }

        IMemberProfileToSiteCarDao _IMemberProfileToSiteCarDao;
        /// <summary>
        /// Member_ProfileToSiteCar()表契约接口
        /// </summary>
        public IMemberProfileToSiteCarDao IMemberProfileToSiteCarDao
        {
            get
            {
                if (_IMemberProfileToSiteCarDao == null)
                {
                    _IMemberProfileToSiteCarDao = this.DALIocTool.Get<IMemberProfileToSiteCarDao>();
                }
                return _IMemberProfileToSiteCarDao;
            }
        }

        IMemberMessageDao _IMemberMessageDao;
        /// <summary>
        /// MemberMessage()表契约接口
        /// </summary>
        public IMemberMessageDao IMemberMessageDao
        {
            get
            {
                if (_IMemberMessageDao == null)
                {
                    _IMemberMessageDao = this.DALIocTool.Get<IMemberMessageDao>();
                }
                return _IMemberMessageDao;
            }
        }

        IMemberMessageReciverDao _IMemberMessageReciverDao;
        /// <summary>
        /// MemberMessageReciver()表契约接口
        /// </summary>
        public IMemberMessageReciverDao IMemberMessageReciverDao
        {
            get
            {
                if (_IMemberMessageReciverDao == null)
                {
                    _IMemberMessageReciverDao = this.DALIocTool.Get<IMemberMessageReciverDao>();
                }
                return _IMemberMessageReciverDao;
            }
        }

        IPluginsDataRefDao _IPluginsDataRefDao;
        /// <summary>
        /// Plugins_Data_Ref(第三方数据映射表)表契约接口
        /// </summary>
        public IPluginsDataRefDao IPluginsDataRefDao
        {
            get
            {
                if (_IPluginsDataRefDao == null)
                {
                    _IPluginsDataRefDao = this.DALIocTool.Get<IPluginsDataRefDao>();
                }
                return _IPluginsDataRefDao;
            }
        }

        IPrestigeImpressionDao _IPrestigeImpressionDao;
        /// <summary>
        /// Prestige_Impression(口啤印象表)表契约接口
        /// </summary>
        public IPrestigeImpressionDao IPrestigeImpressionDao
        {
            get
            {
                if (_IPrestigeImpressionDao == null)
                {
                    _IPrestigeImpressionDao = this.DALIocTool.Get<IPrestigeImpressionDao>();
                }
                return _IPrestigeImpressionDao;
            }
        }

        IPrestigePostDao _IPrestigePostDao;
        /// <summary>
        /// Prestige_Post(车辆口碑帖子)表契约接口
        /// </summary>
        public IPrestigePostDao IPrestigePostDao
        {
            get
            {
                if (_IPrestigePostDao == null)
                {
                    _IPrestigePostDao = this.DALIocTool.Get<IPrestigePostDao>();
                }
                return _IPrestigePostDao;
            }
        }

        IPrestigePostCollectionDao _IPrestigePostCollectionDao;
        /// <summary>
        /// Prestige_PostCollection(口碑收藏表)表契约接口
        /// </summary>
        public IPrestigePostCollectionDao IPrestigePostCollectionDao
        {
            get
            {
                if (_IPrestigePostCollectionDao == null)
                {
                    _IPrestigePostCollectionDao = this.DALIocTool.Get<IPrestigePostCollectionDao>();
                }
                return _IPrestigePostCollectionDao;
            }
        }

        IPrestigePostImageDao _IPrestigePostImageDao;
        /// <summary>
        /// Prestige_PostImage(口碑图片表)表契约接口
        /// </summary>
        public IPrestigePostImageDao IPrestigePostImageDao
        {
            get
            {
                if (_IPrestigePostImageDao == null)
                {
                    _IPrestigePostImageDao = this.DALIocTool.Get<IPrestigePostImageDao>();
                }
                return _IPrestigePostImageDao;
            }
        }

        IPromotionActivityDao _IPromotionActivityDao;
        /// <summary>
        /// Promotion_Activity()表契约接口
        /// </summary>
        public IPromotionActivityDao IPromotionActivityDao
        {
            get
            {
                if (_IPromotionActivityDao == null)
                {
                    _IPromotionActivityDao = this.DALIocTool.Get<IPromotionActivityDao>();
                }
                return _IPromotionActivityDao;
            }
        }

        IPromotionActivityToCarSalesPromitionDao _IPromotionActivityToCarSalesPromitionDao;
        /// <summary>
        /// Promotion_Activity_To_CarSalesPromition()表契约接口
        /// </summary>
        public IPromotionActivityToCarSalesPromitionDao IPromotionActivityToCarSalesPromitionDao
        {
            get
            {
                if (_IPromotionActivityToCarSalesPromitionDao == null)
                {
                    _IPromotionActivityToCarSalesPromitionDao = this.DALIocTool.Get<IPromotionActivityToCarSalesPromitionDao>();
                }
                return _IPromotionActivityToCarSalesPromitionDao;
            }
        }

        IRepairOrdersDao _IRepairOrdersDao;
        /// <summary>
        /// Repair_Orders(维修消费记录)表契约接口
        /// </summary>
        public IRepairOrdersDao IRepairOrdersDao
        {
            get
            {
                if (_IRepairOrdersDao == null)
                {
                    _IRepairOrdersDao = this.DALIocTool.Get<IRepairOrdersDao>();
                }
                return _IRepairOrdersDao;
            }
        }

        IRepairSetDao _IRepairSetDao;
        /// <summary>
        /// Repair_Set(维修套餐表)表契约接口
        /// </summary>
        public IRepairSetDao IRepairSetDao
        {
            get
            {
                if (_IRepairSetDao == null)
                {
                    _IRepairSetDao = this.DALIocTool.Get<IRepairSetDao>();
                }
                return _IRepairSetDao;
            }
        }

        IRepairSetTodtFeedbackDao _IRepairSetTodtFeedbackDao;
        /// <summary>
        /// Repair_SetTodt_Feedback(维修套餐预约关系表)表契约接口
        /// </summary>
        public IRepairSetTodtFeedbackDao IRepairSetTodtFeedbackDao
        {
            get
            {
                if (_IRepairSetTodtFeedbackDao == null)
                {
                    _IRepairSetTodtFeedbackDao = this.DALIocTool.Get<IRepairSetTodtFeedbackDao>();
                }
                return _IRepairSetTodtFeedbackDao;
            }
        }

        IRepairSetToTCarServiceDao _IRepairSetToTCarServiceDao;
        /// <summary>
        /// Repair_SetToT_CarService(维修套餐对维修工时表)表契约接口
        /// </summary>
        public IRepairSetToTCarServiceDao IRepairSetToTCarServiceDao
        {
            get
            {
                if (_IRepairSetToTCarServiceDao == null)
                {
                    _IRepairSetToTCarServiceDao = this.DALIocTool.Get<IRepairSetToTCarServiceDao>();
                }
                return _IRepairSetToTCarServiceDao;
            }
        }

        IRepairSetToTCounterPartDao _IRepairSetToTCounterPartDao;
        /// <summary>
        /// Repair_SetToT_CounterPart(维修套餐对维修配件表)表契约接口
        /// </summary>
        public IRepairSetToTCounterPartDao IRepairSetToTCounterPartDao
        {
            get
            {
                if (_IRepairSetToTCounterPartDao == null)
                {
                    _IRepairSetToTCounterPartDao = this.DALIocTool.Get<IRepairSetToTCounterPartDao>();
                }
                return _IRepairSetToTCounterPartDao;
            }
        }

        IRepairSetTripDistanceDao _IRepairSetTripDistanceDao;
        /// <summary>
        /// Repair_SetTripDistance(维修套餐行驶里程表)表契约接口
        /// </summary>
        public IRepairSetTripDistanceDao IRepairSetTripDistanceDao
        {
            get
            {
                if (_IRepairSetTripDistanceDao == null)
                {
                    _IRepairSetTripDistanceDao = this.DALIocTool.Get<IRepairSetTripDistanceDao>();
                }
                return _IRepairSetTripDistanceDao;
            }
        }

        IRepairSetTripTimeDao _IRepairSetTripTimeDao;
        /// <summary>
        /// Repair_SetTripTime(维修套餐行驶时间表)表契约接口
        /// </summary>
        public IRepairSetTripTimeDao IRepairSetTripTimeDao
        {
            get
            {
                if (_IRepairSetTripTimeDao == null)
                {
                    _IRepairSetTripTimeDao = this.DALIocTool.Get<IRepairSetTripTimeDao>();
                }
                return _IRepairSetTripTimeDao;
            }
        }

        ISiteCarImageDao _ISiteCarImageDao;
        /// <summary>
        /// Site_CarImage(汽车之家关系表)表契约接口
        /// </summary>
        public ISiteCarImageDao ISiteCarImageDao
        {
            get
            {
                if (_ISiteCarImageDao == null)
                {
                    _ISiteCarImageDao = this.DALIocTool.Get<ISiteCarImageDao>();
                }
                return _ISiteCarImageDao;
            }
        }

        ISmsMainDao _ISmsMainDao;
        /// <summary>
        /// Sms_Main(短信表)表契约接口
        /// </summary>
        public ISmsMainDao ISmsMainDao
        {
            get
            {
                if (_ISmsMainDao == null)
                {
                    _ISmsMainDao = this.DALIocTool.Get<ISmsMainDao>();
                }
                return _ISmsMainDao;
            }
        }

        IStoreCommentDao _IStoreCommentDao;
        /// <summary>
        /// Store_Comment( )表契约接口
        /// </summary>
        public IStoreCommentDao IStoreCommentDao
        {
            get
            {
                if (_IStoreCommentDao == null)
                {
                    _IStoreCommentDao = this.DALIocTool.Get<IStoreCommentDao>();
                }
                return _IStoreCommentDao;
            }
        }

        IStoreMainDao _IStoreMainDao;
        /// <summary>
        /// Store_Main()表契约接口
        /// </summary>
        public IStoreMainDao IStoreMainDao
        {
            get
            {
                if (_IStoreMainDao == null)
                {
                    _IStoreMainDao = this.DALIocTool.Get<IStoreMainDao>();
                }
                return _IStoreMainDao;
            }
        }

        IStoreMainBrandDao _IStoreMainBrandDao;
        /// <summary>
        /// Store_MainBrand()表契约接口
        /// </summary>
        public IStoreMainBrandDao IStoreMainBrandDao
        {
            get
            {
                if (_IStoreMainBrandDao == null)
                {
                    _IStoreMainBrandDao = this.DALIocTool.Get<IStoreMainBrandDao>();
                }
                return _IStoreMainBrandDao;
            }
        }

        IStoreMainGoodCarDao _IStoreMainGoodCarDao;
        /// <summary>
        /// Store_MainGoodCar( )表契约接口
        /// </summary>
        public IStoreMainGoodCarDao IStoreMainGoodCarDao
        {
            get
            {
                if (_IStoreMainGoodCarDao == null)
                {
                    _IStoreMainGoodCarDao = this.DALIocTool.Get<IStoreMainGoodCarDao>();
                }
                return _IStoreMainGoodCarDao;
            }
        }

        IStoreMainImageDao _IStoreMainImageDao;
        /// <summary>
        /// Store_MainImage( )表契约接口
        /// </summary>
        public IStoreMainImageDao IStoreMainImageDao
        {
            get
            {
                if (_IStoreMainImageDao == null)
                {
                    _IStoreMainImageDao = this.DALIocTool.Get<IStoreMainImageDao>();
                }
                return _IStoreMainImageDao;
            }
        }

        IStoreOrderDrivingTestDao _IStoreOrderDrivingTestDao;
        /// <summary>
        /// Store_OrderDrivingTest( )表契约接口
        /// </summary>
        public IStoreOrderDrivingTestDao IStoreOrderDrivingTestDao
        {
            get
            {
                if (_IStoreOrderDrivingTestDao == null)
                {
                    _IStoreOrderDrivingTestDao = this.DALIocTool.Get<IStoreOrderDrivingTestDao>();
                }
                return _IStoreOrderDrivingTestDao;
            }
        }

        ISysCenterToSiteTableDao _ISysCenterToSiteTableDao;
        /// <summary>
        /// Sys_CenterToSiteTable()表契约接口
        /// </summary>
        public ISysCenterToSiteTableDao ISysCenterToSiteTableDao
        {
            get
            {
                if (_ISysCenterToSiteTableDao == null)
                {
                    _ISysCenterToSiteTableDao = this.DALIocTool.Get<ISysCenterToSiteTableDao>();
                }
                return _ISysCenterToSiteTableDao;
            }
        }

        ITActivityDao _ITActivityDao;
        /// <summary>
        /// T_Activity()表契约接口
        /// </summary>
        public ITActivityDao ITActivityDao
        {
            get
            {
                if (_ITActivityDao == null)
                {
                    _ITActivityDao = this.DALIocTool.Get<ITActivityDao>();
                }
                return _ITActivityDao;
            }
        }

        ITActivityGuestItemDao _ITActivityGuestItemDao;
        /// <summary>
        /// T_ActivityGuestItem()表契约接口
        /// </summary>
        public ITActivityGuestItemDao ITActivityGuestItemDao
        {
            get
            {
                if (_ITActivityGuestItemDao == null)
                {
                    _ITActivityGuestItemDao = this.DALIocTool.Get<ITActivityGuestItemDao>();
                }
                return _ITActivityGuestItemDao;
            }
        }

        ITAdditionServiceDao _ITAdditionServiceDao;
        /// <summary>
        /// T_AdditionService()表契约接口
        /// </summary>
        public ITAdditionServiceDao ITAdditionServiceDao
        {
            get
            {
                if (_ITAdditionServiceDao == null)
                {
                    _ITAdditionServiceDao = this.DALIocTool.Get<ITAdditionServiceDao>();
                }
                return _ITAdditionServiceDao;
            }
        }

        ItareaDao _ItareaDao;
        /// <summary>
        /// t_area()表契约接口
        /// </summary>
        public ItareaDao ItareaDao
        {
            get
            {
                if (_ItareaDao == null)
                {
                    _ItareaDao = this.DALIocTool.Get<ItareaDao>();
                }
                return _ItareaDao;
            }
        }

        Itarea2Dao _Itarea2Dao;
        /// <summary>
        /// t_area2()表契约接口
        /// </summary>
        public Itarea2Dao Itarea2Dao
        {
            get
            {
                if (_Itarea2Dao == null)
                {
                    _Itarea2Dao = this.DALIocTool.Get<Itarea2Dao>();
                }
                return _Itarea2Dao;
            }
        }

        ITCarBrandDao _ITCarBrandDao;
        /// <summary>
        /// T_CarBrand()表契约接口
        /// </summary>
        public ITCarBrandDao ITCarBrandDao
        {
            get
            {
                if (_ITCarBrandDao == null)
                {
                    _ITCarBrandDao = this.DALIocTool.Get<ITCarBrandDao>();
                }
                return _ITCarBrandDao;
            }
        }

        ITCarItemDao _ITCarItemDao;
        /// <summary>
        /// T_CarItem()表契约接口
        /// </summary>
        public ITCarItemDao ITCarItemDao
        {
            get
            {
                if (_ITCarItemDao == null)
                {
                    _ITCarItemDao = this.DALIocTool.Get<ITCarItemDao>();
                }
                return _ITCarItemDao;
            }
        }

        ITCarItemBrandDao _ITCarItemBrandDao;
        /// <summary>
        /// T_CarItemBrand()表契约接口
        /// </summary>
        public ITCarItemBrandDao ITCarItemBrandDao
        {
            get
            {
                if (_ITCarItemBrandDao == null)
                {
                    _ITCarItemBrandDao = this.DALIocTool.Get<ITCarItemBrandDao>();
                }
                return _ITCarItemBrandDao;
            }
        }

        ITCarTypeDao _ITCarTypeDao;
        /// <summary>
        /// T_CarType()表契约接口
        /// </summary>
        public ITCarTypeDao ITCarTypeDao
        {
            get
            {
                if (_ITCarTypeDao == null)
                {
                    _ITCarTypeDao = this.DALIocTool.Get<ITCarTypeDao>();
                }
                return _ITCarTypeDao;
            }
        }

        ITCarTypeBigDao _ITCarTypeBigDao;
        /// <summary>
        /// T_CarTypeBig()表契约接口
        /// </summary>
        public ITCarTypeBigDao ITCarTypeBigDao
        {
            get
            {
                if (_ITCarTypeBigDao == null)
                {
                    _ITCarTypeBigDao = this.DALIocTool.Get<ITCarTypeBigDao>();
                }
                return _ITCarTypeBigDao;
            }
        }

        ITCarTypeBigLvDao _ITCarTypeBigLvDao;
        /// <summary>
        /// T_CarTypeBigLv()表契约接口
        /// </summary>
        public ITCarTypeBigLvDao ITCarTypeBigLvDao
        {
            get
            {
                if (_ITCarTypeBigLvDao == null)
                {
                    _ITCarTypeBigLvDao = this.DALIocTool.Get<ITCarTypeBigLvDao>();
                }
                return _ITCarTypeBigLvDao;
            }
        }

        ItcityDao _ItcityDao;
        /// <summary>
        /// t_city()表契约接口
        /// </summary>
        public ItcityDao ItcityDao
        {
            get
            {
                if (_ItcityDao == null)
                {
                    _ItcityDao = this.DALIocTool.Get<ItcityDao>();
                }
                return _ItcityDao;
            }
        }

        ITCustomerDao _ITCustomerDao;
        /// <summary>
        /// T_Customer()表契约接口
        /// </summary>
        public ITCustomerDao ITCustomerDao
        {
            get
            {
                if (_ITCustomerDao == null)
                {
                    _ITCustomerDao = this.DALIocTool.Get<ITCustomerDao>();
                }
                return _ITCustomerDao;
            }
        }

        ITEmployeeDao _ITEmployeeDao;
        /// <summary>
        /// T_Employee()表契约接口
        /// </summary>
        public ITEmployeeDao ITEmployeeDao
        {
            get
            {
                if (_ITEmployeeDao == null)
                {
                    _ITEmployeeDao = this.DALIocTool.Get<ITEmployeeDao>();
                }
                return _ITEmployeeDao;
            }
        }

        ITGuestDao _ITGuestDao;
        /// <summary>
        /// T_Guest()表契约接口
        /// </summary>
        public ITGuestDao ITGuestDao
        {
            get
            {
                if (_ITGuestDao == null)
                {
                    _ITGuestDao = this.DALIocTool.Get<ITGuestDao>();
                }
                return _ITGuestDao;
            }
        }

        ITGuestContactDao _ITGuestContactDao;
        /// <summary>
        /// T_GuestContact()表契约接口
        /// </summary>
        public ITGuestContactDao ITGuestContactDao
        {
            get
            {
                if (_ITGuestContactDao == null)
                {
                    _ITGuestContactDao = this.DALIocTool.Get<ITGuestContactDao>();
                }
                return _ITGuestContactDao;
            }
        }

        ITInfoManageDao _ITInfoManageDao;
        /// <summary>
        /// T_InfoManage()表契约接口
        /// </summary>
        public ITInfoManageDao ITInfoManageDao
        {
            get
            {
                if (_ITInfoManageDao == null)
                {
                    _ITInfoManageDao = this.DALIocTool.Get<ITInfoManageDao>();
                }
                return _ITInfoManageDao;
            }
        }

        ITKeyManageDao _ITKeyManageDao;
        /// <summary>
        /// T_KeyManage()表契约接口
        /// </summary>
        public ITKeyManageDao ITKeyManageDao
        {
            get
            {
                if (_ITKeyManageDao == null)
                {
                    _ITKeyManageDao = this.DALIocTool.Get<ITKeyManageDao>();
                }
                return _ITKeyManageDao;
            }
        }

        ITKeyManageContentDao _ITKeyManageContentDao;
        /// <summary>
        /// T_KeyManageContent()表契约接口
        /// </summary>
        public ITKeyManageContentDao ITKeyManageContentDao
        {
            get
            {
                if (_ITKeyManageContentDao == null)
                {
                    _ITKeyManageContentDao = this.DALIocTool.Get<ITKeyManageContentDao>();
                }
                return _ITKeyManageContentDao;
            }
        }

        ITMemberLvDao _ITMemberLvDao;
        /// <summary>
        /// T_MemberLv()表契约接口
        /// </summary>
        public ITMemberLvDao ITMemberLvDao
        {
            get
            {
                if (_ITMemberLvDao == null)
                {
                    _ITMemberLvDao = this.DALIocTool.Get<ITMemberLvDao>();
                }
                return _ITMemberLvDao;
            }
        }

        ITMessageCountDao _ITMessageCountDao;
        /// <summary>
        /// T_MessageCount()表契约接口
        /// </summary>
        public ITMessageCountDao ITMessageCountDao
        {
            get
            {
                if (_ITMessageCountDao == null)
                {
                    _ITMessageCountDao = this.DALIocTool.Get<ITMessageCountDao>();
                }
                return _ITMessageCountDao;
            }
        }

        ITMessageRecordDao _ITMessageRecordDao;
        /// <summary>
        /// T_MessageRecord()表契约接口
        /// </summary>
        public ITMessageRecordDao ITMessageRecordDao
        {
            get
            {
                if (_ITMessageRecordDao == null)
                {
                    _ITMessageRecordDao = this.DALIocTool.Get<ITMessageRecordDao>();
                }
                return _ITMessageRecordDao;
            }
        }

        ITNeedsDao _ITNeedsDao;
        /// <summary>
        /// T_Needs()表契约接口
        /// </summary>
        public ITNeedsDao ITNeedsDao
        {
            get
            {
                if (_ITNeedsDao == null)
                {
                    _ITNeedsDao = this.DALIocTool.Get<ITNeedsDao>();
                }
                return _ITNeedsDao;
            }
        }

        ITNoticeDao _ITNoticeDao;
        /// <summary>
        /// T_Notice()表契约接口
        /// </summary>
        public ITNoticeDao ITNoticeDao
        {
            get
            {
                if (_ITNoticeDao == null)
                {
                    _ITNoticeDao = this.DALIocTool.Get<ITNoticeDao>();
                }
                return _ITNoticeDao;
            }
        }

        ITNoticeReciverDao _ITNoticeReciverDao;
        /// <summary>
        /// T_NoticeReciver()表契约接口
        /// </summary>
        public ITNoticeReciverDao ITNoticeReciverDao
        {
            get
            {
                if (_ITNoticeReciverDao == null)
                {
                    _ITNoticeReciverDao = this.DALIocTool.Get<ITNoticeReciverDao>();
                }
                return _ITNoticeReciverDao;
            }
        }

        ItprovinceDao _ItprovinceDao;
        /// <summary>
        /// t_province()表契约接口
        /// </summary>
        public ItprovinceDao ItprovinceDao
        {
            get
            {
                if (_ItprovinceDao == null)
                {
                    _ItprovinceDao = this.DALIocTool.Get<ItprovinceDao>();
                }
                return _ItprovinceDao;
            }
        }

        ITSendMessageDao _ITSendMessageDao;
        /// <summary>
        /// T_SendMessage()表契约接口
        /// </summary>
        public ITSendMessageDao ITSendMessageDao
        {
            get
            {
                if (_ITSendMessageDao == null)
                {
                    _ITSendMessageDao = this.DALIocTool.Get<ITSendMessageDao>();
                }
                return _ITSendMessageDao;
            }
        }

        ITSMSListDao _ITSMSListDao;
        /// <summary>
        /// T_SMSList()表契约接口
        /// </summary>
        public ITSMSListDao ITSMSListDao
        {
            get
            {
                if (_ITSMSListDao == null)
                {
                    _ITSMSListDao = this.DALIocTool.Get<ITSMSListDao>();
                }
                return _ITSMSListDao;
            }
        }

        ITSystemConfigDao _ITSystemConfigDao;
        /// <summary>
        /// T_System_Config(系统设置)表契约接口
        /// </summary>
        public ITSystemConfigDao ITSystemConfigDao
        {
            get
            {
                if (_ITSystemConfigDao == null)
                {
                    _ITSystemConfigDao = this.DALIocTool.Get<ITSystemConfigDao>();
                }
                return _ITSystemConfigDao;
            }
        }

        ITUsedCarBuyDao _ITUsedCarBuyDao;
        /// <summary>
        /// T_UsedCarBuy()表契约接口
        /// </summary>
        public ITUsedCarBuyDao ITUsedCarBuyDao
        {
            get
            {
                if (_ITUsedCarBuyDao == null)
                {
                    _ITUsedCarBuyDao = this.DALIocTool.Get<ITUsedCarBuyDao>();
                }
                return _ITUsedCarBuyDao;
            }
        }

        ITUsedCarSellDao _ITUsedCarSellDao;
        /// <summary>
        /// T_UsedCarSell()表契约接口
        /// </summary>
        public ITUsedCarSellDao ITUsedCarSellDao
        {
            get
            {
                if (_ITUsedCarSellDao == null)
                {
                    _ITUsedCarSellDao = this.DALIocTool.Get<ITUsedCarSellDao>();
                }
                return _ITUsedCarSellDao;
            }
        }

        ITalkPriceCategoryDao _ITalkPriceCategoryDao;
        /// <summary>
        /// TalkPrice_Category()表契约接口
        /// </summary>
        public ITalkPriceCategoryDao ITalkPriceCategoryDao
        {
            get
            {
                if (_ITalkPriceCategoryDao == null)
                {
                    _ITalkPriceCategoryDao = this.DALIocTool.Get<ITalkPriceCategoryDao>();
                }
                return _ITalkPriceCategoryDao;
            }
        }

        ITalkPriceCategoryConnectCarBrandDao _ITalkPriceCategoryConnectCarBrandDao;
        /// <summary>
        /// TalkPrice_CategoryConnectCarBrand()表契约接口
        /// </summary>
        public ITalkPriceCategoryConnectCarBrandDao ITalkPriceCategoryConnectCarBrandDao
        {
            get
            {
                if (_ITalkPriceCategoryConnectCarBrandDao == null)
                {
                    _ITalkPriceCategoryConnectCarBrandDao = this.DALIocTool.Get<ITalkPriceCategoryConnectCarBrandDao>();
                }
                return _ITalkPriceCategoryConnectCarBrandDao;
            }
        }

        ITalkPriceImageDao _ITalkPriceImageDao;
        /// <summary>
        /// TalkPrice_Image()表契约接口
        /// </summary>
        public ITalkPriceImageDao ITalkPriceImageDao
        {
            get
            {
                if (_ITalkPriceImageDao == null)
                {
                    _ITalkPriceImageDao = this.DALIocTool.Get<ITalkPriceImageDao>();
                }
                return _ITalkPriceImageDao;
            }
        }

        ITalkPriceOrderDao _ITalkPriceOrderDao;
        /// <summary>
        /// TalkPrice_Order()表契约接口
        /// </summary>
        public ITalkPriceOrderDao ITalkPriceOrderDao
        {
            get
            {
                if (_ITalkPriceOrderDao == null)
                {
                    _ITalkPriceOrderDao = this.DALIocTool.Get<ITalkPriceOrderDao>();
                }
                return _ITalkPriceOrderDao;
            }
        }

        ITalkPriceOrderSmsRecordDao _ITalkPriceOrderSmsRecordDao;
        /// <summary>
        /// TalkPrice_OrderSmsRecord(短信表)表契约接口
        /// </summary>
        public ITalkPriceOrderSmsRecordDao ITalkPriceOrderSmsRecordDao
        {
            get
            {
                if (_ITalkPriceOrderSmsRecordDao == null)
                {
                    _ITalkPriceOrderSmsRecordDao = this.DALIocTool.Get<ITalkPriceOrderSmsRecordDao>();
                }
                return _ITalkPriceOrderSmsRecordDao;
            }
        }

        ITalkPriceRepairItemDao _ITalkPriceRepairItemDao;
        /// <summary>
        /// TalkPrice_RepairItem()表契约接口
        /// </summary>
        public ITalkPriceRepairItemDao ITalkPriceRepairItemDao
        {
            get
            {
                if (_ITalkPriceRepairItemDao == null)
                {
                    _ITalkPriceRepairItemDao = this.DALIocTool.Get<ITalkPriceRepairItemDao>();
                }
                return _ITalkPriceRepairItemDao;
            }
        }

        ITalkPriceRepairItemCommentDao _ITalkPriceRepairItemCommentDao;
        /// <summary>
        /// TalkPrice_RepairItemComment( )表契约接口
        /// </summary>
        public ITalkPriceRepairItemCommentDao ITalkPriceRepairItemCommentDao
        {
            get
            {
                if (_ITalkPriceRepairItemCommentDao == null)
                {
                    _ITalkPriceRepairItemCommentDao = this.DALIocTool.Get<ITalkPriceRepairItemCommentDao>();
                }
                return _ITalkPriceRepairItemCommentDao;
            }
        }

        IVideoMainDao _IVideoMainDao;
        /// <summary>
        /// Video_Main()表契约接口
        /// </summary>
        public IVideoMainDao IVideoMainDao
        {
            get
            {
                if (_IVideoMainDao == null)
                {
                    _IVideoMainDao = this.DALIocTool.Get<IVideoMainDao>();
                }
                return _IVideoMainDao;
            }
        }

        IVideoMainToVideoDao _IVideoMainToVideoDao;
        /// <summary>
        /// Video_MainToVideo()表契约接口
        /// </summary>
        public IVideoMainToVideoDao IVideoMainToVideoDao
        {
            get
            {
                if (_IVideoMainToVideoDao == null)
                {
                    _IVideoMainToVideoDao = this.DALIocTool.Get<IVideoMainToVideoDao>();
                }
                return _IVideoMainToVideoDao;
            }
        }

        IWebSiteDao _IWebSiteDao;
        /// <summary>
        /// WebSite()表契约接口
        /// </summary>
        public IWebSiteDao IWebSiteDao
        {
            get
            {
                if (_IWebSiteDao == null)
                {
                    _IWebSiteDao = this.DALIocTool.Get<IWebSiteDao>();
                }
                return _IWebSiteDao;
            }
        }

        IWebSiteSkinColorDao _IWebSiteSkinColorDao;
        /// <summary>
        /// WebSiteSkinColor()表契约接口
        /// </summary>
        public IWebSiteSkinColorDao IWebSiteSkinColorDao
        {
            get
            {
                if (_IWebSiteSkinColorDao == null)
                {
                    _IWebSiteSkinColorDao = this.DALIocTool.Get<IWebSiteSkinColorDao>();
                }
                return _IWebSiteSkinColorDao;
            }
        }

        IWebSiteTemplateSkinDao _IWebSiteTemplateSkinDao;
        /// <summary>
        /// WebSiteTemplateSkin()表契约接口
        /// </summary>
        public IWebSiteTemplateSkinDao IWebSiteTemplateSkinDao
        {
            get
            {
                if (_IWebSiteTemplateSkinDao == null)
                {
                    _IWebSiteTemplateSkinDao = this.DALIocTool.Get<IWebSiteTemplateSkinDao>();
                }
                return _IWebSiteTemplateSkinDao;
            }
        }

        IWeiXinAccountToCenterAccountDao _IWeiXinAccountToCenterAccountDao;
        /// <summary>
        /// WeiXin_AccountToCenterAccount(微信账号对集群账号表)表契约接口
        /// </summary>
        public IWeiXinAccountToCenterAccountDao IWeiXinAccountToCenterAccountDao
        {
            get
            {
                if (_IWeiXinAccountToCenterAccountDao == null)
                {
                    _IWeiXinAccountToCenterAccountDao = this.DALIocTool.Get<IWeiXinAccountToCenterAccountDao>();
                }
                return _IWeiXinAccountToCenterAccountDao;
            }
        }

        IWeiXinActivityDao _IWeiXinActivityDao;
        /// <summary>
        /// WeiXin_Activity(微活动报名表)表契约接口
        /// </summary>
        public IWeiXinActivityDao IWeiXinActivityDao
        {
            get
            {
                if (_IWeiXinActivityDao == null)
                {
                    _IWeiXinActivityDao = this.DALIocTool.Get<IWeiXinActivityDao>();
                }
                return _IWeiXinActivityDao;
            }
        }

        IWeiXinActivityApplicantDao _IWeiXinActivityApplicantDao;
        /// <summary>
        /// WeiXin_Activity_Applicant(微活动报名表)表契约接口
        /// </summary>
        public IWeiXinActivityApplicantDao IWeiXinActivityApplicantDao
        {
            get
            {
                if (_IWeiXinActivityApplicantDao == null)
                {
                    _IWeiXinActivityApplicantDao = this.DALIocTool.Get<IWeiXinActivityApplicantDao>();
                }
                return _IWeiXinActivityApplicantDao;
            }
        }

        IWeiXinArticlesDao _IWeiXinArticlesDao;
        /// <summary>
        /// WeiXin_Articles(微信文章表)表契约接口
        /// </summary>
        public IWeiXinArticlesDao IWeiXinArticlesDao
        {
            get
            {
                if (_IWeiXinArticlesDao == null)
                {
                    _IWeiXinArticlesDao = this.DALIocTool.Get<IWeiXinArticlesDao>();
                }
                return _IWeiXinArticlesDao;
            }
        }

        IWeiXinMenusDao _IWeiXinMenusDao;
        /// <summary>
        /// WeiXin_Menus(微信菜单表)表契约接口
        /// </summary>
        public IWeiXinMenusDao IWeiXinMenusDao
        {
            get
            {
                if (_IWeiXinMenusDao == null)
                {
                    _IWeiXinMenusDao = this.DALIocTool.Get<IWeiXinMenusDao>();
                }
                return _IWeiXinMenusDao;
            }
        }

        IWeiXinMenusArticlesRefDao _IWeiXinMenusArticlesRefDao;
        /// <summary>
        /// WeiXin_Menus_Articles_Ref(微信菜单与文章表)表契约接口
        /// </summary>
        public IWeiXinMenusArticlesRefDao IWeiXinMenusArticlesRefDao
        {
            get
            {
                if (_IWeiXinMenusArticlesRefDao == null)
                {
                    _IWeiXinMenusArticlesRefDao = this.DALIocTool.Get<IWeiXinMenusArticlesRefDao>();
                }
                return _IWeiXinMenusArticlesRefDao;
            }
        }

        IWeiXinQRCodeDao _IWeiXinQRCodeDao;
        /// <summary>
        /// WeiXin_QRCode(微信二维码信息表)表契约接口
        /// </summary>
        public IWeiXinQRCodeDao IWeiXinQRCodeDao
        {
            get
            {
                if (_IWeiXinQRCodeDao == null)
                {
                    _IWeiXinQRCodeDao = this.DALIocTool.Get<IWeiXinQRCodeDao>();
                }
                return _IWeiXinQRCodeDao;
            }
        }

        IWeiXinQRCodePromotionActivityAccountDao _IWeiXinQRCodePromotionActivityAccountDao;
        /// <summary>
        /// WeiXin_QRCodePromotionActivityAccount(微信参加二维码推广活动用户信息表)表契约接口
        /// </summary>
        public IWeiXinQRCodePromotionActivityAccountDao IWeiXinQRCodePromotionActivityAccountDao
        {
            get
            {
                if (_IWeiXinQRCodePromotionActivityAccountDao == null)
                {
                    _IWeiXinQRCodePromotionActivityAccountDao = this.DALIocTool.Get<IWeiXinQRCodePromotionActivityAccountDao>();
                }
                return _IWeiXinQRCodePromotionActivityAccountDao;
            }
        }

        IWeiXinQRCodePromotionActivityAccountPointsHistoryDao _IWeiXinQRCodePromotionActivityAccountPointsHistoryDao;
        /// <summary>
        /// WeiXin_QRCodePromotionActivityAccountPointsHistory(微信参加二维码推广活动用户积分使用历史信息表)表契约接口
        /// </summary>
        public IWeiXinQRCodePromotionActivityAccountPointsHistoryDao IWeiXinQRCodePromotionActivityAccountPointsHistoryDao
        {
            get
            {
                if (_IWeiXinQRCodePromotionActivityAccountPointsHistoryDao == null)
                {
                    _IWeiXinQRCodePromotionActivityAccountPointsHistoryDao = this.DALIocTool.Get<IWeiXinQRCodePromotionActivityAccountPointsHistoryDao>();
                }
                return _IWeiXinQRCodePromotionActivityAccountPointsHistoryDao;
            }
        }

        IWeiXinQRCodePromotionActivityMemberFromAccountDao _IWeiXinQRCodePromotionActivityMemberFromAccountDao;
        /// <summary>
        /// WeiXin_QRCodePromotionActivityMemberFromAccount(关注微信参加二维码推广活动用户的用户记录信息表)表契约接口
        /// </summary>
        public IWeiXinQRCodePromotionActivityMemberFromAccountDao IWeiXinQRCodePromotionActivityMemberFromAccountDao
        {
            get
            {
                if (_IWeiXinQRCodePromotionActivityMemberFromAccountDao == null)
                {
                    _IWeiXinQRCodePromotionActivityMemberFromAccountDao = this.DALIocTool.Get<IWeiXinQRCodePromotionActivityMemberFromAccountDao>();
                }
                return _IWeiXinQRCodePromotionActivityMemberFromAccountDao;
            }
        }

        IWeiXinWebSiteInfoDao _IWeiXinWebSiteInfoDao;
        /// <summary>
        /// WeiXin_WebSiteInfo(站点微信信息表)表契约接口
        /// </summary>
        public IWeiXinWebSiteInfoDao IWeiXinWebSiteInfoDao
        {
            get
            {
                if (_IWeiXinWebSiteInfoDao == null)
                {
                    _IWeiXinWebSiteInfoDao = this.DALIocTool.Get<IWeiXinWebSiteInfoDao>();
                }
                return _IWeiXinWebSiteInfoDao;
            }
        }
    }
}