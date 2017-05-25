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
	#region SysCenterToSiteTableDto

	/// <summary>
    /// 
	/// SysCenterToSiteTableDto data view model for mapped table 'Sys_CenterToSiteTable'.
	/// </summary>
	public partial class SysCenterToSiteTableDto
	{
		
		#region Constructors
        
		public SysCenterToSiteTableDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string CenterTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid CenterTableId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string SiteTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int SiteTableId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ShopId { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 