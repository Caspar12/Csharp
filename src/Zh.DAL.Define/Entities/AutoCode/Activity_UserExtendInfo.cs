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
	#region Activity_UserExtendInfo

	/// <summary>
    /// 活动用户信息扩展表
	/// Activity_UserExtendInfo object for mapped table 'Activity_UserExtendInfo'.
	/// </summary>
	public partial class Activity_UserExtendInfo
	{
		
		#region Constructors
        
		public Activity_UserExtendInfo() { }        
        
		public Activity_UserExtendInfo( int iD, string password )
		{
			this.ID = iD;
			this.Password = password;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 用户ID
        /// </summary>
		public virtual int ID { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
		public virtual string Password { get; set; }
        
        
        /// <summary>
        /// 积分竞猜记录
        /// </summary>
        public virtual IList<Activity_AC_WinnerGuessRecord> Activity_AC_WinnerGuessRecord{get;set;}
        /// <summary>
        /// 冠军竞猜记录
        /// </summary>
        public virtual IList<Activity_ChampionGuessRecord> Activity_ChampionGuessRecord{get;set;}
        /// <summary>
        /// 用户参与活动记录表
        /// </summary>
        public virtual IList<Activity_MainToUser> Activity_MainToUser{get;set;}
        /// <summary>
        /// 对抗类比赛竞猜比分
        /// </summary>
        public virtual IList<Activity_AC_ScoreGuessRecord> Activity_AC_ScoreGuessRecord{get;set;}


		#endregion
	 
	}
	#endregion
}
 