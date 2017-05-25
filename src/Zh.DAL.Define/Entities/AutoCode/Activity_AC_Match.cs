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
	#region Activity_AC_Match

	/// <summary>
    /// 对抗类比赛表
	/// Activity_AC_Match object for mapped table 'Activity_AC_Match'.
	/// </summary>
	public partial class Activity_AC_Match
	{
		
		#region Constructors
        
		public Activity_AC_Match() { }        
        
		public Activity_AC_Match( Guid iD, int identity, DateTime beginTime, DateTime endTime, Guid aTeamID, Guid bTeamID, int type, string shopID, int? aTeamScore, int? bTeamScore )
		{
			this.ID = iD;
			this.Identity = identity;
			this.BeginTime = beginTime;
			this.EndTime = endTime;
			this.ATeamID = aTeamID;
			this.BTeamID = bTeamID;
			this.Type = type;
			this.ShopID = shopID;
			this.ATeamScore = aTeamScore;
			this.BTeamScore = bTeamScore;
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
        /// 比赛 开始时间
        /// </summary>
		public virtual DateTime BeginTime { get; set; }
        /// <summary>
        /// 比赛 结束时间
        /// </summary>
		public virtual DateTime EndTime { get; set; }
        /// <summary>
        /// A 队伍ID
        /// </summary>
		public virtual Guid ATeamID { get; set; }
        /// <summary>
        /// B 队伍ID
        /// </summary>
		public virtual Guid BTeamID { get; set; }
        /// <summary>
        /// 比赛类型(0:普通，1:16强，2::8强，3:4强，4:决赛)
        /// </summary>
		public virtual int Type { get; set; }
        /// <summary>
        /// 网点ID
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// A队伍比赛结果 
        /// </summary>
		public virtual int? ATeamScore { get; set; }
        /// <summary>
        /// B队伍比赛结果 
        /// </summary>
		public virtual int? BTeamScore { get; set; }
        
        /// <summary>
        /// 队伍
        /// </summary>            
        public virtual Activity_Team Activity_Team{get;set;}
        /// <summary>
        /// 队伍
        /// </summary>            
        public virtual Activity_Team Activity_Team2{get;set;}
        
        /// <summary>
        /// 积分竞猜记录
        /// </summary>
        public virtual IList<Activity_AC_WinnerGuessRecord> Activity_AC_WinnerGuessRecord{get;set;}
        /// <summary>
        /// 对抗类比赛竞猜比分
        /// </summary>
        public virtual IList<Activity_AC_ScoreGuessRecord> Activity_AC_ScoreGuessRecord{get;set;}


		#endregion
	 
	}
	#endregion
}
 