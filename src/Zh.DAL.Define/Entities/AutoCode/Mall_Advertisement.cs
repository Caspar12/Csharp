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
	#region Mall_Advertisement

	/// <summary>
    /// 
	/// Mall_Advertisement object for mapped table 'Mall_Advertisement'.
	/// </summary>
	public partial class Mall_Advertisement
	{
		
		#region Constructors
        
		public Mall_Advertisement() { }        
        
		public Mall_Advertisement( Guid id, int identity, int order, string title, string imgUrl, string hrefUrl, string shopId )
		{
			this.Id = id;
			this.Identity = identity;
			this.Order = order;
			this.Title = title;
			this.ImgUrl = imgUrl;
			this.HrefUrl = hrefUrl;
			this.ShopId = shopId;
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
		public virtual string ImgUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string HrefUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ShopId { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 