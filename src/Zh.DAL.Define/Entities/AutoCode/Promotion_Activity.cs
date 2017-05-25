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
	#region Promotion_Activity

	/// <summary>
    /// 
	/// Promotion_Activity object for mapped table 'Promotion_Activity'.
	/// </summary>
	public partial class Promotion_Activity
	{
		
		#region Constructors
        
		public Promotion_Activity() { }        
        
		public Promotion_Activity( Guid iD, string title, string url, string imageUrl, Guid? siteID, bool isShowFront, int? order, DateTime starTime, DateTime endTime, string daodu, int? clickNum, bool isHeadActivity, bool isHotActivity )
		{
			this.ID = iD;
			this.Title = title;
			this.Url = url;
			this.ImageUrl = imageUrl;
			this.SiteID = siteID;
			this.IsShowFront = isShowFront;
			this.order = order;
			this.StarTime = starTime;
			this.EndTime = endTime;
			this.Daodu = daodu;
			this.ClickNum = clickNum;
			this.IsHeadActivity = isHeadActivity;
			this.IsHotActivity = isHotActivity;
		}
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
        public virtual WebSite WebSite{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Promotion_Activity_To_CarSalesPromition> Promotion_Activity_To_CarSalesPromition{get;set;}


		#endregion
	 
	}
	#endregion
}
 