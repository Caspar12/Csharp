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
	#region CWXLotteryHistoryDto

	/// <summary>
    /// 活动抽奖历史表
	/// CWXLotteryHistoryDto data view model for mapped table 'CWX_LotteryHistory'.
	/// </summary>
	public partial class CWXLotteryHistoryDto
	{
		
		#region Constructors
        
		public CWXLotteryHistoryDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid LotteryMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string MobilePhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? MemberId { get; set; }
        
        /// <summary>
        /// 活动表
        /// </summary>            
        public virtual CWXLotteryMainDto CWXLotteryMainDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 