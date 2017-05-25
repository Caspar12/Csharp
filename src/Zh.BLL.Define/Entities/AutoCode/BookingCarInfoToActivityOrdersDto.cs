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
	#region BookingCarInfoToActivityOrdersDto

	/// <summary>
    /// 预约活动订单表
	/// BookingCarInfoToActivityOrdersDto data view model for mapped table 'Booking_CarInfoToActivityOrders'.
	/// </summary>
	public partial class BookingCarInfoToActivityOrdersDto
	{
		
		#region Constructors
        
		public BookingCarInfoToActivityOrdersDto() { }        
        
	 
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
        public virtual MemberAccountDto MemberAccountDto{get;set;}
        /// <summary>
        /// 会员车辆信息
        /// </summary>            
        public virtual MemberCarInfoDto MemberCarInfoDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 