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
	#region Plugins_Data_Ref

	/// <summary>
    /// 第三方数据映射表
	/// Plugins_Data_Ref object for mapped table 'Plugins_Data_Ref'.
	/// </summary>
	public partial class Plugins_Data_Ref
	{
		
		#region Constructors
        
		public Plugins_Data_Ref() { }        
        
		public Plugins_Data_Ref( int iD, string pluginsID, string categoryID, string pluginsItemID, string itemID )
		{
			this.ID = iD;
			this.PluginsID = pluginsID;
			this.CategoryID = categoryID;
			this.PluginsItemID = pluginsItemID;
			this.ItemID = itemID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual int ID { get; set; }
        /// <summary>
        /// 第三方ID
        /// </summary>
		public virtual string PluginsID { get; set; }
        /// <summary>
        /// 分类ID
        /// </summary>
		public virtual string CategoryID { get; set; }
        /// <summary>
        /// 第三方数据ID
        /// </summary>
		public virtual string PluginsItemID { get; set; }
        /// <summary>
        /// 系统数据ID
        /// </summary>
		public virtual string ItemID { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 