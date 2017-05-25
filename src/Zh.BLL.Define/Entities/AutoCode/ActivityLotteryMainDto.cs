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
	#region ActivityLotteryMainDto

	/// <summary>
    /// 活动表
	/// ActivityLotteryMainDto data view model for mapped table 'Activity_LotteryMain'.
	/// </summary>
	public partial class ActivityLotteryMainDto
	{
		
		#region Constructors
        
		public ActivityLotteryMainDto() { }        
        
	 
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
        public virtual IList<ActivityHistoryDto> ActivityHistoryDto{get;set;}
        /// <summary>
        /// 活动奖品表
        /// </summary>
        public virtual IList<ActivityPrizeDto> ActivityPrizeDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 