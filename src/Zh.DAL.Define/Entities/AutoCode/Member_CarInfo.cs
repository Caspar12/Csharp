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
	#region Member_CarInfo

	/// <summary>
    /// 会员车辆信息
	/// Member_CarInfo object for mapped table 'Member_CarInfo'.
	/// </summary>
	public partial class Member_CarInfo
	{
		
		#region Constructors
        
		public Member_CarInfo() { }        
        
		public Member_CarInfo( Guid iD, Guid memberID, string carNumber, Guid brandID, Guid carMainID, Guid carMainItemID )
		{
			this.ID = iD;
			this.MemberID = memberID;
			this.CarNumber = carNumber;
			this.BrandID = brandID;
			this.CarMainID = carMainID;
			this.CarMainItemID = carMainItemID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
		public virtual Guid MemberID { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
		public virtual string CarNumber { get; set; }
        /// <summary>
        /// 品牌ID
        /// </summary>
		public virtual Guid BrandID { get; set; }
        /// <summary>
        /// 车型ID
        /// </summary>
		public virtual Guid CarMainID { get; set; }
        /// <summary>
        /// 车款ID
        /// </summary>
		public virtual Guid CarMainItemID { get; set; }
        
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual Member_Account Member_Account{get;set;}
        /// <summary>
        /// 车辆品牌
        /// </summary>            
        public virtual Car_Brand Car_Brand{get;set;}
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual Car_Main Car_Main{get;set;}
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        
        /// <summary>
        /// 预约活动订单表
        /// </summary>
        public virtual IList<Booking_CarInfoToActivityOrders> Booking_CarInfoToActivityOrders{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Member_ProfileToSiteCar> Member_ProfileToSiteCar{get;set;}
        /// <summary>
        /// 维修消费记录
        /// </summary>
        public virtual IList<Repair_Orders> Repair_Orders{get;set;}


		#endregion
	 
	}
	#endregion
}
 