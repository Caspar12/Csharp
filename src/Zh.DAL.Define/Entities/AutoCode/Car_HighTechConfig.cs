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
	#region Car_HighTechConfig

	/// <summary>
    /// 车辆高科技配置
	/// Car_HighTechConfig object for mapped table 'Car_HighTechConfig'.
	/// </summary>
	public partial class Car_HighTechConfig
	{
		
		#region Constructors
        
		public Car_HighTechConfig() { }        
        
		public Car_HighTechConfig( Guid iD, bool? hasAutoParkingTech, bool? hasEngineStartStopTech, bool? hasAuxiliary, bool? hasLaneDepartureWarningSystem, bool? hasActiveBrakingSystem, bool? hasActiveSafetySystem, bool? hasActiveSteeringSystem, bool? hasNightViewSystem, bool? hasCenterControlLCDScreenDisplay, bool? hasAdaptiveCruiseControl, bool? hasOverallViewCamera )
		{
			this.ID = iD;
			this.HasAutoParkingTech = hasAutoParkingTech;
			this.HasEngineStartStopTech = hasEngineStartStopTech;
			this.HasAuxiliary = hasAuxiliary;
			this.HasLaneDepartureWarningSystem = hasLaneDepartureWarningSystem;
			this.HasActiveBrakingSystem = hasActiveBrakingSystem;
			this.HasActiveSafetySystem = hasActiveSafetySystem;
			this.HasActiveSteeringSystem = hasActiveSteeringSystem;
			this.HasNightViewSystem = hasNightViewSystem;
			this.HasCenterControlLCDScreenDisplay = hasCenterControlLCDScreenDisplay;
			this.HasAdaptiveCruiseControl = hasAdaptiveCruiseControl;
			this.HasOverallViewCamera = hasOverallViewCamera;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自动泊车入位
        /// </summary>
		public virtual bool? HasAutoParkingTech { get; set; }
        /// <summary>
        /// 发动机启停技术
        /// </summary>
		public virtual bool? HasEngineStartStopTech { get; set; }
        /// <summary>
        /// 并线辅助
        /// </summary>
		public virtual bool? HasAuxiliary { get; set; }
        /// <summary>
        /// 车道偏离预警系统
        /// </summary>
		public virtual bool? HasLaneDepartureWarningSystem { get; set; }
        /// <summary>
        /// 主动刹车系统
        /// </summary>
		public virtual bool? HasActiveBrakingSystem { get; set; }
        /// <summary>
        /// 主动安全系统
        /// </summary>
		public virtual bool? HasActiveSafetySystem { get; set; }
        /// <summary>
        /// 整体主动转向系统
        /// </summary>
		public virtual bool? HasActiveSteeringSystem { get; set; }
        /// <summary>
        /// 夜视系统
        /// </summary>
		public virtual bool? HasNightViewSystem { get; set; }
        /// <summary>
        /// 中控液晶屏分屏显示
        /// </summary>
		public virtual bool? HasCenterControlLCDScreenDisplay { get; set; }
        /// <summary>
        /// 自适应巡航
        /// </summary>
		public virtual bool? HasAdaptiveCruiseControl { get; set; }
        /// <summary>
        /// 全景摄像头
        /// </summary>
		public virtual bool? HasOverallViewCamera { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 