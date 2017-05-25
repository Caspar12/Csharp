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
	#region MemberCarInfoDto

	/// <summary>
    /// 会员车辆信息
	/// MemberCarInfoDto data view model for mapped table 'Member_CarInfo'.
	/// </summary>
	public partial class MemberCarInfoDto
	{
		
		#region Constructors
        
		public MemberCarInfoDto() { }        
        
	 
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
        public virtual MemberAccountDto MemberAccountDto{get;set;}
        /// <summary>
        /// 车辆品牌
        /// </summary>            
        public virtual CarBrandDto CarBrandDto{get;set;}
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual CarMainDto CarMainDto{get;set;}
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        
        /// <summary>
        /// 预约活动订单表
        /// </summary>
        public virtual IList<BookingCarInfoToActivityOrdersDto> BookingCarInfoToActivityOrdersDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<MemberProfileToSiteCarDto> MemberProfileToSiteCarDto{get;set;}
        /// <summary>
        /// 维修消费记录
        /// </summary>
        public virtual IList<RepairOrdersDto> RepairOrdersDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 