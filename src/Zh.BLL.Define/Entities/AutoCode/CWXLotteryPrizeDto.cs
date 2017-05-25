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
	#region CWXLotteryPrizeDto

	/// <summary>
    /// 活动奖品表
	/// CWXLotteryPrizeDto data view model for mapped table 'CWX_LotteryPrize'.
	/// </summary>
	public partial class CWXLotteryPrizeDto
	{
		
		#region Constructors
        
		public CWXLotteryPrizeDto() { }        
        
	 
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
		public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid LotteryMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsNotPrize { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        
        /// <summary>
        /// 活动表
        /// </summary>            
        public virtual CWXLotteryMainDto CWXLotteryMainDto{get;set;}
        
        /// <summary>
        /// 活动中奖人员表
        /// </summary>
        public virtual IList<CWXLotteryUserPrizeDto> CWXLotteryUserPrizeDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 