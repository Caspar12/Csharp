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
	#region StoreMainBrandDto

	/// <summary>
    /// 
	/// StoreMainBrandDto data view model for mapped table 'Store_MainBrand'.
	/// </summary>
	public partial class StoreMainBrandDto
	{
		
		#region Constructors
        
		public StoreMainBrandDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid StoreMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid BrandId { get; set; }
        
        /// <summary>
        /// 车辆品牌
        /// </summary>            
        public virtual CarBrandDto CarBrandDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual StoreMainDto StoreMainDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 