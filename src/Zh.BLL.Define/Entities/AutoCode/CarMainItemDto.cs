/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据契约实体模型文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
using System.Collections.Generic;
namespace Zh.BLL.Define.Entities
{
	#region CarMainItemDto

	/// <summary>
    /// 指定车辆表
	/// CarMainItemDto data view model for mapped table 'Car_MainItem'.
	/// </summary>
	public partial class CarMainItemDto
	{
		
		#region Constructors
        
		public CarMainItemDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 售价
        /// </summary>
		public virtual decimal? SellPrice { get; set; }
        /// <summary>
        /// 指导价
        /// </summary>
		public virtual decimal? GuidePrice { get; set; }
        /// <summary>
        /// 车辆主ID
        /// </summary>
		public virtual Guid MainID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 车型系列ID
        /// </summary>
		public virtual Guid? SeriesID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsShowFront { get; set; }
        /// <summary>
        /// 变速箱类型( 1-手动 2-自动 3手自一体 )
        /// </summary>
		public virtual int? GearBoxType { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual CarMainDto CarMainDto{get;set;}
        /// <summary>
        /// 车型系统表
        /// </summary>            
        public virtual CarMainItemSeriesDto CarMainItemSeriesDto{get;set;}
        
        /// <summary>
        /// 车辆玻璃/后视镜配置
        /// </summary>
        public virtual CarWindowAndRearviewConfigDto CarWindowAndRearviewConfigDto{get;set;}
        /// <summary>
        /// 车辆安全装备
        /// </summary>
        public virtual CarSecurityEquipDto CarSecurityEquipDto{get;set;}
        /// <summary>
        /// 座椅配置
        /// </summary>
        public virtual CarSeatConfigDto CarSeatConfigDto{get;set;}
        /// <summary>
        /// 车辆多媒体配置
        /// </summary>
        public virtual CarMultiMediaConfigDto CarMultiMediaConfigDto{get;set;}
        /// <summary>
        /// 车辆灯光配置
        /// </summary>
        public virtual CarlightsConfigDto CarlightsConfigDto{get;set;}
        /// <summary>
        /// 内部配置
        /// </summary>
        public virtual CarInternalConfigDto CarInternalConfigDto{get;set;}
        /// <summary>
        /// 车辆高科技配置
        /// </summary>
        public virtual CarHighTechConfigDto CarHighTechConfigDto{get;set;}
        /// <summary>
        /// 车辆变速箱参数
        /// </summary>
        public virtual CarMainItemGearBoxDto CarMainItemGearBoxDto{get;set;}
        /// <summary>
        /// 外部配置
        /// </summary>
        public virtual CarExternalConfigDto CarExternalConfigDto{get;set;}
        /// <summary>
        /// 车辆发动机参数
        /// </summary>
        public virtual CarMainItemEngineDto CarMainItemEngineDto{get;set;}
        /// <summary>
        /// 车辆操控配置
        /// </summary>
        public virtual CarControlConfigDto CarControlConfigDto{get;set;}
        /// <summary>
        /// 车辆底盘转向参数
        /// </summary>
        public virtual CarMainItemChassisSteeringDto CarMainItemChassisSteeringDto{get;set;}
        /// <summary>
        /// 车轮制动参数
        /// </summary>
        public virtual CarMainItemBrakingOfWheelDto CarMainItemBrakingOfWheelDto{get;set;}
        /// <summary>
        /// 车辆车身参数
        /// </summary>
        public virtual CarMainItemBodyWorkDto CarMainItemBodyWorkDto{get;set;}
        /// <summary>
        /// 车辆基本参数
        /// </summary>
        public virtual CarMainItemBaseDto CarMainItemBaseDto{get;set;}
        /// <summary>
        /// 车辆空调与冰箱配置
        /// </summary>
        public virtual CarAirConditionerAndRefrigeratorConfigDto CarAirConditionerAndRefrigeratorConfigDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<CarEnquiryDto> CarEnquiryDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<CarExchangeDto> CarExchangeDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<CarExchangeDto> CarExchangeDto2{get;set;}
        /// <summary>
        /// 车辆外观颜色关系表
        /// </summary>
        public virtual IList<CarMainItemToExColorDto> CarMainItemToExColorDto{get;set;}
        /// <summary>
        /// 车辆图片表
        /// </summary>
        public virtual IList<CarImageDto> CarImageDto{get;set;}
        /// <summary>
        /// 车辆内观颜色关系表
        /// </summary>
        public virtual IList<CarMainItemToInColorDto> CarMainItemToInColorDto{get;set;}
        /// <summary>
        /// 车辆与车型关系表
        /// </summary>
        public virtual IList<CarMainItemToModelDto> CarMainItemToModelDto{get;set;}
        /// <summary>
        /// 会员车辆信息
        /// </summary>
        public virtual IList<MemberCarInfoDto> MemberCarInfoDto{get;set;}
        /// <summary>
        /// 口啤印象表
        /// </summary>
        public virtual IList<PrestigeImpressionDto> PrestigeImpressionDto{get;set;}
        /// <summary>
        /// 车辆口碑帖子
        /// </summary>
        public virtual IList<PrestigePostDto> PrestigePostDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TalkPriceOrderDto> TalkPriceOrderDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 