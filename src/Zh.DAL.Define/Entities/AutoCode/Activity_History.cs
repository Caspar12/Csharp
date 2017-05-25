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
	#region Activity_History

	/// <summary>
    /// 活动抽奖历史表
	/// Activity_History object for mapped table 'Activity_History'.
	/// </summary>
	public partial class Activity_History
	{
		
		#region Constructors
        
		public Activity_History() { }        
        
		public Activity_History( Guid iD, string shopID, Guid activityMainId, string mobilePhone, int? siteAccount )
		{
			this.ID = iD;
			this.ShopID = shopID;
			this.ActivityMainId = activityMainId;
			this.MobilePhone = mobilePhone;
			this.SiteAccount = siteAccount;
		}
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
        public virtual Activity_LotteryMain Activity_LotteryMain{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual T_Guest T_Guest{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 