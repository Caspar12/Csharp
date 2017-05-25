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
	#region WebSiteDto

	/// <summary>
    /// 
	/// WebSiteDto data view model for mapped table 'WebSite'.
	/// </summary>
	public partial class WebSiteDto
	{
		
		#region Constructors
        
		public WebSiteDto() { }        
        
	 
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
        public virtual CarDistributorDto CarDistributorDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSiteSkinColorDto WebSiteSkinColorDto{get;set;}
        
        /// <summary>
        /// 文章表
        /// </summary>
        public virtual IList<ArticleMainDto> ArticleMainDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<ArticleMainToArticleDto> ArticleMainToArticleDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<PromotionActivityToCarSalesPromitionDto> PromotionActivityToCarSalesPromitionDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<PromotionActivityDto> PromotionActivityDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TNoticeReciverDto> TNoticeReciverDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<VideoMainToVideoDto> VideoMainToVideoDto{get;set;}
        /// <summary>
        /// 会员开通站点信息
        /// </summary>
        public virtual IList<MemberProfileToSiteDto> MemberProfileToSiteDto{get;set;}
        /// <summary>
        /// 维修消费记录
        /// </summary>
        public virtual IList<RepairOrdersDto> RepairOrdersDto{get;set;}
        /// <summary>
        /// 汽车之家关系表
        /// </summary>
        public virtual IList<SiteCarImageDto> SiteCarImageDto{get;set;}
        /// <summary>
        /// 站点微信信息表
        /// </summary>
        public virtual IList<WeiXinWebSiteInfoDto> WeiXinWebSiteInfoDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 