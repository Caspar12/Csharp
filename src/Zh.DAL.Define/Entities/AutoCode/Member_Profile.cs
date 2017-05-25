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
	#region Member_Profile

	/// <summary>
    /// 会员资料表
	/// Member_Profile object for mapped table 'Member_Profile'.
	/// </summary>
	public partial class Member_Profile
	{
		
		#region Constructors
        
		public Member_Profile() { }        
        
		public Member_Profile( Guid id, string realName, string imageUrl, DateTime? birthday, int sex, string qQ, int? provinceID, int? cityID, int? areaID, string address )
		{
			this.Id = id;
			this.RealName = realName;
			this.ImageUrl = imageUrl;
			this.Birthday = birthday;
			this.Sex = sex;
			this.QQ = qQ;
			this.ProvinceID = provinceID;
			this.CityID = cityID;
			this.AreaID = areaID;
			this.Address = address;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 会员Id
        /// </summary>
		public virtual Guid Id { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
		public virtual string RealName { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
		public virtual string ImageUrl { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
		public virtual DateTime? Birthday { get; set; }
        /// <summary>
        /// 性别 0-男 1-女 2-保密
        /// </summary>
		public virtual int Sex { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
		public virtual string QQ { get; set; }
        /// <summary>
        /// 省份ID
        /// </summary>
		public virtual int? ProvinceID { get; set; }
        /// <summary>
        /// 市ID
        /// </summary>
		public virtual int? CityID { get; set; }
        /// <summary>
        /// 区ID
        /// </summary>
		public virtual int? AreaID { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
		public virtual string Address { get; set; }
        
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual Member_Account Member_Account{get;set;}
        /// <summary>
        /// 镇级
        /// </summary>            
        public virtual Common_Address_Area Common_Address_Area{get;set;}
        /// <summary>
        /// 市区
        /// </summary>            
        public virtual Common_Address_City Common_Address_City{get;set;}
        /// <summary>
        /// 省份
        /// </summary>            
        public virtual Common_Address_Province Common_Address_Province{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 