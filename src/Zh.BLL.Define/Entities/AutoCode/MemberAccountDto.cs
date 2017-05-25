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
	#region MemberAccountDto

	/// <summary>
    /// 会员账号信息
	/// MemberAccountDto data view model for mapped table 'Member_Account'.
	/// </summary>
	public partial class MemberAccountDto
	{
		
		#region Constructors
        
		public MemberAccountDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 会员Id
        /// </summary>
		public virtual Guid Id { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
		public virtual string MobilePhone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
		public virtual string Email { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
		public virtual string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime LastedLoginDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Token { get; set; }
        
        
        /// <summary>
        /// 会员资料表
        /// </summary>
        public virtual MemberProfileDto MemberProfileDto{get;set;}
        /// <summary>
        /// 评论内容表
        /// </summary>
        public virtual IList<BBSCommentDto> BBSCommentDto{get;set;}
        /// <summary>
        /// 评论支持记录表
        /// </summary>
        public virtual IList<BBSCommentSupportRecordDto> BBSCommentSupportRecordDto{get;set;}
        /// <summary>
        /// 预约活动订单表
        /// </summary>
        public virtual IList<BookingCarInfoToActivityOrdersDto> BookingCarInfoToActivityOrdersDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<MemberMessageReciverDto> MemberMessageReciverDto{get;set;}
        /// <summary>
        /// 口啤印象表
        /// </summary>
        public virtual IList<PrestigeImpressionDto> PrestigeImpressionDto{get;set;}
        /// <summary>
        /// 会员车辆信息
        /// </summary>
        public virtual IList<MemberCarInfoDto> MemberCarInfoDto{get;set;}
        /// <summary>
        /// 会员账号信息
        /// </summary>
        public virtual IList<MemberEmailUpdateHistoryDto> MemberEmailUpdateHistoryDto{get;set;}
        /// <summary>
        /// 会员开通站点信息
        /// </summary>
        public virtual IList<MemberProfileToSiteDto> MemberProfileToSiteDto{get;set;}
        /// <summary>
        /// 车辆口碑帖子
        /// </summary>
        public virtual IList<PrestigePostDto> PrestigePostDto{get;set;}
        /// <summary>
        /// 口碑收藏表
        /// </summary>
        public virtual IList<PrestigePostCollectionDto> PrestigePostCollectionDto{get;set;}
        /// <summary>
        /// 微信账号对集群账号表
        /// </summary>
        public virtual IList<WeiXinAccountToCenterAccountDto> WeiXinAccountToCenterAccountDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 