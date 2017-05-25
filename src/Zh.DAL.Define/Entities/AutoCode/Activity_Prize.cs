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
	#region Activity_Prize

	/// <summary>
    /// 活动奖品表
	/// Activity_Prize object for mapped table 'Activity_Prize'.
	/// </summary>
	public partial class Activity_Prize
	{
		
		#region Constructors
        
		public Activity_Prize() { }        
        
		public Activity_Prize( Guid iD, int identity, string shopID, decimal beginChance, decimal endChance, int prize, string prizeContent, string prizeSmsContent, int count, Guid activityMainId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.ShopID = shopID;
			this.BeginChance = beginChance;
			this.EndChance = endChance;
			this.Prize = prize;
			this.PrizeContent = prizeContent;
			this.PrizeSmsContent = prizeSmsContent;
			this.Count = count;
			this.ActivityMainId = activityMainId;
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
        /// 网点ID
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal BeginChance { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal EndChance { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Prize { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string PrizeContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string PrizeSmsContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ActivityMainId { get; set; }
        
        /// <summary>
        /// 活动表
        /// </summary>            
        public virtual Activity_LotteryMain Activity_LotteryMain{get;set;}
        
        /// <summary>
        /// 活动中奖人员表
        /// </summary>
        public virtual IList<Activity_UserPrize> Activity_UserPrize{get;set;}


		#endregion
	 
	}
	#endregion
}
 