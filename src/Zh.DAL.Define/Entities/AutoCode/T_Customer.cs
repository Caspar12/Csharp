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
	#region T_Customer

	/// <summary>
    /// 
	/// T_Customer object for mapped table 'T_Customer'.
	/// </summary>
	public partial class T_Customer
	{
		
		#region Constructors
        
		public T_Customer() { }        
        
		public T_Customer( int customerIndex, string brandType, string brandName, string province, string city, string url, string companyName, string companyAddress, string companyShortName, string saleTel, string serverTel, string insuranceTel, DateTime? cooperationStartTime, DateTime? cooperationEndTime, byte[] stamp, string fax, string email, string tel, string honour, string followWay, string followContent, string followAfterState, string state, string websiteName, string qQ, string contact, string contactPhone, string shopID, string databaseName )
		{
			this.CustomerIndex = customerIndex;
			this.BrandType = brandType;
			this.BrandName = brandName;
			this.Province = province;
			this.City = city;
			this.Url = url;
			this.CompanyName = companyName;
			this.CompanyAddress = companyAddress;
			this.CompanyShortName = companyShortName;
			this.SaleTel = saleTel;
			this.ServerTel = serverTel;
			this.InsuranceTel = insuranceTel;
			this.CooperationStartTime = cooperationStartTime;
			this.CooperationEndTime = cooperationEndTime;
			this.Stamp = stamp;
			this.Fax = fax;
			this.Email = email;
			this.Tel = tel;
			this.honour = honour;
			this.FollowWay = followWay;
			this.FollowContent = followContent;
			this.FollowAfterState = followAfterState;
			this.State = state;
			this.WebsiteName = websiteName;
			this.QQ = qQ;
			this.Contact = contact;
			this.ContactPhone = contactPhone;
			this.ShopID = shopID;
			this.DatabaseName = databaseName;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 合作客户表
        /// </summary>
		public virtual int CustomerIndex { get; set; }
        /// <summary>
        /// 品牌所属类别
        /// </summary>
		public virtual string BrandType { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
		public virtual string BrandName { get; set; }
        /// <summary>
        /// 所属省/直辖市
        /// </summary>
		public virtual string Province { get; set; }
        /// <summary>
        /// 所属市/区
        /// </summary>
		public virtual string City { get; set; }
        /// <summary>
        /// 网址链接
        /// </summary>
		public virtual string Url { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
		public virtual string CompanyName { get; set; }
        /// <summary>
        /// 企业地址
        /// </summary>
		public virtual string CompanyAddress { get; set; }
        /// <summary>
        /// 企业简称
        /// </summary>
		public virtual string CompanyShortName { get; set; }
        /// <summary>
        /// 销售电话
        /// </summary>
		public virtual string SaleTel { get; set; }
        /// <summary>
        /// 服务电话
        /// </summary>
		public virtual string ServerTel { get; set; }
        /// <summary>
        /// 保险电话
        /// </summary>
		public virtual string InsuranceTel { get; set; }
        /// <summary>
        /// 合作开始时间
        /// </summary>
		public virtual DateTime? CooperationStartTime { get; set; }
        /// <summary>
        /// 合作结束时间
        /// </summary>
		public virtual DateTime? CooperationEndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
		public virtual string Fax { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
		public virtual string Email { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
		public virtual string Tel { get; set; }
        /// <summary>
        /// 获得荣誉
        /// </summary>
		public virtual string honour { get; set; }
        /// <summary>
        /// 跟进方式
        /// </summary>
		public virtual string FollowWay { get; set; }
        /// <summary>
        /// 跟进内容
        /// </summary>
		public virtual string FollowContent { get; set; }
        /// <summary>
        /// 跟进后状态
        /// </summary>
		public virtual string FollowAfterState { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
		public virtual string State { get; set; }
        /// <summary>
        /// 网站名称
        /// </summary>
		public virtual string WebsiteName { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
		public virtual string QQ { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
		public virtual string Contact { get; set; }
        /// <summary>
        /// 联系人电话
        /// </summary>
		public virtual string ContactPhone { get; set; }
        /// <summary>
        /// 店号
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 数据库名称
        /// </summary>
		public virtual string DatabaseName { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 