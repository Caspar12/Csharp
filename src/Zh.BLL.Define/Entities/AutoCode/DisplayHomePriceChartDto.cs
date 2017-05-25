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
	#region DisplayHomePriceChartDto

	/// <summary>
    /// 首页报价表
	/// DisplayHomePriceChartDto data view model for mapped table 'Display_HomePriceChart'.
	/// </summary>
	public partial class DisplayHomePriceChartDto
	{
		
		#region Constructors
        
		public DisplayHomePriceChartDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 经销商Id
        /// </summary>
		public virtual Guid? DistributorID { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid TypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? CityId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? DiscountPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? MaxDiscountRange { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid CarMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? MarketPrice { get; set; }
        
        /// <summary>
        /// 车辆经销商
        /// </summary>            
        public virtual CarDistributorDto CarDistributorDto{get;set;}
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual CarMainDto CarMainDto{get;set;}
        /// <summary>
        /// 市区
        /// </summary>            
        public virtual CommonAddressCityDto CommonAddressCityDto{get;set;}
        /// <summary>
        /// 首页报价类型表
        /// </summary>            
        public virtual DisplayHomePriceChartTypeDto DisplayHomePriceChartTypeDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 