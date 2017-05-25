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
	#region MemberProfileToSiteCarDto

	/// <summary>
    /// 
	/// MemberProfileToSiteCarDto data view model for mapped table 'Member_ProfileToSiteCar'.
	/// </summary>
	public partial class MemberProfileToSiteCarDto
	{
		
		#region Constructors
        
		public MemberProfileToSiteCarDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid Id { get; set; }
        /// <summary>
        /// 会员站点信息ID
        /// </summary>
		public virtual Guid ProfileToSiteID { get; set; }
        /// <summary>
        /// 车辆ID
        /// </summary>
		public virtual Guid CarId { get; set; }
        /// <summary>
        /// 默认车辆
        /// </summary>
		public virtual bool IsDefault { get; set; }
        
        /// <summary>
        /// 会员车辆信息
        /// </summary>            
        public virtual MemberCarInfoDto MemberCarInfoDto{get;set;}
        /// <summary>
        /// 会员开通站点信息
        /// </summary>            
        public virtual MemberProfileToSiteDto MemberProfileToSiteDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 