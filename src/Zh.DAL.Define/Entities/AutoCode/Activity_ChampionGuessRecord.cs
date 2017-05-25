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
	#region Activity_ChampionGuessRecord

	/// <summary>
    /// 冠军竞猜记录
	/// Activity_ChampionGuessRecord object for mapped table 'Activity_ChampionGuessRecord'.
	/// </summary>
	public partial class Activity_ChampionGuessRecord
	{
		
		#region Constructors
        
		public Activity_ChampionGuessRecord() { }        
        
		public Activity_ChampionGuessRecord( Guid iD, int userID, Guid winnerID, string shopID, DateTime? guessTime )
		{
			this.ID = iD;
			this.UserID = userID;
			this.WinnerID = winnerID;
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
        /// 冠军队伍ID
        /// </summary>
		public virtual Guid WinnerID { get; set; }
        /// <summary>
        /// 网点ID
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? GuessTime { get; set; }
        
        /// <summary>
        /// 队伍
        /// </summary>            
        public virtual Activity_Team Activity_Team{get;set;}
        /// <summary>
        /// 活动用户信息扩展表
        /// </summary>            
        public virtual Activity_UserExtendInfo Activity_UserExtendInfo{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 