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
	#region Article_Main

	/// <summary>
    /// 文章表
	/// Article_Main object for mapped table 'Article_Main'.
	/// </summary>
	public partial class Article_Main
	{
		
		#region Constructors
        
		public Article_Main() { }        
        
		public Article_Main( Guid iD, int identity, string url, string title, int type, int order, string daodu, Guid? imageID, bool isHot, bool isHeadNews, DateTime? addDate, Guid webSiteID, bool isCenterSite, int mainIdentity, string content, string priceRange, string carName, Guid? article_MainToBrandID, Guid? car_MainID )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Url = url;
			this.Title = title;
			this.Type = type;
			this.Order = order;
			this.Daodu = daodu;
			this.ImageID = imageID;
			this.IsHot = isHot;
			this.IsHeadNews = isHeadNews;
			this.AddDate = addDate;
			this.WebSiteID = webSiteID;
			this.IsCenterSite = isCenterSite;
			this.MainIdentity = mainIdentity;
			this.Content = content;
			this.PriceRange = priceRange;
			this.CarName = carName;
			this.Article_MainToBrandID = article_MainToBrandID;
			this.Car_MainID = car_MainID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 文章ID，对应分站点文章ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 完整Url
        /// </summary>
		public virtual string Url { get; set; }
        /// <summary>
        /// 文章标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 0:新闻,1:新车,2:促销
        /// </summary>
		public virtual int Type { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Daodu { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? ImageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsHot { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsHeadNews { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? AddDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid WebSiteID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsCenterSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int MainIdentity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string PriceRange { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string CarName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? Article_MainToBrandID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? Car_MainID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual Article_MainToBrand Article_MainToBrand{get;set;}
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual Car_Main Car_Main{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual Common_Uploads Common_Uploads{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSite WebSite{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Article_MainToArticle> Article_MainToArticle{get;set;}


		#endregion
	 
	}
	#endregion
}
 