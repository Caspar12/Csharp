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
	#region Car_InternalConfig

	/// <summary>
    /// 内部配置
	/// Car_InternalConfig object for mapped table 'Car_InternalConfig'.
	/// </summary>
	public partial class Car_InternalConfig
	{
		
		#region Constructors
        
		public Car_InternalConfig() { }        
        
		public Car_InternalConfig( Guid iD, bool? leatherSteeringWheel, string steeringAdjust, bool? electricSteeringAdjust, bool? multifunctionalSteering, bool? steeringShift, bool? steeringHeat, bool? cruiseControl, bool? frontParkingRadar, bool? backParkingRadar, bool? reverseCarVideo, bool? drivingComputerDisplayScreen, bool? hUD )
		{
			this.ID = iD;
			this.LeatherSteeringWheel = leatherSteeringWheel;
			this.SteeringAdjust = steeringAdjust;
			this.ElectricSteeringAdjust = electricSteeringAdjust;
			this.MultifunctionalSteering = multifunctionalSteering;
			this.SteeringShift = steeringShift;
			this.SteeringHeat = steeringHeat;
			this.CruiseControl = cruiseControl;
			this.FrontParkingRadar = frontParkingRadar;
			this.BackParkingRadar = backParkingRadar;
			this.ReverseCarVideo = reverseCarVideo;
			this.DrivingComputerDisplayScreen = drivingComputerDisplayScreen;
			this.HUD = hUD;
		}
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
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 