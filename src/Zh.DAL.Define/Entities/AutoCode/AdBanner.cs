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
	#region AdBanner

	/// <summary>
    /// 
	/// AdBanner object for mapped table 'AdBanner'.
	/// </summary>
	public partial class AdBanner
	{
		
		#region Constructors
        
		public AdBanner() { }        
        
		public AdBanner( Guid iD, string name, int width, int height, string remark, bool? enabled )
		{
			this.ID = iD;
			this.Name = name;
			this.Width = width;
			this.Height = height;
			this.Remark = remark;
			this.Enabled = enabled;
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
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Width { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Height { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? Enabled { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<AdTemplate> AdTemplate{get;set;}


		#endregion
	 
	}
	#endregion
}
 