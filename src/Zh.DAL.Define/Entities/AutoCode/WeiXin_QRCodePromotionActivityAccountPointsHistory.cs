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
	#region WeiXin_QRCodePromotionActivityAccountPointsHistory

	/// <summary>
    /// 微信参加二维码推广活动用户积分使用历史信息表
	/// WeiXin_QRCodePromotionActivityAccountPointsHistory object for mapped table 'WeiXin_QRCodePromotionActivityAccountPointsHistory'.
	/// </summary>
	public partial class WeiXin_QRCodePromotionActivityAccountPointsHistory
	{
		
		#region Constructors
        
		public WeiXin_QRCodePromotionActivityAccountPointsHistory() { }        
        
		public WeiXin_QRCodePromotionActivityAccountPointsHistory( Guid iD, Guid weiXinQRCodePromotionActivityAccountId, int usePoints, string remark, int beforePoints, int afterPoints, decimal? exchangeMoney, DateTime createdDate, string memberOpenId )
		{
   
			this.ID = iD;
   
			this.WeiXinQRCodePromotionActivityAccountId = weiXinQRCodePromotionActivityAccountId;
   
			this.UsePoints = usePoints;
   
			this.Remark = remark;
   
			this.BeforePoints = beforePoints;
   
			this.AfterPoints = afterPoints;
   
			this.ExchangeMoney = exchangeMoney;
   
			this.CreatedDate = createdDate;
   
			this.MemberOpenId = memberOpenId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 参加二维码推广活动用户信Id
        /// </summary>
		public virtual Guid WeiXinQRCodePromotionActivityAccountId { get; set; }
        /// <summary>
        /// 消费积分
        /// </summary>
		public virtual int UsePoints { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
		public virtual string Remark { get; set; }
        /// <summary>
        /// 消费前积分
        /// </summary>
		public virtual int BeforePoints { get; set; }
        /// <summary>
        /// 消费后积分
        /// </summary>
		public virtual int AfterPoints { get; set; }
        /// <summary>
        /// 兑换金钱
        /// </summary>
		public virtual decimal? ExchangeMoney { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 扫码微信OpenId
        /// </summary>
		public virtual string MemberOpenId { get; set; }
        
        /// <summary>
        /// 微信参加二维码推广活动用户信息表
        /// </summary>            
        public virtual WeiXin_QRCodePromotionActivityAccount WeiXin_QRCodePromotionActivityAccount{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 