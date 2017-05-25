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
	#region PromotionActivityDto

	/// <summary>
    /// 
	/// PromotionActivityDto data view model for mapped table 'Promotion_Activity'.
	/// </summary>
	public partial class PromotionActivityDto
	{
		
		#region Constructors
        
		public PromotionActivityDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ImageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? SiteID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsShowFront { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? order { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime StarTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Daodu { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? ClickNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsHeadActivity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsHotActivity { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSiteDto WebSiteDto{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<PromotionActivityToCarSalesPromitionDto> PromotionActivityToCarSalesPromitionDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 