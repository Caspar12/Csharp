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
	#region CWX_WeiXinMenu

	/// <summary>
    /// 微信菜单表
	/// CWX_WeiXinMenu object for mapped table 'CWX_WeiXinMenu'.
	/// </summary>
	public partial class CWX_WeiXinMenu
	{
		
		#region Constructors
        
		public CWX_WeiXinMenu() { }        
        
		public CWX_WeiXinMenu( Guid iD, int identity, string name, string type, string key, string url, int sort, string description, Guid? weiXinApplicationId, string imgUrl, bool isSystem )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Type = type;
			this.Key = key;
			this.Url = url;
			this.Sort = sort;
			this.Description = description;
			this.WeiXinApplicationId = weiXinApplicationId;
			this.ImgUrl = imgUrl;
			this.IsSystem = isSystem;
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
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
		public virtual string Description { get; set; }
        /// <summary>
        /// 微信AppId
        /// </summary>
		public virtual Guid? WeiXinApplicationId { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
		public virtual string ImgUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsSystem { get; set; }
        
        /// <summary>
        /// 微信程序信息表
        /// </summary>            
        public virtual CWX_WeiXinApplication CWX_WeiXinApplication{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 