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
	#region CWXLotteryUserPrizeDto

	/// <summary>
    /// 活动中奖人员表
	/// CWXLotteryUserPrizeDto data view model for mapped table 'CWX_LotteryUserPrize'.
	/// </summary>
	public partial class CWXLotteryUserPrizeDto
	{
		
		#region Constructors
        
		public CWXLotteryUserPrizeDto() { }        
        
	 
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
        public virtual CWXLotteryPrizeDto CWXLotteryPrizeDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 