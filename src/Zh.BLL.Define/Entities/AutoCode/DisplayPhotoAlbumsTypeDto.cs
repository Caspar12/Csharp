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
	#region DisplayPhotoAlbumsTypeDto

	/// <summary>
    /// 相册类型表
	/// DisplayPhotoAlbumsTypeDto data view model for mapped table 'Display_PhotoAlbumsType'.
	/// </summary>
	public partial class DisplayPhotoAlbumsTypeDto
	{
		
		#region Constructors
        
		public DisplayPhotoAlbumsTypeDto() { }        
        
	 
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
        /// 相册名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int? Sort { get; set; }
        /// <summary>
        /// 显示在首页
        /// </summary>
		public virtual bool IsShowIndexPage { get; set; }
        /// <summary>
        /// 显示在列表页
        /// </summary>
		public virtual bool IsShowTypeListPage { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int IndexShowType { get; set; }
        
        
        /// <summary>
        /// 相册表
        /// </summary>
        public virtual IList<DisplayPhotoAlbumsDto> DisplayPhotoAlbumsDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 