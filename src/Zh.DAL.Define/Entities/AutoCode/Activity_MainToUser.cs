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
	#region Activity_MainToUser

	/// <summary>
    /// 用户参与活动记录表
	/// Activity_MainToUser object for mapped table 'Activity_MainToUser'.
	/// </summary>
	public partial class Activity_MainToUser
	{
		
		#region Constructors
        
		public Activity_MainToUser() { }        
        
		public Activity_MainToUser( Guid iD, int userID, Guid activityID )
		{
			this.ID = iD;
			this.UserID = userID;
			this.ActivityID = activityID;
		}
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
        public virtual Activity_Main Activity_Main{get;set;}
        /// <summary>
        /// 活动用户信息扩展表
        /// </summary>            
        public virtual Activity_UserExtendInfo Activity_UserExtendInfo{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 