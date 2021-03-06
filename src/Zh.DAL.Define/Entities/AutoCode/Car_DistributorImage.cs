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
	#region Car_DistributorImage

	/// <summary>
    ///  
	/// Car_DistributorImage object for mapped table 'Car_DistributorImage'.
	/// </summary>
	public partial class Car_DistributorImage
	{
		
		#region Constructors
        
		public Car_DistributorImage() { }        
        
		public Car_DistributorImage( Guid iD, int identity, Guid imageId, Guid distributorId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.ImageId = imageId;
			this.DistributorId = distributorId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ImageId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid DistributorId { get; set; }
        
        /// <summary>
        /// 车辆经销商
        /// </summary>            
        public virtual Car_Distributor Car_Distributor{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual Common_Uploads Common_Uploads{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 