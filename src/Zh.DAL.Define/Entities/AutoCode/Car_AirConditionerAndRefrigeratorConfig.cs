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
	#region Car_AirConditionerAndRefrigeratorConfig

	/// <summary>
    /// 车辆空调与冰箱配置
	/// Car_AirConditionerAndRefrigeratorConfig object for mapped table 'Car_AirConditionerAndRefrigeratorConfig'.
	/// </summary>
	public partial class Car_AirConditionerAndRefrigeratorConfig
	{
		
		#region Constructors
        
		public Car_AirConditionerAndRefrigeratorConfig() { }        
        
		public Car_AirConditionerAndRefrigeratorConfig( Guid iD, int? airConditionerControlMethod, bool? hasBackLineIndependentAirConfitioner, bool? hasBackLineAirOutlet, bool? hasTemperatureDivideControl, bool? hasAirAdjustment, bool? hasCarRefrigerator )
		{
			this.ID = iD;
			this.AirConditionerControlMethod = airConditionerControlMethod;
			this.HasBackLineIndependentAirConfitioner = hasBackLineIndependentAirConfitioner;
			this.HasBackLineAirOutlet = hasBackLineAirOutlet;
			this.HasTemperatureDivideControl = hasTemperatureDivideControl;
			this.HasAirAdjustment = hasAirAdjustment;
			this.HasCarRefrigerator = hasCarRefrigerator;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 空调控制方式(0:自动,1:手动)
        /// </summary>
		public virtual int? AirConditionerControlMethod { get; set; }
        /// <summary>
        /// 后排独立空调
        /// </summary>
		public virtual bool? HasBackLineIndependentAirConfitioner { get; set; }
        /// <summary>
        /// 后座出风口
        /// </summary>
		public virtual bool? HasBackLineAirOutlet { get; set; }
        /// <summary>
        /// 温度分区控制
        /// </summary>
		public virtual bool? HasTemperatureDivideControl { get; set; }
        /// <summary>
        /// 车内空气调节
        /// </summary>
		public virtual bool? HasAirAdjustment { get; set; }
        /// <summary>
        /// 车载冰箱
        /// </summary>
		public virtual bool? HasCarRefrigerator { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 