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
	#region CWXWeiXinMenuDto

	/// <summary>
    /// 微信菜单表
	/// CWXWeiXinMenuDto data view model for mapped table 'CWX_WeiXinMenu'.
	/// </summary>
	public partial class CWXWeiXinMenuDto
	{
		
		#region Constructors
        
		public CWXWeiXinMenuDto() { }        
        
	 
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
        public virtual CWXWeiXinApplicationDto CWXWeiXinApplicationDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 