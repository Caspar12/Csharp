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
	#region WeiXin_QRCodePromotionActivityMemberFromAccount

	/// <summary>
    /// 关注微信参加二维码推广活动用户的用户记录信息表
	/// WeiXin_QRCodePromotionActivityMemberFromAccount object for mapped table 'WeiXin_QRCodePromotionActivityMemberFromAccount'.
	/// </summary>
	public partial class WeiXin_QRCodePromotionActivityMemberFromAccount
	{
		
		#region Constructors
        
		public WeiXin_QRCodePromotionActivityMemberFromAccount() { }        
        
		public WeiXin_QRCodePromotionActivityMemberFromAccount( Guid iD, Guid webApplicationId, string activityOpenId, string memberOpenId, Guid? weiXinQRCodePromotionActivityAccountId )
		{
			this.ID = iD;
			this.WebApplicationId = webApplicationId;
			this.ActivityOpenId = activityOpenId;
			this.MemberOpenId = memberOpenId;
			this.WeiXinQRCodePromotionActivityAccountId = weiXinQRCodePromotionActivityAccountId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 微信关联WebAppId
        /// </summary>
		public virtual Guid WebApplicationId { get; set; }
        /// <summary>
        /// 微信参加二维码推广活动用户OpenId
        /// </summary>
		public virtual string ActivityOpenId { get; set; }
        /// <summary>
        /// 关注用户OpenId
        /// </summary>
		public virtual string MemberOpenId { get; set; }
        /// <summary>
        /// 微信参加二维码推广活动用户Id
        /// </summary>
		public virtual Guid? WeiXinQRCodePromotionActivityAccountId { get; set; }
        
        /// <summary>
        /// 微信参加二维码推广活动用户信息表
        /// </summary>            
        public virtual WeiXin_QRCodePromotionActivityAccount WeiXin_QRCodePromotionActivityAccount{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 