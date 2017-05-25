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
	#region CarMainItemBrakingOfWheelDto

	/// <summary>
    /// 车轮制动参数
	/// CarMainItemBrakingOfWheelDto data view model for mapped table 'Car_MainItem_BrakingOfWheel'.
	/// </summary>
	public partial class CarMainItemBrakingOfWheelDto
	{
		
		#region Constructors
        
		public CarMainItemBrakingOfWheelDto() { }        
        
	 
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
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 