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
	#region Car_BrandImage

	/// <summary>
    ///  
	/// Car_BrandImage object for mapped table 'Car_BrandImage'.
	/// </summary>
	public partial class Car_BrandImage
	{
		
		#region Constructors
        
		public Car_BrandImage() { }        
        
		public Car_BrandImage( Guid iD, int identity, Guid imageId, Guid brandId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.ImageId = imageId;
			this.BrandId = brandId;
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
		public virtual Guid BrandId { get; set; }
        
        /// <summary>
        /// 车辆品牌
        /// </summary>            
        public virtual Car_Brand Car_Brand{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual Common_Uploads Common_Uploads{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 