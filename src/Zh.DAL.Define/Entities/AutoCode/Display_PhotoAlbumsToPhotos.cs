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
	#region Display_PhotoAlbumsToPhotos

	/// <summary>
    /// 相册表
	/// Display_PhotoAlbumsToPhotos object for mapped table 'Display_PhotoAlbumsToPhotos'.
	/// </summary>
	public partial class Display_PhotoAlbumsToPhotos
	{
		
		#region Constructors
        
		public Display_PhotoAlbumsToPhotos() { }        
        
		public Display_PhotoAlbumsToPhotos( Guid iD, int identity, int sort, string name, Guid? uploadFileId, Guid photoAlbumId, bool isShow, string imgUrl )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Sort = sort;
			this.Name = name;
			this.UploadFileId = uploadFileId;
			this.PhotoAlbumId = photoAlbumId;
			this.IsShow = isShow;
			this.ImgUrl = imgUrl;
		}
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
        public virtual Common_Uploads Common_Uploads{get;set;}
        /// <summary>
        /// 相册表
        /// </summary>            
        public virtual Display_PhotoAlbums Display_PhotoAlbums{get;set;}
        
        /// <summary>
        /// 相册表
        /// </summary>
        public virtual IList<Display_PhotoAlbums> Display_PhotoAlbums2{get;set;}


		#endregion
	 
	}
	#endregion
}
 