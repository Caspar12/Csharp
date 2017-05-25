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
	#region Car_MainItem_BrakingOfWheel

	/// <summary>
    /// 车轮制动参数
	/// Car_MainItem_BrakingOfWheel object for mapped table 'Car_MainItem_BrakingOfWheel'.
	/// </summary>
	public partial class Car_MainItem_BrakingOfWheel
	{
		
		#region Constructors
        
		public Car_MainItem_BrakingOfWheel() { }        
        
		public Car_MainItem_BrakingOfWheel( Guid iD, string frontBrakingType, string backBrakingType, string holdBrakingType, string frontWheelSpecifications, string backWheelSpecifications, string spareWheelSpecifications )
		{
			this.ID = iD;
			this.FrontBrakingType = frontBrakingType;
			this.BackBrakingType = backBrakingType;
			this.HoldBrakingType = holdBrakingType;
			this.FrontWheelSpecifications = frontWheelSpecifications;
			this.BackWheelSpecifications = backWheelSpecifications;
			this.SpareWheelSpecifications = spareWheelSpecifications;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 前制动器类型
        /// </summary>
		public virtual string FrontBrakingType { get; set; }
        /// <summary>
        /// 后制动器类型
        /// </summary>
		public virtual string BackBrakingType { get; set; }
        /// <summary>
        /// 驻车制动器类型
        /// </summary>
		public virtual string HoldBrakingType { get; set; }
        /// <summary>
        /// 前轮胎规格
        /// </summary>
		public virtual string FrontWheelSpecifications { get; set; }
        /// <summary>
        /// 后轮胎规格
        /// </summary>
		public virtual string BackWheelSpecifications { get; set; }
        /// <summary>
        /// 备胎规格
        /// </summary>
		public virtual string SpareWheelSpecifications { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 