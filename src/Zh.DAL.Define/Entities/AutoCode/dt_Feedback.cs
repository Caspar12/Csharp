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
	#region dt_Feedback

	/// <summary>
    /// 
	/// dt_Feedback object for mapped table 'dt_Feedback'.
	/// </summary>
	public partial class dt_Feedback
	{
		
		#region Constructors
        
		public dt_Feedback() { }        
        
		public dt_Feedback( int id, string userName, string userTel, string userQQ, string content, int isLock, DateTime addTime, string reContent, DateTime? reTime, byte[] stamp, string sex, string address, string userHandTel, string email, DateTime? buyTime, string buyer, string guestDescribe, string type, string stoppage, string carNumber, string carBrand, string drive, string carColor, string insuranceCommpany, DateTime? insuranceDate, DateTime? registrationDate, string followup, string followType, string followAfter, DateTime? followTime )
		{
			this.Id = id;
			this.UserName = userName;
			this.UserTel = userTel;
			this.UserQQ = userQQ;
			this.Content = content;
			this.IsLock = isLock;
			this.AddTime = addTime;
			this.ReContent = reContent;
			this.ReTime = reTime;
			this.Stamp = stamp;
			this.Sex = sex;
			this.Address = address;
			this.UserHandTel = userHandTel;
			this.Email = email;
			this.BuyTime = buyTime;
			this.Buyer = buyer;
			this.GuestDescribe = guestDescribe;
			this.Type = type;
			this.Stoppage = stoppage;
			this.CarNumber = carNumber;
			this.CarBrand = carBrand;
			this.Drive = drive;
			this.CarColor = carColor;
			this.InsuranceCommpany = insuranceCommpany;
			this.InsuranceDate = insuranceDate;
			this.RegistrationDate = registrationDate;
			this.Followup = followup;
			this.FollowType = followType;
			this.FollowAfter = followAfter;
			this.FollowTime = followTime;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
		public virtual string UserName { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
		public virtual string UserTel { get; set; }
        /// <summary>
        /// 联系QQ
        /// </summary>
		public virtual string UserQQ { get; set; }
        /// <summary>
        /// 留言内容
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 是否审核，0已跟进1未跟进
        /// </summary>
		public virtual int IsLock { get; set; }
        /// <summary>
        /// 留言时间
        /// </summary>
		public virtual DateTime AddTime { get; set; }
        /// <summary>
        /// 回复内容
        /// </summary>
		public virtual string ReContent { get; set; }
        /// <summary>
        /// 回复时间
        /// </summary>
		public virtual DateTime? ReTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        /// <summary>
        /// 性别(2012-06-26添加)
        /// </summary>
		public virtual string Sex { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
		public virtual string Address { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
		public virtual string UserHandTel { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
		public virtual string Email { get; set; }
        /// <summary>
        /// 购买时间
        /// </summary>
		public virtual DateTime? BuyTime { get; set; }
        /// <summary>
        /// 留言标题
        /// </summary>
		public virtual string Buyer { get; set; }
        /// <summary>
        /// 客户需求描述
        /// </summary>
		public virtual string GuestDescribe { get; set; }
        /// <summary>
        /// 留言类型
        /// </summary>
		public virtual string Type { get; set; }
        /// <summary>
        /// 故障描述
        /// </summary>
		public virtual string Stoppage { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
		public virtual string CarNumber { get; set; }
        /// <summary>
        /// 车辆品牌
        /// </summary>
		public virtual string CarBrand { get; set; }
        /// <summary>
        /// 驱动形式
        /// </summary>
		public virtual string Drive { get; set; }
        /// <summary>
        /// 车辆颜色
        /// </summary>
		public virtual string CarColor { get; set; }
        /// <summary>
        /// 保险公司
        /// </summary>
		public virtual string InsuranceCommpany { get; set; }
        /// <summary>
        /// 投保日期
        /// </summary>
		public virtual DateTime? InsuranceDate { get; set; }
        /// <summary>
        /// 上牌日期
        /// </summary>
		public virtual DateTime? RegistrationDate { get; set; }
        /// <summary>
        /// 跟进描述
        /// </summary>
		public virtual string Followup { get; set; }
        /// <summary>
        /// 跟进类型,电话、短信、上门
        /// </summary>
		public virtual string FollowType { get; set; }
        /// <summary>
        /// 跟进后状态,需求明确,需求不明确,进入内部管理,错误单
        /// </summary>
		public virtual string FollowAfter { get; set; }
        /// <summary>
        /// 跟进时间
        /// </summary>
		public virtual DateTime? FollowTime { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 