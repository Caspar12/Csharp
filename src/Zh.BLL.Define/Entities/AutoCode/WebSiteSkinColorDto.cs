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
	#region WebSiteSkinColorDto

	/// <summary>
    /// 
	/// WebSiteSkinColorDto data view model for mapped table 'WebSiteSkinColor'.
	/// </summary>
	public partial class WebSiteSkinColorDto
	{
		
		#region Constructors
        
		public WebSiteSkinColorDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid SkinID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ColoName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string CssFileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ImgUrl { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSiteTemplateSkinDto WebSiteTemplateSkinDto{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<WebSiteDto> WebSiteDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 