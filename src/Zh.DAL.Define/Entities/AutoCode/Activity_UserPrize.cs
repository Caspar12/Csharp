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
	#region Activity_UserPrize

	/// <summary>
    /// 活动中奖人员表
	/// Activity_UserPrize object for mapped table 'Activity_UserPrize'.
	/// </summary>
	public partial class Activity_UserPrize
	{
		
		#region Constructors
        
		public Activity_UserPrize() { }        
        
		public Activity_UserPrize( Guid iD, int identity, string shopID, string mobilePhone, Guid prizeId, int? siteAccountId, DateTime createdDate, int? state, string prizeContent, int? prize, DateTime? useDate )
		{
			this.ID = iD;
			this.Identity = identity;
			this.ShopID = shopID;
			this.MobilePhone = mobilePhone;
			this.PrizeId = prizeId;
			this.SiteAccountId = siteAccountId;
			this.CreatedDate = createdDate;
			this.State = state;
			this.PrizeContent = prizeContent;
			this.Prize = prize;
			this.UseDate = useDate;
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
        /// 网点ID
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string MobilePhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid PrizeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? SiteAccountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? State { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string PrizeContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? Prize { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? UseDate { get; set; }
        
        /// <summary>
        /// 活动奖品表
        /// </summary>            
        public virtual Activity_Prize Activity_Prize{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual T_Guest T_Guest{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 