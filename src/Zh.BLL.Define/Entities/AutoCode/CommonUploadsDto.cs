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
	#region CommonUploadsDto

	/// <summary>
    /// 
	/// CommonUploadsDto data view model for mapped table 'Common_Uploads'.
	/// </summary>
	public partial class CommonUploadsDto
	{
		
		#region Constructors
        
		public CommonUploadsDto() { }        
        
	 
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
        public virtual PrestigePostImageDto PrestigePostImageDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual MallGoodsImgDto MallGoodsImgDto{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<CarBrandImageDto> CarBrandImageDto{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<CarDistributorImageDto> CarDistributorImageDto{get;set;}
        /// <summary>
        /// 相册表
        /// </summary>
        public virtual IList<DisplayPhotoAlbumsToPhotosDto> DisplayPhotoAlbumsToPhotosDto{get;set;}
        /// <summary>
        /// 文章表
        /// </summary>
        public virtual IList<ArticleMainDto> ArticleMainDto{get;set;}
        /// <summary>
        /// 车辆品牌
        /// </summary>
        public virtual IList<CarBrandDto> CarBrandDto{get;set;}
        /// <summary>
        /// 车辆经销商
        /// </summary>
        public virtual IList<CarDistributorDto> CarDistributorDto{get;set;}
        /// <summary>
        /// 车辆图片表
        /// </summary>
        public virtual IList<CarImageDto> CarImageDto{get;set;}
        /// <summary>
        /// 车型表
        /// </summary>
        public virtual IList<CarMainItemModelDto> CarMainItemModelDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<VideoMainDto> VideoMainDto{get;set;}
        /// <summary>
        ///  
        /// </summary>
        public virtual IList<StoreMainImageDto> StoreMainImageDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 