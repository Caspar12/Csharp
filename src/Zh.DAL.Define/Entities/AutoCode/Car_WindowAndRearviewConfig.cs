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
	#region Car_WindowAndRearviewConfig

	/// <summary>
    /// 车辆玻璃/后视镜配置
	/// Car_WindowAndRearviewConfig object for mapped table 'Car_WindowAndRearviewConfig'.
	/// </summary>
	public partial class Car_WindowAndRearviewConfig
	{
		
		#region Constructors
        
		public Car_WindowAndRearviewConfig() { }        
        
		public Car_WindowAndRearviewConfig( Guid iD, bool? isFrontElectricCarWindow, bool? isBackElectricCarWindow, bool? hasCarWindowAntitrappingHand, bool? hasAntiUltravioletRadiationWindow, bool? hasRearviewMirrorElectricAdjustment, bool? hasRearviewHeat, bool? hasInsideRearviewMirrorAntiAazzlent, bool? hasOutsideRearviewMirrorAntiAazzlent, bool? hasRearviewElectricFold, bool? hasRearviewMemory, bool? hasRearWindshieldCurtain, bool? hasRearSideCurtain, bool? hasRearSidePrivateWindow, bool? hasCurtainMakeupMirror, bool? hasRearRainCleaner, bool? hasSensingCleaner )
		{
			this.ID = iD;
			this.IsFrontElectricCarWindow = isFrontElectricCarWindow;
			this.IsBackElectricCarWindow = isBackElectricCarWindow;
			this.HasCarWindowAntitrappingHand = hasCarWindowAntitrappingHand;
			this.HasAntiUltravioletRadiationWindow = hasAntiUltravioletRadiationWindow;
			this.HasRearviewMirrorElectricAdjustment = hasRearviewMirrorElectricAdjustment;
			this.HasRearviewHeat = hasRearviewHeat;
			this.HasInsideRearviewMirrorAntiAazzlent = hasInsideRearviewMirrorAntiAazzlent;
			this.HasOutsideRearviewMirrorAntiAazzlent = hasOutsideRearviewMirrorAntiAazzlent;
			this.HasRearviewElectricFold = hasRearviewElectricFold;
			this.HasRearviewMemory = hasRearviewMemory;
			this.HasRearWindshieldCurtain = hasRearWindshieldCurtain;
			this.HasRearSideCurtain = hasRearSideCurtain;
			this.HasRearSidePrivateWindow = hasRearSidePrivateWindow;
			this.HasCurtainMakeupMirror = hasCurtainMakeupMirror;
			this.HasRearRainCleaner = hasRearRainCleaner;
			this.HasSensingCleaner = hasSensingCleaner;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 前电动车窗
        /// </summary>
		public virtual bool? IsFrontElectricCarWindow { get; set; }
        /// <summary>
        /// 后电动车窗
        /// </summary>
		public virtual bool? IsBackElectricCarWindow { get; set; }
        /// <summary>
        /// 车窗防夹手功能
        /// </summary>
		public virtual bool? HasCarWindowAntitrappingHand { get; set; }
        /// <summary>
        /// 防紫外线/隔热玻璃
        /// </summary>
		public virtual bool? HasAntiUltravioletRadiationWindow { get; set; }
        /// <summary>
        /// 后视镜电动调节
        /// </summary>
		public virtual bool? HasRearviewMirrorElectricAdjustment { get; set; }
        /// <summary>
        /// 后视镜加热
        /// </summary>
		public virtual bool? HasRearviewHeat { get; set; }
        /// <summary>
        /// 内后视镜自动防眩目
        /// </summary>
		public virtual bool? HasInsideRearviewMirrorAntiAazzlent { get; set; }
        /// <summary>
        /// 外后视镜自动防眩目
        /// </summary>
		public virtual bool? HasOutsideRearviewMirrorAntiAazzlent { get; set; }
        /// <summary>
        /// 后视镜电动折叠
        /// </summary>
		public virtual bool? HasRearviewElectricFold { get; set; }
        /// <summary>
        /// 后视镜记忆
        /// </summary>
		public virtual bool? HasRearviewMemory { get; set; }
        /// <summary>
        /// 后风挡遮阳帘
        /// </summary>
		public virtual bool? HasRearWindshieldCurtain { get; set; }
        /// <summary>
        /// 后排侧遮阳帘
        /// </summary>
		public virtual bool? HasRearSideCurtain { get; set; }
        /// <summary>
        /// 后排侧隐私玻璃
        /// </summary>
		public virtual bool? HasRearSidePrivateWindow { get; set; }
        /// <summary>
        /// 遮阳板化妆镜
        /// </summary>
		public virtual bool? HasCurtainMakeupMirror { get; set; }
        /// <summary>
        /// 后雨刷
        /// </summary>
		public virtual bool? HasRearRainCleaner { get; set; }
        /// <summary>
        /// 感应雨刷
        /// </summary>
		public virtual bool? HasSensingCleaner { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 