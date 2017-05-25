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
	#region WeiXin_WebSiteInfo

	/// <summary>
    /// 站点微信信息表
	/// WeiXin_WebSiteInfo object for mapped table 'WeiXin_WebSiteInfo'.
	/// </summary>
	public partial class WeiXin_WebSiteInfo
	{
		
		#region Constructors
        
		public WeiXin_WebSiteInfo() { }        
        
		public WeiXin_WebSiteInfo( Guid iD, int identity, string appID, string appSecret, string token, bool isOpen, string accessToken, DateTime? accessTokenUpdateDateTime, string logoUrl, string templateSkin, Guid? webSiteId, bool? isSelected, string weiXinName, bool? isWeiXinValid )
		{
			this.ID = iD;
			this.Identity = identity;
			this.AppID = appID;
			this.AppSecret = appSecret;
			this.Token = token;
			this.IsOpen = isOpen;
			this.AccessToken = accessToken;
			this.AccessTokenUpdateDateTime = accessTokenUpdateDateTime;
			this.LogoUrl = logoUrl;
			this.TemplateSkin = templateSkin;
			this.WebSiteId = webSiteId;
			this.IsSelected = isSelected;
			this.WeiXinName = weiXinName;
			this.IsWeiXinValid = isWeiXinValid;
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
        /// 应用ID
        /// </summary>
		public virtual string AppID { get; set; }
        /// <summary>
        /// 应用密钥
        /// </summary>
		public virtual string AppSecret { get; set; }
        /// <summary>
        /// Token
        /// </summary>
		public virtual string Token { get; set; }
        /// <summary>
        /// 开启微商店功能
        /// </summary>
		public virtual bool IsOpen { get; set; }
        /// <summary>
        /// AccessToken
        /// </summary>
		public virtual string AccessToken { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
		public virtual DateTime? AccessTokenUpdateDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string LogoUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string TemplateSkin { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? WebSiteId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? IsSelected { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string WeiXinName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? IsWeiXinValid { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSite WebSite{get;set;}
        
        /// <summary>
        /// 微信菜单表
        /// </summary>
        public virtual IList<WeiXin_Menus> WeiXin_Menus{get;set;}


		#endregion
	 
	}
	#endregion
}
 