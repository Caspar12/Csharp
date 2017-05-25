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
	#region Sys_CenterToSiteTable

	/// <summary>
    /// 
	/// Sys_CenterToSiteTable object for mapped table 'Sys_CenterToSiteTable'.
	/// </summary>
	public partial class Sys_CenterToSiteTable
	{
		
		#region Constructors
        
		public Sys_CenterToSiteTable() { }        
        
		public Sys_CenterToSiteTable( Guid iD, string centerTable, Guid centerTableId, string siteTable, int siteTableId, string shopId )
		{
			this.ID = iD;
			this.CenterTable = centerTable;
			this.CenterTableId = centerTableId;
			this.SiteTable = siteTable;
			this.SiteTableId = siteTableId;
			this.ShopId = shopId;
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
 