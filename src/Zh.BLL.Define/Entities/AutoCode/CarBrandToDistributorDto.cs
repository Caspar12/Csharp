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
	#region CarBrandToDistributorDto

	/// <summary>
    /// 品牌与经销商关系表
	/// CarBrandToDistributorDto data view model for mapped table 'Car_BrandToDistributor'.
	/// </summary>
	public partial class CarBrandToDistributorDto
	{
		
		#region Constructors
        
		public CarBrandToDistributorDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 品牌ID
        /// </summary>
		public virtual Guid BrandID { get; set; }
        /// <summary>
        /// 经销商ID
        /// </summary>
		public virtual Guid DistributorID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? CityId { get; set; }
        
        /// <summary>
        /// 市区
        /// </summary>            
        public virtual CommonAddressCityDto CommonAddressCityDto{get;set;}
        /// <summary>
        /// 车辆品牌
        /// </summary>            
        public virtual CarBrandDto CarBrandDto{get;set;}
        /// <summary>
        /// 车辆经销商
        /// </summary>            
        public virtual CarDistributorDto CarDistributorDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 