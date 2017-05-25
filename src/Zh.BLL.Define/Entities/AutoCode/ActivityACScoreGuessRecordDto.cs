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
	#region ActivityACScoreGuessRecordDto

	/// <summary>
    /// 对抗类比赛竞猜比分
	/// ActivityACScoreGuessRecordDto data view model for mapped table 'Activity_AC_ScoreGuessRecord'.
	/// </summary>
	public partial class ActivityACScoreGuessRecordDto
	{
		
		#region Constructors
        
		public ActivityACScoreGuessRecordDto() { }        
        
	 
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
        public virtual ActivityACMatchDto ActivityACMatchDto{get;set;}
        /// <summary>
        /// 活动用户信息扩展表
        /// </summary>            
        public virtual ActivityUserExtendInfoDto ActivityUserExtendInfoDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 