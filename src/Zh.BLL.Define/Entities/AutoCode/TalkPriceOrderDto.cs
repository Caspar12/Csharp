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
	#region TalkPriceOrderDto

	/// <summary>
    /// 
	/// TalkPriceOrderDto data view model for mapped table 'TalkPrice_Order'.
	/// </summary>
	public partial class TalkPriceOrderDto
	{
		
		#region Constructors
        
		public TalkPriceOrderDto() { }        
        
	 
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
        /// 发布时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid CarMainItemId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? HopePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Contact { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? CategoryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? State { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string TypeTitle { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual TalkPriceCategoryDto TalkPriceCategoryDto{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TalkPriceImageDto> TalkPriceImageDto{get;set;}
        /// <summary>
        /// 短信表
        /// </summary>
        public virtual IList<TalkPriceOrderSmsRecordDto> TalkPriceOrderSmsRecordDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 