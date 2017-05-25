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
	#region ArticleMainToArticleDto

	/// <summary>
    /// 
	/// ArticleMainToArticleDto data view model for mapped table 'Article_MainToArticle'.
	/// </summary>
	public partial class ArticleMainToArticleDto
	{
		
		#region Constructors
        
		public ArticleMainToArticleDto() { }        
        
	 
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
        public virtual ArticleMainDto ArticleMainDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSiteDto WebSiteDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 