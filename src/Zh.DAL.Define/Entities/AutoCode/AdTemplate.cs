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
	#region AdTemplate

	/// <summary>
    /// 
	/// AdTemplate object for mapped table 'AdTemplate'.
	/// </summary>
	public partial class AdTemplate
	{
		
		#region Constructors
        
		public AdTemplate() { }        
        
		public AdTemplate( Guid iD, Guid adBannerID, string templateName, int layout, int order )
		{
			this.ID = iD;
			this.AdBannerID = adBannerID;
			this.TemplateName = templateName;
			this.Layout = layout;
			this.Order = order;
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
		public virtual Guid AdBannerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string TemplateName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Layout { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Order { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual AdBanner AdBanner{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Ad_single> Ad_single{get;set;}


		#endregion
	 
	}
	#endregion
}
 