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
	#region Activity_LotteryMain

	/// <summary>
    /// 活动表
	/// Activity_LotteryMain object for mapped table 'Activity_LotteryMain'.
	/// </summary>
	public partial class Activity_LotteryMain
	{
		
		#region Constructors
        
		public Activity_LotteryMain() { }        
        
		public Activity_LotteryMain( Guid iD, int identity, string name, int type, DateTime? beginTime, DateTime? endTime, string shopID, string ruleContentDisplay, bool? isMember, bool? isHasMobilePhone, bool? isWeiXin, bool? isWeiXinFollow, int? mobilePhoneLotteryCount, int? memberLotteryCount, bool? isShowInIndexPage, bool? isShowInWeiXinListPage, string memberLevel )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Type = type;
			this.BeginTime = beginTime;
			this.EndTime = endTime;
			this.ShopID = shopID;
			this.RuleContentDisplay = ruleContentDisplay;
			this.IsMember = isMember;
			this.IsHasMobilePhone = isHasMobilePhone;
			this.IsWeiXin = isWeiXin;
			this.IsWeiXinFollow = isWeiXinFollow;
			this.MobilePhoneLotteryCount = mobilePhoneLotteryCount;
			this.MemberLotteryCount = memberLotteryCount;
			this.IsShowInIndexPage = isShowInIndexPage;
			this.IsShowInWeiXinListPage = isShowInWeiXinListPage;
			this.MemberLevel = memberLevel;
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
        /// 
        /// </summary>
		public virtual bool? IsMember { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? IsHasMobilePhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? IsWeiXin { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? IsWeiXinFollow { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? MobilePhoneLotteryCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? MemberLotteryCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? IsShowInIndexPage { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? IsShowInWeiXinListPage { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string MemberLevel { get; set; }
        
        
        /// <summary>
        /// 活动抽奖历史表
        /// </summary>
        public virtual IList<Activity_History> Activity_History{get;set;}
        /// <summary>
        /// 活动奖品表
        /// </summary>
        public virtual IList<Activity_Prize> Activity_Prize{get;set;}


		#endregion
	 
	}
	#endregion
}
 