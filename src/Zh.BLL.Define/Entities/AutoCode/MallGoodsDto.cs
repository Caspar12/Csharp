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
	#region MallGoodsDto

	/// <summary>
    /// 
	/// MallGoodsDto data view model for mapped table 'Mall_Goods'.
	/// </summary>
	public partial class MallGoodsDto
	{
		
		#region Constructors
        
		public MallGoodsDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid Id { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string MainImgUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ShopId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? BeginTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? OrderPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal? MarketPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal Price { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<MallGoodsImgDto> MallGoodsImgDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 