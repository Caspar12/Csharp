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
	#region WebSiteTemplateSkin

	/// <summary>
    /// 
	/// WebSiteTemplateSkin object for mapped table 'WebSiteTemplateSkin'.
	/// </summary>
	public partial class WebSiteTemplateSkin
	{
		
		#region Constructors
        
		public WebSiteTemplateSkin() { }        
        
		public WebSiteTemplateSkin( Guid iD, string skinName, string skinChineseName, int? sortID )
		{
			this.ID = iD;
			this.SkinName = skinName;
			this.SkinChineseName = skinChineseName;
			this.SortID = sortID;
		}
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
        public virtual IList<WebSiteSkinColor> WebSiteSkinColor{get;set;}


		#endregion
	 
	}
	#endregion
}
 