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
	#region Display_PhotoAlbums

	/// <summary>
    /// 相册表
	/// Display_PhotoAlbums object for mapped table 'Display_PhotoAlbums'.
	/// </summary>
	public partial class Display_PhotoAlbums
	{
		
		#region Constructors
        
		public Display_PhotoAlbums() { }        
        
		public Display_PhotoAlbums( Guid iD, int identity, int sort, Guid? carMainId, string name, Guid photoAlbumsTypeId, Guid? photoAlbumsToPhotosId, int indexShowType )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Sort = sort;
			this.CarMainId = carMainId;
			this.Name = name;
			this.PhotoAlbumsTypeId = photoAlbumsTypeId;
			this.PhotoAlbumsToPhotosId = photoAlbumsToPhotosId;
			this.IndexShowType = indexShowType;
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
        /// 关联集群车型Id
        /// </summary>
		public virtual Guid? CarMainId { get; set; }
        /// <summary>
        /// 相册名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 相册类型
        /// </summary>
		public virtual Guid PhotoAlbumsTypeId { get; set; }
        /// <summary>
        /// 相册封面图片Id
        /// </summary>
		public virtual Guid? PhotoAlbumsToPhotosId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int IndexShowType { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual Car_Main Car_Main{get;set;}
        /// <summary>
        /// 相册表
        /// </summary>            
        public virtual Display_PhotoAlbumsToPhotos Display_PhotoAlbumsToPhotos{get;set;}
        /// <summary>
        /// 相册类型表
        /// </summary>            
        public virtual Display_PhotoAlbumsType Display_PhotoAlbumsType{get;set;}
        
        /// <summary>
        /// 相册表
        /// </summary>
        public virtual IList<Display_PhotoAlbumsToPhotos> Display_PhotoAlbumsToPhotos2{get;set;}


		#endregion
	 
	}
	#endregion
}
 