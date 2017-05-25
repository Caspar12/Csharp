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
	#region DisplayPhotoAlbumsToPhotosDto

	/// <summary>
    /// 相册表
	/// DisplayPhotoAlbumsToPhotosDto data view model for mapped table 'Display_PhotoAlbumsToPhotos'.
	/// </summary>
	public partial class DisplayPhotoAlbumsToPhotosDto
	{
		
		#region Constructors
        
		public DisplayPhotoAlbumsToPhotosDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 显示名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 上传文件Id
        /// </summary>
		public virtual Guid? UploadFileId { get; set; }
        /// <summary>
        /// 相册Id
        /// </summary>
		public virtual Guid PhotoAlbumId { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
		public virtual bool IsShow { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
		public virtual string ImgUrl { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual CommonUploadsDto CommonUploadsDto{get;set;}
        /// <summary>
        /// 相册表
        /// </summary>            
        public virtual DisplayPhotoAlbumsDto DisplayPhotoAlbumsDto{get;set;}
        
        /// <summary>
        /// 相册表
        /// </summary>
        public virtual IList<DisplayPhotoAlbumsDto> DisplayPhotoAlbumsDto2{get;set;}


		#endregion
	 
	}
	#endregion
}
 