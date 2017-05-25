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
	#region WeiXin_Menus_Articles_Ref

	/// <summary>
    /// 微信菜单与文章表
	/// WeiXin_Menus_Articles_Ref object for mapped table 'WeiXin_Menus_Articles_Ref'.
	/// </summary>
	public partial class WeiXin_Menus_Articles_Ref
	{
		
		#region Constructors
        
		public WeiXin_Menus_Articles_Ref() { }        
        
		public WeiXin_Menus_Articles_Ref( Guid iD, Guid menuId, Guid articleId )
		{
			this.ID = iD;
			this.MenuId = menuId;
			this.ArticleId = articleId;
		}
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
        public virtual WeiXin_Articles WeiXin_Articles{get;set;}
        /// <summary>
        /// 微信菜单表
        /// </summary>            
        public virtual WeiXin_Menus WeiXin_Menus{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 