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
	#region WeiXinWebSiteInfoDto

	/// <summary>
    /// 站点微信信息表
	/// WeiXinWebSiteInfoDto data view model for mapped table 'WeiXin_WebSiteInfo'.
	/// </summary>
	public partial class WeiXinWebSiteInfoDto
	{
		
		#region Constructors
        
		public WeiXinWebSiteInfoDto() { }        
        
	 
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
        public virtual WebSiteDto WebSiteDto{get;set;}
        
        /// <summary>
        /// 微信菜单表
        /// </summary>
        public virtual IList<WeiXinMenusDto> WeiXinMenusDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 