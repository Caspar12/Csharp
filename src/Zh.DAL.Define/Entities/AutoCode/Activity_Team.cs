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
	#region Activity_Team

	/// <summary>
    /// 队伍
	/// Activity_Team object for mapped table 'Activity_Team'.
	/// </summary>
	public partial class Activity_Team
	{
		
		#region Constructors
        
		public Activity_Team() { }        
        
		public Activity_Team( Guid iD, int identity, string name, string imageUrl, string groupName )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.ImageUrl = imageUrl;
			this.GroupName = groupName;
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
        public virtual IList<Activity_ChampionGuessRecord> Activity_ChampionGuessRecord{get;set;}
        /// <summary>
        /// 对抗类比赛表
        /// </summary>
        public virtual IList<Activity_AC_Match> Activity_AC_Match{get;set;}
        /// <summary>
        /// 对抗类比赛表
        /// </summary>
        public virtual IList<Activity_AC_Match> Activity_AC_Match2{get;set;}


		#endregion
	 
	}
	#endregion
}
 