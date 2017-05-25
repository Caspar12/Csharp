﻿/*
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
	#region Car_Enquiry

	/// <summary>
    /// 
	/// Car_Enquiry object for mapped table 'Car_Enquiry'.
	/// </summary>
	public partial class Car_Enquiry
	{
		
		#region Constructors
        
		public Car_Enquiry() { }        
        
		public Car_Enquiry( Guid iD, Guid car_MainItemID, int cityID, int? areaID, string guestName, string mobile, string sex, DateTime addTime, bool isFeedBack, string remark, DateTime? feedBackTime )
		{
			this.ID = iD;
			this.Car_MainItemID = car_MainItemID;
			this.CityID = cityID;
			this.AreaID = areaID;
			this.GuestName = guestName;
			this.Mobile = mobile;
			this.Sex = sex;
			this.AddTime = addTime;
			this.IsFeedBack = isFeedBack;
			this.Remark = remark;
			this.FeedBackTime = feedBackTime;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid Car_MainItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int CityID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? AreaID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string GuestName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Mobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsFeedBack { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? FeedBackTime { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        /// <summary>
        /// 镇级
        /// </summary>            
        public virtual Common_Address_Area Common_Address_Area{get;set;}
        /// <summary>
        /// 市区
        /// </summary>            
        public virtual Common_Address_City Common_Address_City{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 