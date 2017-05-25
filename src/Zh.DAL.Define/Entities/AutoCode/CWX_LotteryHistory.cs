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
	#region CWX_LotteryHistory

	/// <summary>
    /// 活动抽奖历史表
	/// CWX_LotteryHistory object for mapped table 'CWX_LotteryHistory'.
	/// </summary>
	public partial class CWX_LotteryHistory
	{
		
		#region Constructors
        
		public CWX_LotteryHistory() { }        
        
		public CWX_LotteryHistory( Guid iD, Guid lotteryMainId, string mobilePhone, Guid? memberId )
		{
			this.ID = iD;
			this.LotteryMainId = lotteryMainId;
			this.MobilePhone = mobilePhone;
			this.MemberId = memberId;
		}
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
        public virtual CWX_LotteryMain CWX_LotteryMain{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 