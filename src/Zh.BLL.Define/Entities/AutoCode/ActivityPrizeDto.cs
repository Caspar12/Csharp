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
	#region ActivityPrizeDto

	/// <summary>
    /// 活动奖品表
	/// ActivityPrizeDto data view model for mapped table 'Activity_Prize'.
	/// </summary>
	public partial class ActivityPrizeDto
	{
		
		#region Constructors
        
		public ActivityPrizeDto() { }        
        
	 
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
        public virtual ActivityLotteryMainDto ActivityLotteryMainDto{get;set;}
        
        /// <summary>
        /// 活动中奖人员表
        /// </summary>
        public virtual IList<ActivityUserPrizeDto> ActivityUserPrizeDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 