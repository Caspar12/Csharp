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
	#region CarlightsConfigDto

	/// <summary>
    /// 车辆灯光配置
	/// CarlightsConfigDto data view model for mapped table 'Car_lightsConfig'.
	/// </summary>
	public partial class CarlightsConfigDto
	{
		
		#region Constructors
        
		public CarlightsConfigDto() { }        
        
	 
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
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 