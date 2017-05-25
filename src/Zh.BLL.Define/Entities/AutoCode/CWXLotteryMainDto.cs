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
	#region CWXLotteryMainDto

	/// <summary>
    /// 活动表
	/// CWXLotteryMainDto data view model for mapped table 'CWX_LotteryMain'.
	/// </summary>
	public partial class CWXLotteryMainDto
	{
		
		#region Constructors
        
		public CWXLotteryMainDto() { }        
        
	 
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
        public virtual IList<CWXLotteryHistoryDto> CWXLotteryHistoryDto{get;set;}
        /// <summary>
        /// 活动奖品表
        /// </summary>
        public virtual IList<CWXLotteryPrizeDto> CWXLotteryPrizeDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 