﻿/*
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
	#region Activity_AC_ScoreGuessRecord

	/// <summary>
    /// 对抗类比赛竞猜比分
	/// Activity_AC_ScoreGuessRecord object for mapped table 'Activity_AC_ScoreGuessRecord'.
	/// </summary>
	public partial class Activity_AC_ScoreGuessRecord
	{
		
		#region Constructors
        
		public Activity_AC_ScoreGuessRecord() { }        
        
		public Activity_AC_ScoreGuessRecord( Guid iD, int userID, Guid matchID, int aTeamScore, int bTeamScore, string shopID, DateTime? guessTime )
		{
			this.ID = iD;
			this.UserID = userID;
			this.MatchID = matchID;
			this.ATeamScore = aTeamScore;
			this.BTeamScore = bTeamScore;
			this.ShopID = shopID;
			this.GuessTime = guessTime;
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
        ///  比赛ID
        /// </summary>
		public virtual Guid MatchID { get; set; }
        /// <summary>
        /// A队伍分数
        /// </summary>
		public virtual int ATeamScore { get; set; }
        /// <summary>
        /// B队伍分数
        /// </summary>
		public virtual int BTeamScore { get; set; }
        /// <summary>
        /// 网点ID
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? GuessTime { get; set; }
        
        /// <summary>
        /// 对抗类比赛表
        /// </summary>            
        public virtual Activity_AC_Match Activity_AC_Match{get;set;}
        /// <summary>
        /// 活动用户信息扩展表
        /// </summary>            
        public virtual Activity_UserExtendInfo Activity_UserExtendInfo{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 