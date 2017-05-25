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
	#region Car_SeatConfig

	/// <summary>
    /// 座椅配置
	/// Car_SeatConfig object for mapped table 'Car_SeatConfig'.
	/// </summary>
	public partial class Car_SeatConfig
	{
		
		#region Constructors
        
		public Car_SeatConfig() { }        
        
		public Car_SeatConfig( Guid iD, bool? isLeatherSeat, bool? isSportStyleSeat, bool? hasAdjustSeatHeight, bool? hasLumbarSupportAdjustment, bool? hasShoulderSupportAdjustment, bool? hasMainSeatElectricAdjustment, bool? hasSubsidiarySeatElectricAdjustment, bool? hasSecondLineBackrestAdjustment, bool? hasSecondLinePositionAdjustment, bool? hasBackLineElectricSeatAdjustment, bool? hasElectricSeatMemory, bool? hasFrontSeatHeat, bool? hasBackSeatHeat, bool? hasFrontAirSeat, bool? hasBackAirSeat, bool? hasFrontMassageArmchair, bool? hasBackMassageArmchair, string backLineSeatDownMethod, bool? thirdSeat, bool? frontCenterHandRail, bool? backCenterHandRail, bool? backLineCupHolder )
		{
			this.ID = iD;
			this.IsLeatherSeat = isLeatherSeat;
			this.IsSportStyleSeat = isSportStyleSeat;
			this.HasAdjustSeatHeight = hasAdjustSeatHeight;
			this.HasLumbarSupportAdjustment = hasLumbarSupportAdjustment;
			this.HasShoulderSupportAdjustment = hasShoulderSupportAdjustment;
			this.HasMainSeatElectricAdjustment = hasMainSeatElectricAdjustment;
			this.HasSubsidiarySeatElectricAdjustment = hasSubsidiarySeatElectricAdjustment;
			this.HasSecondLineBackrestAdjustment = hasSecondLineBackrestAdjustment;
			this.HasSecondLinePositionAdjustment = hasSecondLinePositionAdjustment;
			this.HasBackLineElectricSeatAdjustment = hasBackLineElectricSeatAdjustment;
			this.HasElectricSeatMemory = hasElectricSeatMemory;
			this.HasFrontSeatHeat = hasFrontSeatHeat;
			this.HasBackSeatHeat = hasBackSeatHeat;
			this.HasFrontAirSeat = hasFrontAirSeat;
			this.HasBackAirSeat = hasBackAirSeat;
			this.HasFrontMassageArmchair = hasFrontMassageArmchair;
			this.HasBackMassageArmchair = hasBackMassageArmchair;
			this.BackLineSeatDownMethod = backLineSeatDownMethod;
			this.ThirdSeat = thirdSeat;
			this.FrontCenterHandRail = frontCenterHandRail;
			this.BackCenterHandRail = backCenterHandRail;
			this.BackLineCupHolder = backLineCupHolder;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 真皮/仿皮座椅
        /// </summary>
		public virtual bool? IsLeatherSeat { get; set; }
        /// <summary>
        /// 运动风格座椅
        /// </summary>
		public virtual bool? IsSportStyleSeat { get; set; }
        /// <summary>
        /// 座椅高低调节
        /// </summary>
		public virtual bool? HasAdjustSeatHeight { get; set; }
        /// <summary>
        /// 腰部支撑调节
        /// </summary>
		public virtual bool? HasLumbarSupportAdjustment { get; set; }
        /// <summary>
        /// 肩部支撑调节
        /// </summary>
		public virtual bool? HasShoulderSupportAdjustment { get; set; }
        /// <summary>
        /// 主驾驶座电动调节
        /// </summary>
		public virtual bool? HasMainSeatElectricAdjustment { get; set; }
        /// <summary>
        /// 副驾驶座电动调节
        /// </summary>
		public virtual bool? HasSubsidiarySeatElectricAdjustment { get; set; }
        /// <summary>
        /// 第二排靠背角度调节
        /// </summary>
		public virtual bool? HasSecondLineBackrestAdjustment { get; set; }
        /// <summary>
        /// 第二排座椅移动
        /// </summary>
		public virtual bool? HasSecondLinePositionAdjustment { get; set; }
        /// <summary>
        /// 后排座椅电动调节
        /// </summary>
		public virtual bool? HasBackLineElectricSeatAdjustment { get; set; }
        /// <summary>
        /// 电动座椅记忆
        /// </summary>
		public virtual bool? HasElectricSeatMemory { get; set; }
        /// <summary>
        /// 前排座椅加热
        /// </summary>
		public virtual bool? HasFrontSeatHeat { get; set; }
        /// <summary>
        /// 后排座椅加热
        /// </summary>
		public virtual bool? HasBackSeatHeat { get; set; }
        /// <summary>
        /// 前排座椅通风
        /// </summary>
		public virtual bool? HasFrontAirSeat { get; set; }
        /// <summary>
        /// 后排座椅通风
        /// </summary>
		public virtual bool? HasBackAirSeat { get; set; }
        /// <summary>
        /// 前排座椅按摩
        /// </summary>
		public virtual bool? HasFrontMassageArmchair { get; set; }
        /// <summary>
        /// 后排座椅通风
        /// </summary>
		public virtual bool? HasBackMassageArmchair { get; set; }
        /// <summary>
        /// 后排座椅放倒方式
        /// </summary>
		public virtual string BackLineSeatDownMethod { get; set; }
        /// <summary>
        /// 第三排座椅
        /// </summary>
		public virtual bool? ThirdSeat { get; set; }
        /// <summary>
        /// 前中央扶手
        /// </summary>
		public virtual bool? FrontCenterHandRail { get; set; }
        /// <summary>
        /// 后中央扶手
        /// </summary>
		public virtual bool? BackCenterHandRail { get; set; }
        /// <summary>
        /// 后排杯架
        /// </summary>
		public virtual bool? BackLineCupHolder { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 