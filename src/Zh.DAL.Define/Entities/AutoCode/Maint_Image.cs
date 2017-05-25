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
	#region Maint_Image

	/// <summary>
    /// 
	/// Maint_Image object for mapped table 'Maint_Image'.
	/// </summary>
	public partial class Maint_Image
	{
		
		#region Constructors
        
		public Maint_Image() { }        
        
		public Maint_Image( Guid iD, int identity, string url, string fileName, Guid maintId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Url = url;
			this.FileName = fileName;
			this.MaintId = maintId;
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
        /// 
        /// </summary>
		public virtual string Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string FileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid MaintId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual Maint_Main Maint_Main{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 