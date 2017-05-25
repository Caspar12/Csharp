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
	#region AdTemplateDto

	/// <summary>
    /// 
	/// AdTemplateDto data view model for mapped table 'AdTemplate'.
	/// </summary>
	public partial class AdTemplateDto
	{
		
		#region Constructors
        
		public AdTemplateDto() { }        
        
	 
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
        public virtual AdBannerDto AdBannerDto{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<AdsingleDto> AdsingleDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 