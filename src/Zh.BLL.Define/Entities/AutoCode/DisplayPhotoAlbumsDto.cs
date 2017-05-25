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
	#region DisplayPhotoAlbumsDto

	/// <summary>
    /// 相册表
	/// DisplayPhotoAlbumsDto data view model for mapped table 'Display_PhotoAlbums'.
	/// </summary>
	public partial class DisplayPhotoAlbumsDto
	{
		
		#region Constructors
        
		public DisplayPhotoAlbumsDto() { }        
        
	 
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
        public virtual CarMainDto CarMainDto{get;set;}
        /// <summary>
        /// 相册表
        /// </summary>            
        public virtual DisplayPhotoAlbumsToPhotosDto DisplayPhotoAlbumsToPhotosDto{get;set;}
        /// <summary>
        /// 相册类型表
        /// </summary>            
        public virtual DisplayPhotoAlbumsTypeDto DisplayPhotoAlbumsTypeDto{get;set;}
        
        /// <summary>
        /// 相册表
        /// </summary>
        public virtual IList<DisplayPhotoAlbumsToPhotosDto> DisplayPhotoAlbumsToPhotosDto2{get;set;}


		#endregion
	 
	}
	#endregion
}
 