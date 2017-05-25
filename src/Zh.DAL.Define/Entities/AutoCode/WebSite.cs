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
	#region WebSite

	/// <summary>
    /// 
	/// WebSite object for mapped table 'WebSite'.
	/// </summary>
	public partial class WebSite
	{
		
		#region Constructors
        
		public WebSite() { }        
        
		public WebSite( Guid iD, string webSiteName, string webSiteUrl, string shopId, string companyName, string dbCon, string termInfo, string dataBaseName, Guid? distributorID, string initPwd, int? order, string longitude, string latitude, string cNZZSiteId, Guid? skinColorID )
		{
			this.ID = iD;
			this.WebSiteName = webSiteName;
			this.WebSiteUrl = webSiteUrl;
			this.ShopId = shopId;
			this.CompanyName = companyName;
			this.DbCon = dbCon;
			this.TermInfo = termInfo;
			this.DataBaseName = dataBaseName;
			this.DistributorID = distributorID;
			this.InitPwd = initPwd;
			this.Order = order;
			this.Longitude = longitude;
			this.Latitude = latitude;
			this.CNZZSiteId = cNZZSiteId;
			this.SkinColorID = skinColorID;
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
		public virtual string WebSiteName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string WebSiteUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ShopId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string CompanyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string DbCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string TermInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string DataBaseName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? DistributorID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string InitPwd { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Longitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string CNZZSiteId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? SkinColorID { get; set; }
        
        /// <summary>
        /// 车辆经销商
        /// </summary>            
        public virtual Car_Distributor Car_Distributor{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSiteSkinColor WebSiteSkinColor{get;set;}
        
        /// <summary>
        /// 文章表
        /// </summary>
        public virtual IList<Article_Main> Article_Main{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Article_MainToArticle> Article_MainToArticle{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Promotion_Activity_To_CarSalesPromition> Promotion_Activity_To_CarSalesPromition{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Promotion_Activity> Promotion_Activity{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<T_NoticeReciver> T_NoticeReciver{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Video_MainToVideo> Video_MainToVideo{get;set;}
        /// <summary>
        /// 会员开通站点信息
        /// </summary>
        public virtual IList<Member_ProfileToSite> Member_ProfileToSite{get;set;}
        /// <summary>
        /// 维修消费记录
        /// </summary>
        public virtual IList<Repair_Orders> Repair_Orders{get;set;}
        /// <summary>
        /// 汽车之家关系表
        /// </summary>
        public virtual IList<Site_CarImage> Site_CarImage{get;set;}
        /// <summary>
        /// 站点微信信息表
        /// </summary>
        public virtual IList<WeiXin_WebSiteInfo> WeiXin_WebSiteInfo{get;set;}


		#endregion
	 
	}
	#endregion
}
 