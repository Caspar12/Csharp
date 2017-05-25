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
	#region ActivityUserPrizeDto

	/// <summary>
    /// 活动中奖人员表
	/// ActivityUserPrizeDto data view model for mapped table 'Activity_UserPrize'.
	/// </summary>
	public partial class ActivityUserPrizeDto
	{
		
		#region Constructors
        
		public ActivityUserPrizeDto() { }        
        
	 
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
        public virtual ActivityPrizeDto ActivityPrizeDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual TGuestDto TGuestDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 