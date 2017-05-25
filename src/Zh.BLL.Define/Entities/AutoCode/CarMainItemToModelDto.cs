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
	#region CarMainItemToModelDto

	/// <summary>
    /// 车辆与车型关系表
	/// CarMainItemToModelDto data view model for mapped table 'Car_MainItemToModel'.
	/// </summary>
	public partial class CarMainItemToModelDto
	{
		
		#region Constructors
        
		public CarMainItemToModelDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 车辆ID
        /// </summary>
		public virtual Guid CarItemID { get; set; }
        /// <summary>
        /// 车型表ID
        /// </summary>
		public virtual Guid CarModelID { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        /// <summary>
        /// 车型表
        /// </summary>            
        public virtual CarMainItemModelDto CarMainItemModelDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 