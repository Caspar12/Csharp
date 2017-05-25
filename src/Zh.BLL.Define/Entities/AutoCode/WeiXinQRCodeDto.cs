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
	#region WeiXinQRCodeDto

	/// <summary>
    /// 微信二维码信息表
	/// WeiXinQRCodeDto data view model for mapped table 'WeiXin_QRCode'.
	/// </summary>
	public partial class WeiXinQRCodeDto
	{
		
		#region Constructors
        
		public WeiXinQRCodeDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 场景值ID，临时二维码时为32位非0整型，永久二维码时最大值为100000（目前参数只支持1-100000）
        /// </summary>
		public virtual int? SceneId { get; set; }
        /// <summary>
        /// 该二维码有效时间，以秒为单位。 最大不超过2592000（即30天），此字段如果不填，则默认有效期为30秒。
        /// </summary>
		public virtual int? ExpireSeconds { get; set; }
        /// <summary>
        /// 二维码类型，QR_SCENE为临时,QR_LIMIT_SCENE为永久,QR_LIMIT_STR_SCENE为永久的字符串参数值
        /// </summary>
		public virtual string ActionName { get; set; }
        /// <summary>
        /// 场景值ID（字符串形式的ID），字符串类型，长度限制为1到64，仅永久二维码支持此字段
        /// </summary>
		public virtual string SceneStr { get; set; }
        /// <summary>
        /// 微信关联WebAppId
        /// </summary>
		public virtual Guid WebApplicationId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 获取二维码Ticket
        /// </summary>
		public virtual string Ticket { get; set; }
        /// <summary>
        /// 二维码内容地址
        /// </summary>
		public virtual string QRCodeUrl { get; set; }
        
        
        /// <summary>
        /// 微信参加二维码推广活动用户信息表
        /// </summary>
        public virtual IList<WeiXinQRCodePromotionActivityAccountDto> WeiXinQRCodePromotionActivityAccountDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 