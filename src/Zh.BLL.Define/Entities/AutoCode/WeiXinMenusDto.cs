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
	#region WeiXinMenusDto

	/// <summary>
    /// 微信菜单表
	/// WeiXinMenusDto data view model for mapped table 'WeiXin_Menus'.
	/// </summary>
	public partial class WeiXinMenusDto
	{
		
		#region Constructors
        
		public WeiXinMenusDto() { }        
        
	 
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
        public virtual WeiXinMenusDto WeiXinMenusDto2{get;set;}
        /// <summary>
        /// 站点微信信息表
        /// </summary>            
        public virtual WeiXinWebSiteInfoDto WeiXinWebSiteInfoDto{get;set;}
        
        /// <summary>
        /// 微信菜单与文章表
        /// </summary>
        public virtual IList<WeiXinMenusArticlesRefDto> WeiXinMenusArticlesRefDto{get;set;}
        /// <summary>
        /// 微信菜单表
        /// </summary>
        public virtual IList<WeiXinMenusDto> WeiXinMenusDto3{get;set;}


		#endregion
	 
	}
	#endregion
}
 