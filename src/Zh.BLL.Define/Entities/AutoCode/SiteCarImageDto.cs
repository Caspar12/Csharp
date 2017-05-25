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
	#region SiteCarImageDto

	/// <summary>
    /// 汽车之家关系表
	/// SiteCarImageDto data view model for mapped table 'Site_CarImage'.
	/// </summary>
	public partial class SiteCarImageDto
	{
		
		#region Constructors
        
		public SiteCarImageDto() { }        
        
	 
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
        /// 站点Id
        /// </summary>
		public virtual Guid WebSiteId { get; set; }
        /// <summary>
        /// 站点车型Id
        /// </summary>
		public virtual int CarTypeBigIndex { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Order { get; set; }
        /// <summary>
        /// 车型Id
        /// </summary>
		public virtual Guid? CarMainId { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual CarMainDto CarMainDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSiteDto WebSiteDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 