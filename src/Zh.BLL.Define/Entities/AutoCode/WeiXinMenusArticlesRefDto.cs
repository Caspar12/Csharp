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
	#region WeiXinMenusArticlesRefDto

	/// <summary>
    /// 微信菜单与文章表
	/// WeiXinMenusArticlesRefDto data view model for mapped table 'WeiXin_Menus_Articles_Ref'.
	/// </summary>
	public partial class WeiXinMenusArticlesRefDto
	{
		
		#region Constructors
        
		public WeiXinMenusArticlesRefDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 微信菜单Id
        /// </summary>
		public virtual Guid MenuId { get; set; }
        /// <summary>
        /// 微信文章Id
        /// </summary>
		public virtual Guid ArticleId { get; set; }
        
        /// <summary>
        /// 微信文章表
        /// </summary>            
        public virtual WeiXinArticlesDto WeiXinArticlesDto{get;set;}
        /// <summary>
        /// 微信菜单表
        /// </summary>            
        public virtual WeiXinMenusDto WeiXinMenusDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 