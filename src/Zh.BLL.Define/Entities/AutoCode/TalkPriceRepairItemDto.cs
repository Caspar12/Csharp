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
	#region TalkPriceRepairItemDto

	/// <summary>
    /// 
	/// TalkPriceRepairItemDto data view model for mapped table 'TalkPrice_RepairItem'.
	/// </summary>
	public partial class TalkPriceRepairItemDto
	{
		
		#region Constructors
        
		public TalkPriceRepairItemDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal SalePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid CarMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ImageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string strPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string strSalePrice { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual CarMainDto CarMainDto{get;set;}
        
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<TalkPriceRepairItemCommentDto> TalkPriceRepairItemCommentDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 