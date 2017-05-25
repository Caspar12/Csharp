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
	#region ActivityTeamDto

	/// <summary>
    /// 队伍
	/// ActivityTeamDto data view model for mapped table 'Activity_Team'.
	/// </summary>
	public partial class ActivityTeamDto
	{
		
		#region Constructors
        
		public ActivityTeamDto() { }        
        
	 
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
        /// 队伍名称 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 队伍的标志
        /// </summary>
		public virtual string ImageUrl { get; set; }
        /// <summary>
        /// 组名
        /// </summary>
		public virtual string GroupName { get; set; }
        
        
        /// <summary>
        /// 冠军竞猜记录
        /// </summary>
        public virtual IList<ActivityChampionGuessRecordDto> ActivityChampionGuessRecordDto{get;set;}
        /// <summary>
        /// 对抗类比赛表
        /// </summary>
        public virtual IList<ActivityACMatchDto> ActivityACMatchDto{get;set;}
        /// <summary>
        /// 对抗类比赛表
        /// </summary>
        public virtual IList<ActivityACMatchDto> ActivityACMatchDto2{get;set;}


		#endregion
	 
	}
	#endregion
}
 