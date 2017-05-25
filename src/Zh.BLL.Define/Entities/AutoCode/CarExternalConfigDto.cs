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
	#region CarExternalConfigDto

	/// <summary>
    /// 外部配置
	/// CarExternalConfigDto data view model for mapped table 'Car_ExternalConfig'.
	/// </summary>
	public partial class CarExternalConfigDto
	{
		
		#region Constructors
        
		public CarExternalConfigDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 电动天窗
        /// </summary>
		public virtual bool? PowerSunroof { get; set; }
        /// <summary>
        /// 全景天窗
        /// </summary>
		public virtual bool? PanoramicSunroof { get; set; }
        /// <summary>
        /// 运动外观套件
        /// </summary>
		public virtual bool? SportAppearancePackag { get; set; }
        /// <summary>
        /// 铝金轮圈
        /// </summary>
		public virtual bool? AluminumAlloyWheels { get; set; }
        /// <summary>
        /// 电动吸合门
        /// </summary>
		public virtual bool? ElectricSuctionDoor { get; set; }
        /// <summary>
        /// 侧滑门
        /// </summary>
		public virtual string SlidingDoor { get; set; }
        /// <summary>
        /// 电动后备厢
        /// </summary>
		public virtual bool? ElectricTrunk { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 