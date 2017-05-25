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
	#region ActivityHistoryDto

	/// <summary>
    /// 活动抽奖历史表
	/// ActivityHistoryDto data view model for mapped table 'Activity_History'.
	/// </summary>
	public partial class ActivityHistoryDto
	{
		
		#region Constructors
        
		public ActivityHistoryDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 网点ID
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ActivityMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string MobilePhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? SiteAccount { get; set; }
        
        /// <summary>
        /// 活动表
        /// </summary>            
        public virtual ActivityLotteryMainDto ActivityLotteryMainDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual TGuestDto TGuestDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 