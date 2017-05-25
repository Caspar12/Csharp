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
	#region Member_Account

	/// <summary>
    /// 会员账号信息
	/// Member_Account object for mapped table 'Member_Account'.
	/// </summary>
	public partial class Member_Account
	{
		
		#region Constructors
        
		public Member_Account() { }        
        
		public Member_Account( Guid id, int identity, string name, string mobilePhone, string email, string password, DateTime createdDate, DateTime lastedLoginDateTime, string token )
		{
			this.Id = id;
			this.Identity = identity;
			this.Name = name;
			this.MobilePhone = mobilePhone;
			this.Email = email;
			this.Password = password;
			this.CreatedDate = createdDate;
			this.LastedLoginDateTime = lastedLoginDateTime;
			this.Token = token;
		}
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
        public virtual Member_Profile Member_Profile{get;set;}
        /// <summary>
        /// 评论内容表
        /// </summary>
        public virtual IList<BBS_Comment> BBS_Comment{get;set;}
        /// <summary>
        /// 评论支持记录表
        /// </summary>
        public virtual IList<BBS_CommentSupportRecord> BBS_CommentSupportRecord{get;set;}
        /// <summary>
        /// 预约活动订单表
        /// </summary>
        public virtual IList<Booking_CarInfoToActivityOrders> Booking_CarInfoToActivityOrders{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<MemberMessageReciver> MemberMessageReciver{get;set;}
        /// <summary>
        /// 口啤印象表
        /// </summary>
        public virtual IList<Prestige_Impression> Prestige_Impression{get;set;}
        /// <summary>
        /// 会员车辆信息
        /// </summary>
        public virtual IList<Member_CarInfo> Member_CarInfo{get;set;}
        /// <summary>
        /// 会员账号信息
        /// </summary>
        public virtual IList<Member_EmailUpdateHistory> Member_EmailUpdateHistory{get;set;}
        /// <summary>
        /// 会员开通站点信息
        /// </summary>
        public virtual IList<Member_ProfileToSite> Member_ProfileToSite{get;set;}
        /// <summary>
        /// 车辆口碑帖子
        /// </summary>
        public virtual IList<Prestige_Post> Prestige_Post{get;set;}
        /// <summary>
        /// 口碑收藏表
        /// </summary>
        public virtual IList<Prestige_PostCollection> Prestige_PostCollection{get;set;}
        /// <summary>
        /// 微信账号对集群账号表
        /// </summary>
        public virtual IList<WeiXin_AccountToCenterAccount> WeiXin_AccountToCenterAccount{get;set;}


		#endregion
	 
	}
	#endregion
}
 