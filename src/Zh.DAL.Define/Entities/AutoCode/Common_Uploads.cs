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
	#region Common_Uploads

	/// <summary>
    /// 
	/// Common_Uploads object for mapped table 'Common_Uploads'.
	/// </summary>
	public partial class Common_Uploads
	{
		
		#region Constructors
        
		public Common_Uploads() { }        
        
		public Common_Uploads( Guid iD, string fileName, string url, string thumbnailUrl )
		{
			this.ID = iD;
			this.FileName = fileName;
			this.Url = url;
			this.ThumbnailUrl = thumbnailUrl;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 上传文件名称
        /// </summary>
		public virtual string FileName { get; set; }
        /// <summary>
        /// 文件Url
        /// </summary>
		public virtual string Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ThumbnailUrl { get; set; }
        
        
        /// <summary>
        /// 口碑图片表
        /// </summary>
        public virtual Prestige_PostImage Prestige_PostImage{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual Mall_GoodsImg Mall_GoodsImg{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<Car_BrandImage> Car_BrandImage{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<Car_DistributorImage> Car_DistributorImage{get;set;}
        /// <summary>
        /// 相册表
        /// </summary>
        public virtual IList<Display_PhotoAlbumsToPhotos> Display_PhotoAlbumsToPhotos{get;set;}
        /// <summary>
        /// 文章表
        /// </summary>
        public virtual IList<Article_Main> Article_Main{get;set;}
        /// <summary>
        /// 车辆品牌
        /// </summary>
        public virtual IList<Car_Brand> Car_Brand{get;set;}
        /// <summary>
        /// 车辆经销商
        /// </summary>
        public virtual IList<Car_Distributor> Car_Distributor{get;set;}
        /// <summary>
        /// 车辆图片表
        /// </summary>
        public virtual IList<Car_Image> Car_Image{get;set;}
        /// <summary>
        /// 车型表
        /// </summary>
        public virtual IList<Car_MainItem_Model> Car_MainItem_Model{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Video_Main> Video_Main{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<Store_MainImage> Store_MainImage{get;set;}


		#endregion
	 
	}
	#endregion
}
 