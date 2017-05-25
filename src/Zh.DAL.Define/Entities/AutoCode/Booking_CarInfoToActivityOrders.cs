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
	#region Booking_CarInfoToActivityOrders

	/// <summary>
    /// 预约活动订单表
	/// Booking_CarInfoToActivityOrders object for mapped table 'Booking_CarInfoToActivityOrders'.
	/// </summary>
	public partial class Booking_CarInfoToActivityOrders
	{
		
		#region Constructors
        
		public Booking_CarInfoToActivityOrders() { }        
        
		public Booking_CarInfoToActivityOrders( Guid id, int guestId, Guid carInfoId, Guid memberId )
		{
			this.Id = id;
			this.GuestId = guestId;
			this.CarInfoId = carInfoId;
			this.MemberId = memberId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid Id { get; set; }
        /// <summary>
        /// 店会员Id
        /// </summary>
		public virtual int GuestId { get; set; }
        /// <summary>
        /// 4s集群车辆信息
        /// </summary>
		public virtual Guid CarInfoId { get; set; }
        /// <summary>
        /// 4s集群会员Id
        /// </summary>
		public virtual Guid MemberId { get; set; }
        
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual Member_Account Member_Account{get;set;}
        /// <summary>
        /// 会员车辆信息
        /// </summary>            
        public virtual Member_CarInfo Member_CarInfo{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 