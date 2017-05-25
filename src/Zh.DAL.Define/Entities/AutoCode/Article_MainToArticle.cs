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
	#region Article_MainToArticle

	/// <summary>
    /// 
	/// Article_MainToArticle object for mapped table 'Article_MainToArticle'.
	/// </summary>
	public partial class Article_MainToArticle
	{
		
		#region Constructors
        
		public Article_MainToArticle() { }        
        
		public Article_MainToArticle( Guid iD, int? articleID, Guid? article_MainID, Guid webSiteID )
		{
			this.ID = iD;
			this.ArticleID = articleID;
			this.Article_MainID = article_MainID;
			this.WebSiteID = webSiteID;
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
		public virtual int? ArticleID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? Article_MainID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid WebSiteID { get; set; }
        
        /// <summary>
        /// 文章表
        /// </summary>            
        public virtual Article_Main Article_Main{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSite WebSite{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 