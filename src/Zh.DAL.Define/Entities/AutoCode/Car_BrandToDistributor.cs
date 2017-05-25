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
	#region Car_BrandToDistributor

	/// <summary>
    /// 品牌与经销商关系表
	/// Car_BrandToDistributor object for mapped table 'Car_BrandToDistributor'.
	/// </summary>
	public partial class Car_BrandToDistributor
	{
		
		#region Constructors
        
		public Car_BrandToDistributor() { }        
        
		public Car_BrandToDistributor( Guid iD, Guid brandID, Guid distributorID, int? cityId )
		{
			this.ID = iD;
			this.BrandID = brandID;
			this.DistributorID = distributorID;
			this.CityId = cityId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 品牌ID
        /// </summary>
		public virtual Guid BrandID { get; set; }
        /// <summary>
        /// 经销商ID
        /// </summary>
		public virtual Guid DistributorID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? CityId { get; set; }
        
        /// <summary>
        /// 市区
        /// </summary>            
        public virtual Common_Address_City Common_Address_City{get;set;}
        /// <summary>
        /// 车辆品牌
        /// </summary>            
        public virtual Car_Brand Car_Brand{get;set;}
        /// <summary>
        /// 车辆经销商
        /// </summary>            
        public virtual Car_Distributor Car_Distributor{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 