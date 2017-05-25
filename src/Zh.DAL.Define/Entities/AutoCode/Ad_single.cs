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
	#region Ad_single

	/// <summary>
    /// 
	/// Ad_single object for mapped table 'Ad_single'.
	/// </summary>
	public partial class Ad_single
	{
		
		#region Constructors
        
		public Ad_single() { }        
        
		public Ad_single( Guid iD, Guid templateID, string fileUrl, string linkUrl, int order, string fileType, string name )
		{
			this.ID = iD;
			this.TemplateID = templateID;
			this.FileUrl = fileUrl;
			this.LinkUrl = linkUrl;
			this.Order = order;
			this.FileType = fileType;
			this.Name = name;
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
        public virtual AdTemplate AdTemplate{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 