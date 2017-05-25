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
	#region CarControlConfigDto

	/// <summary>
    /// 车辆操控配置
	/// CarControlConfigDto data view model for mapped table 'Car_ControlConfig'.
	/// </summary>
	public partial class CarControlConfigDto
	{
		
		#region Constructors
        
		public CarControlConfigDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// ABS防抱死
        /// </summary>
		public virtual bool? ABS { get; set; }
        /// <summary>
        /// 制动力分配(EBD/CBC)
        /// </summary>
		public virtual bool? BrakingPower { get; set; }
        /// <summary>
        /// 刹车辅助(EBA/BAS/BA等)
        /// </summary>
		public virtual bool? BrakingAuxiliary { get; set; }
        /// <summary>
        /// 牵引力控制(ESC/ESP/DSC等)
        /// </summary>
		public virtual bool? TractionControl { get; set; }
        /// <summary>
        /// 车身稳定控制(ESC/ESP/DSC等)
        /// </summary>
		public virtual bool? VehicleStabilityControl { get; set; }
        /// <summary>
        /// 自动驻车/上坡辅助
        /// </summary>
		public virtual bool? AutoHold { get; set; }
        /// <summary>
        /// 陡坡缓降
        /// </summary>
		public virtual bool? HDC { get; set; }
        /// <summary>
        /// 可变悬架
        /// </summary>
		public virtual string VariableSuspension { get; set; }
        /// <summary>
        /// 空气悬架
        /// </summary>
		public virtual bool? AirSuspension { get; set; }
        /// <summary>
        /// 可变转向比
        /// </summary>
		public virtual bool? VariableRatoSteering { get; set; }
        /// <summary>
        /// 前桥限滑差速器/差速锁
        /// </summary>
		public virtual bool? FrontDifferentialLock { get; set; }
        /// <summary>
        /// 中央差速器锁止功能
        /// </summary>
		public virtual bool? CenterDifferentialLock { get; set; }
        /// <summary>
        /// 前桥限滑差速器/差速锁
        /// </summary>
		public virtual string BackDifferentialLock { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 