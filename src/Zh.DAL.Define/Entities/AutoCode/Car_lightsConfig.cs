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
	#region Car_lightsConfig

	/// <summary>
    /// 车辆灯光配置
	/// Car_lightsConfig object for mapped table 'Car_lightsConfig'.
	/// </summary>
	public partial class Car_lightsConfig
	{
		
		#region Constructors
        
		public Car_lightsConfig() { }        
        
		public Car_lightsConfig( Guid iD, bool? hasXenonHeadlights, bool? hasLEDHeadlights, bool? hasDaytimeDrivinglights, bool? hasAutoHeadlights, bool? hasSteeringHeadlights, bool? hasFrontFogLamp, bool? isHeadlightsHeightAdjustment, bool? hasHeadlightsCleanEquip, bool? hasInteriorAtmosphereLamp )
		{
			this.ID = iD;
			this.HasXenonHeadlights = hasXenonHeadlights;
			this.HasLEDHeadlights = hasLEDHeadlights;
			this.HasDaytimeDrivinglights = hasDaytimeDrivinglights;
			this.HasAutoHeadlights = hasAutoHeadlights;
			this.HasSteeringHeadlights = hasSteeringHeadlights;
			this.HasFrontFogLamp = hasFrontFogLamp;
			this.IsHeadlightsHeightAdjustment = isHeadlightsHeightAdjustment;
			this.HasHeadlightsCleanEquip = hasHeadlightsCleanEquip;
			this.HasInteriorAtmosphereLamp = hasInteriorAtmosphereLamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 氙气大灯
        /// </summary>
		public virtual bool? HasXenonHeadlights { get; set; }
        /// <summary>
        /// LED大灯
        /// </summary>
		public virtual bool? HasLEDHeadlights { get; set; }
        /// <summary>
        /// 日间行车灯
        /// </summary>
		public virtual bool? HasDaytimeDrivinglights { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? HasAutoHeadlights { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? HasSteeringHeadlights { get; set; }
        /// <summary>
        /// 前雾灯
        /// </summary>
		public virtual bool? HasFrontFogLamp { get; set; }
        /// <summary>
        /// 大灯高度可调
        /// </summary>
		public virtual bool? IsHeadlightsHeightAdjustment { get; set; }
        /// <summary>
        /// 大灯清洗装置
        /// </summary>
		public virtual bool? HasHeadlightsCleanEquip { get; set; }
        /// <summary>
        /// 车内氛围灯
        /// </summary>
		public virtual bool? HasInteriorAtmosphereLamp { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 