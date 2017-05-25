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
	#region WeiXin_Menus

	/// <summary>
    /// 微信菜单表
	/// WeiXin_Menus object for mapped table 'WeiXin_Menus'.
	/// </summary>
	public partial class WeiXin_Menus
	{
		
		#region Constructors
        
		public WeiXin_Menus() { }        
        
		public WeiXin_Menus( Guid iD, int identity, Guid? webSiteInfoId, string name, string type, string key, string url, bool isSystemMenu, int sort, Guid? parentId, bool isShowOnWeiXin, string description, string imgUrl )
		{
			this.ID = iD;
			this.Identity = identity;
			this.WebSiteInfoId = webSiteInfoId;
			this.Name = name;
			this.Type = type;
			this.Key = key;
			this.Url = url;
			this.IsSystemMenu = isSystemMenu;
			this.Sort = sort;
			this.ParentId = parentId;
			this.IsShowOnWeiXin = isShowOnWeiXin;
			this.Description = description;
			this.ImgUrl = imgUrl;
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
        /// 站点微信信息Id
        /// </summary>
		public virtual Guid? WebSiteInfoId { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 事件类型
        /// </summary>
		public virtual string Type { get; set; }
        /// <summary>
        /// 事件KEY值
        /// </summary>
		public virtual string Key { get; set; }
        /// <summary>
        /// 跳转Url
        /// </summary>
		public virtual string Url { get; set; }
        /// <summary>
        /// 系统菜单
        /// </summary>
		public virtual bool IsSystemMenu { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 父Id
        /// </summary>
		public virtual Guid? ParentId { get; set; }
        /// <summary>
        /// 是否显示在微信
        /// </summary>
		public virtual bool IsShowOnWeiXin { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ImgUrl { get; set; }
        
        /// <summary>
        /// 微信菜单表
        /// </summary>            
        public virtual WeiXin_Menus WeiXin_Menus2{get;set;}
        /// <summary>
        /// 站点微信信息表
        /// </summary>            
        public virtual WeiXin_WebSiteInfo WeiXin_WebSiteInfo{get;set;}
        
        /// <summary>
        /// 微信菜单与文章表
        /// </summary>
        public virtual IList<WeiXin_Menus_Articles_Ref> WeiXin_Menus_Articles_Ref{get;set;}
        /// <summary>
        /// 微信菜单表
        /// </summary>
        public virtual IList<WeiXin_Menus> WeiXin_Menus3{get;set;}


		#endregion
	 
	}
	#endregion
}
 