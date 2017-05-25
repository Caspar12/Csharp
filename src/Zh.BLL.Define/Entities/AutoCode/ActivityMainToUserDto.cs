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
	#region ActivityMainToUserDto

	/// <summary>
    /// 用户参与活动记录表
	/// ActivityMainToUserDto data view model for mapped table 'Activity_MainToUser'.
	/// </summary>
	public partial class ActivityMainToUserDto
	{
		
		#region Constructors
        
		public ActivityMainToUserDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
		public virtual int UserID { get; set; }
        /// <summary>
        /// 活动ID
        /// </summary>
		public virtual Guid ActivityID { get; set; }
        
        /// <summary>
        /// 活动表
        /// </summary>            
        public virtual ActivityMainDto ActivityMainDto{get;set;}
        /// <summary>
        /// 活动用户信息扩展表
        /// </summary>            
        public virtual ActivityUserExtendInfoDto ActivityUserExtendInfoDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 