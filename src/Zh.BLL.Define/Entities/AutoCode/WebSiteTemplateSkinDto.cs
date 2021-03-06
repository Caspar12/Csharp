﻿/*
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
	#region WebSiteTemplateSkinDto

	/// <summary>
    /// 
	/// WebSiteTemplateSkinDto data view model for mapped table 'WebSiteTemplateSkin'.
	/// </summary>
	public partial class WebSiteTemplateSkinDto
	{
		
		#region Constructors
        
		public WebSiteTemplateSkinDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string SkinName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string SkinChineseName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? SortID { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<WebSiteSkinColorDto> WebSiteSkinColorDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 