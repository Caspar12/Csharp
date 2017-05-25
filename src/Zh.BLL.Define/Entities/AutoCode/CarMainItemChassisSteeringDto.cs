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
	#region CarMainItemChassisSteeringDto

	/// <summary>
    /// 车辆底盘转向参数
	/// CarMainItemChassisSteeringDto data view model for mapped table 'Car_MainItem_ChassisSteering'.
	/// </summary>
	public partial class CarMainItemChassisSteeringDto
	{
		
		#region Constructors
        
		public CarMainItemChassisSteeringDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 驱动方式
        /// </summary>
		public virtual string DriveMethod { get; set; }
        /// <summary>
        /// 四驱形式
        /// </summary>
		public virtual string FourDriveMethod { get; set; }
        /// <summary>
        /// 中央差速器结构
        /// </summary>
		public virtual string CentralDifferentialStructure { get; set; }
        /// <summary>
        /// 前悬架类型
        /// </summary>
		public virtual string FrontSuspensionType { get; set; }
        /// <summary>
        /// 后悬架类型
        /// </summary>
		public virtual string BackSuspensionType { get; set; }
        /// <summary>
        /// 助力类型
        /// </summary>
		public virtual string AssistancePowerType { get; set; }
        /// <summary>
        /// 车体结构
        /// </summary>
		public virtual string BodyWorkStructure { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 