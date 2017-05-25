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
	#region Car_Image

	/// <summary>
    /// 车辆图片表
	/// Car_Image object for mapped table 'Car_Image'.
	/// </summary>
	public partial class Car_Image
	{
		
		#region Constructors
        
		public Car_Image() { }        
        
		public Car_Image( Guid iD, Guid uploadID, Guid carItemID )
		{
			this.ID = iD;
			this.UploadID = uploadID;
			this.CarItemID = carItemID;
		}
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
        public virtual Car_MainItem Car_MainItem{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual Common_Uploads Common_Uploads{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 