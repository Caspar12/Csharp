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
	#region Activity_Main

	/// <summary>
    /// 活动表
	/// Activity_Main object for mapped table 'Activity_Main'.
	/// </summary>
	public partial class Activity_Main
	{
		
		#region Constructors
        
		public Activity_Main() { }        
        
		public Activity_Main( Guid iD, int identity, string name, int type, DateTime? beginTime, DateTime? endTime, string shopID, string ruleContentDisplay )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Type = type;
			this.BeginTime = beginTime;
			this.EndTime = endTime;
			this.ShopID = shopID;
			this.RuleContentDisplay = ruleContentDisplay;
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
        /// 活动名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 活动类型(-1:自定义类型)
        /// </summary>
		public virtual int Type { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
		public virtual DateTime? BeginTime { get; set; }
        /// <summary>
        /// 活动结束时间
        /// </summary>
		public virtual DateTime? EndTime { get; set; }
        /// <summary>
        /// 网点ID
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string RuleContentDisplay { get; set; }
        
        
        /// <summary>
        /// 用户参与活动记录表
        /// </summary>
        public virtual IList<Activity_MainToUser> Activity_MainToUser{get;set;}


		#endregion
	 
	}
	#endregion
}
 