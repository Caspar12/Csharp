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
	#region AdsingleDto

	/// <summary>
    /// 
	/// AdsingleDto data view model for mapped table 'Ad_single'.
	/// </summary>
	public partial class AdsingleDto
	{
		
		#region Constructors
        
		public AdsingleDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid TemplateID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string FileUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string LinkUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string FileType { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual AdTemplateDto AdTemplateDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 