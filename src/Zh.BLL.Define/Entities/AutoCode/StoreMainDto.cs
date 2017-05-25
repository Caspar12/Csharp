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
	#region StoreMainDto

	/// <summary>
    /// 
	/// StoreMainDto data view model for mapped table 'Store_Main'.
	/// </summary>
	public partial class StoreMainDto
	{
		
		#region Constructors
        
		public StoreMainDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Contact { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? Longitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? Latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ImageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid LevelId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid TypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string WeiXinQRCodeImageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? BrandId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Contacter { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ContacterPhone { get; set; }
        
        
        /// <summary>
        /// 抽象关系表
        /// </summary>
        public virtual IList<CarMainToStoreMainRefDto> CarMainToStoreMainRefDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<CWXRepairOrderDto> CWXRepairOrderDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<StoreMainBrandDto> StoreMainBrandDto{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<StoreMainGoodCarDto> StoreMainGoodCarDto{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<StoreMainImageDto> StoreMainImageDto{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<StoreOrderDrivingTestDto> StoreOrderDrivingTestDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 