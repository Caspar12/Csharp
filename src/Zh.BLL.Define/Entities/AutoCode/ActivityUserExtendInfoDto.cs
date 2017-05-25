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
	#region ActivityUserExtendInfoDto

	/// <summary>
    /// 活动用户信息扩展表
	/// ActivityUserExtendInfoDto data view model for mapped table 'Activity_UserExtendInfo'.
	/// </summary>
	public partial class ActivityUserExtendInfoDto
	{
		
		#region Constructors
        
		public ActivityUserExtendInfoDto() { }        
        
	 
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
        public virtual IList<ActivityACWinnerGuessRecordDto> ActivityACWinnerGuessRecordDto{get;set;}
        /// <summary>
        /// 冠军竞猜记录
        /// </summary>
        public virtual IList<ActivityChampionGuessRecordDto> ActivityChampionGuessRecordDto{get;set;}
        /// <summary>
        /// 用户参与活动记录表
        /// </summary>
        public virtual IList<ActivityMainToUserDto> ActivityMainToUserDto{get;set;}
        /// <summary>
        /// 对抗类比赛竞猜比分
        /// </summary>
        public virtual IList<ActivityACScoreGuessRecordDto> ActivityACScoreGuessRecordDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 