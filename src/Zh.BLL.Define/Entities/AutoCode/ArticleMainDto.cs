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
	#region ArticleMainDto

	/// <summary>
    /// 文章表
	/// ArticleMainDto data view model for mapped table 'Article_Main'.
	/// </summary>
	public partial class ArticleMainDto
	{
		
		#region Constructors
        
		public ArticleMainDto() { }        
        
	 
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
        public virtual ArticleMainToBrandDto ArticleMainToBrandDto{get;set;}
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual CarMainDto CarMainDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual CommonUploadsDto CommonUploadsDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSiteDto WebSiteDto{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<ArticleMainToArticleDto> ArticleMainToArticleDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 