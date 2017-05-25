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
	#region CWX_LotteryUserPrize

	/// <summary>
    /// 活动中奖人员表
	/// CWX_LotteryUserPrize object for mapped table 'CWX_LotteryUserPrize'.
	/// </summary>
	public partial class CWX_LotteryUserPrize
	{
		
		#region Constructors
        
		public CWX_LotteryUserPrize() { }        
        
		public CWX_LotteryUserPrize( Guid iD, int identity, string mobilePhone, Guid prizeId, Guid? memberId, DateTime createdDate, int state, string content, DateTime? useDate, string validCode )
		{
			this.ID = iD;
			this.Identity = identity;
			this.MobilePhone = mobilePhone;
			this.PrizeId = prizeId;
			this.MemberId = memberId;
			this.CreatedDate = createdDate;
			this.State = state;
			this.Content = content;
			this.UseDate = useDate;
			this.ValidCode = validCode;
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
		public virtual Guid? MemberId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int State { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? UseDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ValidCode { get; set; }
        
        /// <summary>
        /// 活动奖品表
        /// </summary>            
        public virtual CWX_LotteryPrize CWX_LotteryPrize{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 