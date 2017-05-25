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
	#region WeiXin_QRCodePromotionActivityAccount

	/// <summary>
    /// 微信参加二维码推广活动用户信息表
	/// WeiXin_QRCodePromotionActivityAccount object for mapped table 'WeiXin_QRCodePromotionActivityAccount'.
	/// </summary>
	public partial class WeiXin_QRCodePromotionActivityAccount
	{
		
		#region Constructors
        
		public WeiXin_QRCodePromotionActivityAccount() { }        
        
		public WeiXin_QRCodePromotionActivityAccount( Guid iD, Guid webApplicationId, string openId, Guid? qRCodeId, int points )
		{
			this.ID = iD;
			this.WebApplicationId = webApplicationId;
			this.OpenId = openId;
			this.QRCodeId = qRCodeId;
			this.Points = points;
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
        /// 微信OpenId
        /// </summary>
		public virtual string OpenId { get; set; }
        /// <summary>
        /// 二维码Id
        /// </summary>
		public virtual Guid? QRCodeId { get; set; }
        /// <summary>
        /// 活动积分
        /// </summary>
		public virtual int Points { get; set; }
        
        /// <summary>
        /// 微信二维码信息表
        /// </summary>            
        public virtual WeiXin_QRCode WeiXin_QRCode{get;set;}
        
        /// <summary>
        /// 微信参加二维码推广活动用户积分使用历史信息表
        /// </summary>
        public virtual IList<WeiXin_QRCodePromotionActivityAccountPointsHistory> WeiXin_QRCodePromotionActivityAccountPointsHistory{get;set;}
        /// <summary>
        /// 关注微信参加二维码推广活动用户的用户记录信息表
        /// </summary>
        public virtual IList<WeiXin_QRCodePromotionActivityMemberFromAccount> WeiXin_QRCodePromotionActivityMemberFromAccount{get;set;}


		#endregion
	 
	}
	#endregion
}
 