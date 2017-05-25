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
	#region CarDistributorImageDto

	/// <summary>
    ///  
	/// CarDistributorImageDto data view model for mapped table 'Car_DistributorImage'.
	/// </summary>
	public partial class CarDistributorImageDto
	{
		
		#region Constructors
        
		public CarDistributorImageDto() { }        
        
	 
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
        public virtual CarDistributorDto CarDistributorDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual CommonUploadsDto CommonUploadsDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 