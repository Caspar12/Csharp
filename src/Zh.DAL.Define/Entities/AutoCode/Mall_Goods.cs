/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 数据契约实体模型文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.DAL.Base.Define.Entities;
namespace Zh.DAL.Define.Entities
{
	#region Mall_Goods

	/// <summary>
    /// 
	/// Mall_Goods object for mapped table 'Mall_Goods'.
	/// </summary>
	public partial class Mall_Goods
	{
		
		#region Constructors
        
		public Mall_Goods() { }        
        
		public Mall_Goods( Guid id, int identity, int order, string title, string mainImgUrl, string shopId, string name, string description, DateTime? beginTime, DateTime? endTime, decimal? orderPrice, decimal? marketPrice, decimal price )
		{
			this.Id = id;
			this.Identity = identity;
			this.Order = order;
			this.Title = title;
			this.MainImgUrl = mainImgUrl;
			this.ShopId = shopId;
			this.Name = name;
			this.Description = description;
			this.BeginTime = beginTime;
			this.EndTime = endTime;
			this.OrderPrice = orderPrice;
			this.MarketPrice = marketPrice;
			this.Price = price;
		}
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
        public virtual IList<Mall_GoodsImg> Mall_GoodsImg{get;set;}


		#endregion
	 
	}
	#endregion
}
 