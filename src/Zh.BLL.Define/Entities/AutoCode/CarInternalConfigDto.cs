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
	#region CarInternalConfigDto

	/// <summary>
    /// 内部配置
	/// CarInternalConfigDto data view model for mapped table 'Car_InternalConfig'.
	/// </summary>
	public partial class CarInternalConfigDto
	{
		
		#region Constructors
        
		public CarInternalConfigDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 真皮方向盘
        /// </summary>
		public virtual bool? LeatherSteeringWheel { get; set; }
        /// <summary>
        /// 方向盘调节
        /// </summary>
		public virtual string SteeringAdjust { get; set; }
        /// <summary>
        /// 方向盘电动调节
        /// </summary>
		public virtual bool? ElectricSteeringAdjust { get; set; }
        /// <summary>
        /// 多功能方向盘
        /// </summary>
		public virtual bool? MultifunctionalSteering { get; set; }
        /// <summary>
        /// 方向盘换档
        /// </summary>
		public virtual bool? SteeringShift { get; set; }
        /// <summary>
        /// 方向盘加热
        /// </summary>
		public virtual bool? SteeringHeat { get; set; }
        /// <summary>
        /// 定速巡航
        /// </summary>
		public virtual bool? CruiseControl { get; set; }
        /// <summary>
        /// 前驻车雷达
        /// </summary>
		public virtual bool? FrontParkingRadar { get; set; }
        /// <summary>
        /// 后驻车雷达
        /// </summary>
		public virtual bool? BackParkingRadar { get; set; }
        /// <summary>
        /// 倒车视频影像
        /// </summary>
		public virtual bool? ReverseCarVideo { get; set; }
        /// <summary>
        /// 行车电脑显示屏
        /// </summary>
		public virtual bool? DrivingComputerDisplayScreen { get; set; }
        /// <summary>
        /// HUD抬头数字显示
        /// </summary>
		public virtual bool? HUD { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 