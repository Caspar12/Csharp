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
	#region CarImageDto

	/// <summary>
    /// 车辆图片表
	/// CarImageDto data view model for mapped table 'Car_Image'.
	/// </summary>
	public partial class CarImageDto
	{
		
		#region Constructors
        
		public CarImageDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 上传文件ID
        /// </summary>
		public virtual Guid UploadID { get; set; }
        /// <summary>
        /// 车辆ID
        /// </summary>
		public virtual Guid CarItemID { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual CommonUploadsDto CommonUploadsDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 