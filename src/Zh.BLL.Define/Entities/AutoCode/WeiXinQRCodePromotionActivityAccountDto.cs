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
	#region WeiXinQRCodePromotionActivityAccountDto

	/// <summary>
    /// 微信参加二维码推广活动用户信息表
	/// WeiXinQRCodePromotionActivityAccountDto data view model for mapped table 'WeiXin_QRCodePromotionActivityAccount'.
	/// </summary>
	public partial class WeiXinQRCodePromotionActivityAccountDto
	{
		
		#region Constructors
        
		public WeiXinQRCodePromotionActivityAccountDto() { }        
        
	 
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
        public virtual WeiXinQRCodeDto WeiXinQRCodeDto{get;set;}
        
        /// <summary>
        /// 微信参加二维码推广活动用户积分使用历史信息表
        /// </summary>
        public virtual IList<WeiXinQRCodePromotionActivityAccountPointsHistoryDto> WeiXinQRCodePromotionActivityAccountPointsHistoryDto{get;set;}
        /// <summary>
        /// 关注微信参加二维码推广活动用户的用户记录信息表
        /// </summary>
        public virtual IList<WeiXinQRCodePromotionActivityMemberFromAccountDto> WeiXinQRCodePromotionActivityMemberFromAccountDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 