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
	#region CWX_ExplorationActivity_OrderUser

	/// <summary>
    /// 活动表
	/// CWX_ExplorationActivity_OrderUser object for mapped table 'CWX_ExplorationActivity_OrderUser'.
	/// </summary>
	public partial class CWX_ExplorationActivity_OrderUser
	{
		
		#region Constructors
        
		public CWX_ExplorationActivity_OrderUser() { }        
        
		public CWX_ExplorationActivity_OrderUser( Guid iD, int identity, string name, string phone, Guid exploreActivityId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Phone = phone;
			this.ExploreActivityId = exploreActivityId;
		}
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
        public virtual CWX_ExplorationActivity_Main CWX_ExplorationActivity_Main{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 