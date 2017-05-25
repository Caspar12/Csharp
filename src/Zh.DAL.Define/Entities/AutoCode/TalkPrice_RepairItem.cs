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
	#region TalkPrice_RepairItem

	/// <summary>
    /// 
	/// TalkPrice_RepairItem object for mapped table 'TalkPrice_RepairItem'.
	/// </summary>
	public partial class TalkPrice_RepairItem
	{
		
		#region Constructors
        
		public TalkPrice_RepairItem() { }        
        
		public TalkPrice_RepairItem( Guid iD, int identity, string description, decimal price, decimal salePrice, Guid carMainId, string imageUrl, string title, string strPrice, string strSalePrice )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Description = description;
			this.Price = price;
			this.SalePrice = salePrice;
			this.CarMainId = carMainId;
			this.ImageUrl = imageUrl;
			this.Title = title;
			this.strPrice = strPrice;
			this.strSalePrice = strSalePrice;
		}
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
        public virtual Car_Main Car_Main{get;set;}
        
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<TalkPrice_RepairItemComment> TalkPrice_RepairItemComment{get;set;}


		#endregion
	 
	}
	#endregion
}
 