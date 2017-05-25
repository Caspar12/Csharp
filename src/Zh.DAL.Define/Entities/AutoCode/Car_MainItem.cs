/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 数据契约实体模型文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.DAL.Base.Define.Entities;
namespace Zh.DAL.Define.Entities
{
	#region Car_MainItem

	/// <summary>
    /// 指定车辆表
	/// Car_MainItem object for mapped table 'Car_MainItem'.
	/// </summary>
	public partial class Car_MainItem
	{
		
		#region Constructors
        
		public Car_MainItem() { }        
        
		public Car_MainItem( Guid iD, string name, decimal? sellPrice, decimal? guidePrice, Guid mainID, int identity, Guid? seriesID, bool isShowFront, int? gearBoxType )
		{
			this.ID = iD;
			this.Name = name;
			this.SellPrice = sellPrice;
			this.GuidePrice = guidePrice;
			this.MainID = mainID;
			this.Identity = identity;
			this.SeriesID = seriesID;
			this.IsShowFront = isShowFront;
			this.GearBoxType = gearBoxType;
		}
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
        public virtual Car_Main Car_Main{get;set;}
        /// <summary>
        /// 车型系统表
        /// </summary>            
        public virtual Car_MainItem_Series Car_MainItem_Series{get;set;}
        
        /// <summary>
        /// 车辆玻璃/后视镜配置
        /// </summary>
        public virtual Car_WindowAndRearviewConfig Car_WindowAndRearviewConfig{get;set;}
        /// <summary>
        /// 车辆安全装备
        /// </summary>
        public virtual Car_SecurityEquip Car_SecurityEquip{get;set;}
        /// <summary>
        /// 座椅配置
        /// </summary>
        public virtual Car_SeatConfig Car_SeatConfig{get;set;}
        /// <summary>
        /// 车辆多媒体配置
        /// </summary>
        public virtual Car_MultiMediaConfig Car_MultiMediaConfig{get;set;}
        /// <summary>
        /// 车辆灯光配置
        /// </summary>
        public virtual Car_lightsConfig Car_lightsConfig{get;set;}
        /// <summary>
        /// 内部配置
        /// </summary>
        public virtual Car_InternalConfig Car_InternalConfig{get;set;}
        /// <summary>
        /// 车辆高科技配置
        /// </summary>
        public virtual Car_HighTechConfig Car_HighTechConfig{get;set;}
        /// <summary>
        /// 车辆变速箱参数
        /// </summary>
        public virtual Car_MainItem_GearBox Car_MainItem_GearBox{get;set;}
        /// <summary>
        /// 外部配置
        /// </summary>
        public virtual Car_ExternalConfig Car_ExternalConfig{get;set;}
        /// <summary>
        /// 车辆发动机参数
        /// </summary>
        public virtual Car_MainItem_Engine Car_MainItem_Engine{get;set;}
        /// <summary>
        /// 车辆操控配置
        /// </summary>
        public virtual Car_ControlConfig Car_ControlConfig{get;set;}
        /// <summary>
        /// 车辆底盘转向参数
        /// </summary>
        public virtual Car_MainItem_ChassisSteering Car_MainItem_ChassisSteering{get;set;}
        /// <summary>
        /// 车轮制动参数
        /// </summary>
        public virtual Car_MainItem_BrakingOfWheel Car_MainItem_BrakingOfWheel{get;set;}
        /// <summary>
        /// 车辆车身参数
        /// </summary>
        public virtual Car_MainItem_BodyWork Car_MainItem_BodyWork{get;set;}
        /// <summary>
        /// 车辆基本参数
        /// </summary>
        public virtual Car_MainItem_Base Car_MainItem_Base{get;set;}
        /// <summary>
        /// 车辆空调与冰箱配置
        /// </summary>
        public virtual Car_AirConditionerAndRefrigeratorConfig Car_AirConditionerAndRefrigeratorConfig{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Car_Enquiry> Car_Enquiry{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Car_Exchange> Car_Exchange{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Car_Exchange> Car_Exchange2{get;set;}
        /// <summary>
        /// 车辆外观颜色关系表
        /// </summary>
        public virtual IList<Car_MainItemToExColor> Car_MainItemToExColor{get;set;}
        /// <summary>
        /// 车辆图片表
        /// </summary>
        public virtual IList<Car_Image> Car_Image{get;set;}
        /// <summary>
        /// 车辆内观颜色关系表
        /// </summary>
        public virtual IList<Car_MainItemToInColor> Car_MainItemToInColor{get;set;}
        /// <summary>
        /// 车辆与车型关系表
        /// </summary>
        public virtual IList<Car_MainItemToModel> Car_MainItemToModel{get;set;}
        /// <summary>
        /// 会员车辆信息
        /// </summary>
        public virtual IList<Member_CarInfo> Member_CarInfo{get;set;}
        /// <summary>
        /// 口啤印象表
        /// </summary>
        public virtual IList<Prestige_Impression> Prestige_Impression{get;set;}
        /// <summary>
        /// 车辆口碑帖子
        /// </summary>
        public virtual IList<Prestige_Post> Prestige_Post{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TalkPrice_Order> TalkPrice_Order{get;set;}


		#endregion
	 
	}
	#endregion
}
 