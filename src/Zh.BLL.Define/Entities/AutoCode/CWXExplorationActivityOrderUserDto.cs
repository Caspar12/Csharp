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
	#region CWXExplorationActivityOrderUserDto

	/// <summary>
    /// 活动表
	/// CWXExplorationActivityOrderUserDto data view model for mapped table 'CWX_ExplorationActivity_OrderUser'.
	/// </summary>
	public partial class CWXExplorationActivityOrderUserDto
	{
		
		#region Constructors
        
		public CWXExplorationActivityOrderUserDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ExploreActivityId { get; set; }
        
        /// <summary>
        /// 活动表
        /// </summary>            
        public virtual CWXExplorationActivityMainDto CWXExplorationActivityMainDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 