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
	#region Member_ProfileToSiteCar

	/// <summary>
    /// 
	/// Member_ProfileToSiteCar object for mapped table 'Member_ProfileToSiteCar'.
	/// </summary>
	public partial class Member_ProfileToSiteCar
	{
		
		#region Constructors
        
		public Member_ProfileToSiteCar() { }        
        
		public Member_ProfileToSiteCar( Guid id, Guid profileToSiteID, Guid carId, bool isDefault )
		{
			this.Id = id;
			this.ProfileToSiteID = profileToSiteID;
			this.CarId = carId;
			this.IsDefault = isDefault;
		}
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
        public virtual Member_CarInfo Member_CarInfo{get;set;}
        /// <summary>
        /// 会员开通站点信息
        /// </summary>            
        public virtual Member_ProfileToSite Member_ProfileToSite{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 