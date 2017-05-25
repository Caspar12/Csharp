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
	#region CWX_LotteryMain

	/// <summary>
    /// 活动表
	/// CWX_LotteryMain object for mapped table 'CWX_LotteryMain'.
	/// </summary>
	public partial class CWX_LotteryMain
	{
		
		#region Constructors
        
		public CWX_LotteryMain() { }        
        
		public CWX_LotteryMain( Guid iD, int identity, string name, int type, DateTime? beginTime, DateTime? endTime, string ruleContentDisplay, bool? isMember, int? mobilePhoneLotteryCount, int? memberLotteryCount, bool? isWeiXinFollow, string bgImageUrl, Guid weiXinApplicationId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Type = type;
			this.BeginTime = beginTime;
			this.EndTime = endTime;
			this.RuleContentDisplay = ruleContentDisplay;
			this.IsMember = isMember;
			this.MobilePhoneLotteryCount = mobilePhoneLotteryCount;
			this.MemberLotteryCount = memberLotteryCount;
			this.IsWeiXinFollow = isWeiXinFollow;
			this.BgImageUrl = bgImageUrl;
			this.WeiXinApplicationId = weiXinApplicationId;
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
		public virtual int? MobilePhoneLotteryCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? MemberLotteryCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? IsWeiXinFollow { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string BgImageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid WeiXinApplicationId { get; set; }
        
        
        /// <summary>
        /// 活动抽奖历史表
        /// </summary>
        public virtual IList<CWX_LotteryHistory> CWX_LotteryHistory{get;set;}
        /// <summary>
        /// 活动奖品表
        /// </summary>
        public virtual IList<CWX_LotteryPrize> CWX_LotteryPrize{get;set;}


		#endregion
	 
	}
	#endregion
}
 