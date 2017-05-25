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
	#region WebSiteSkinColor

	/// <summary>
    /// 
	/// WebSiteSkinColor object for mapped table 'WebSiteSkinColor'.
	/// </summary>
	public partial class WebSiteSkinColor
	{
		
		#region Constructors
        
		public WebSiteSkinColor() { }        
        
		public WebSiteSkinColor( Guid iD, Guid skinID, string coloName, string cssFileName, string imgUrl )
		{
			this.ID = iD;
			this.SkinID = skinID;
			this.ColoName = coloName;
			this.CssFileName = cssFileName;
			this.ImgUrl = imgUrl;
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
        public virtual WebSiteTemplateSkin WebSiteTemplateSkin{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<WebSite> WebSite{get;set;}


		#endregion
	 
	}
	#endregion
}
 