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
	#region WeiXin_Articles

	/// <summary>
    /// 微信文章表
	/// WeiXin_Articles object for mapped table 'WeiXin_Articles'.
	/// </summary>
	public partial class WeiXin_Articles
	{
		
		#region Constructors
        
		public WeiXin_Articles() { }        
        
		public WeiXin_Articles( Guid iD, int identity, string title, string description, string picUrl, string url )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Title = title;
			this.Description = description;
			this.PicUrl = picUrl;
			this.Url = url;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
		public virtual string Description { get; set; }
        /// <summary>
        /// 图片Url
        /// </summary>
		public virtual string PicUrl { get; set; }
        /// <summary>
        /// 文章Url
        /// </summary>
		public virtual string Url { get; set; }
        
        
        /// <summary>
        /// 微信菜单与文章表
        /// </summary>
        public virtual IList<WeiXin_Menus_Articles_Ref> WeiXin_Menus_Articles_Ref{get;set;}


		#endregion
	 
	}
	#endregion
}
 