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
	#region LeagueInfo

	/// <summary>
    /// 
	/// LeagueInfo object for mapped table 'LeagueInfo'.
	/// </summary>
	public partial class LeagueInfo
	{
		
		#region Constructors
        
		public LeagueInfo() { }        
        
		public LeagueInfo( Guid iD, string shopName, string address, string linker, string department, string position, string mobilePhone, string telPhone, string email, DateTime submitTime, int feedBackState, DateTime? feedBackTime, string remark )
		{
			this.ID = iD;
			this.ShopName = shopName;
			this.Address = address;
			this.Linker = linker;
			this.Department = department;
			this.Position = position;
			this.MobilePhone = mobilePhone;
			this.TelPhone = telPhone;
			this.Email = email;
			this.SubmitTime = submitTime;
			this.FeedBackState = feedBackState;
			this.FeedBackTime = feedBackTime;
			this.Remark = remark;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 4S店全称
        /// </summary>
		public virtual string ShopName { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
		public virtual string Address { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
		public virtual string Linker { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
		public virtual string Department { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
		public virtual string Position { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
		public virtual string MobilePhone { get; set; }
        /// <summary>
        /// 固话
        /// </summary>
		public virtual string TelPhone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
		public virtual string Email { get; set; }
        /// <summary>
        /// 提交时间
        /// </summary>
		public virtual DateTime SubmitTime { get; set; }
        /// <summary>
        /// 是否跟进
        /// </summary>
		public virtual int FeedBackState { get; set; }
        /// <summary>
        /// 跟进时间
        /// </summary>
		public virtual DateTime? FeedBackTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
		public virtual string Remark { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 