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
	#region Display_PhotoAlbumsType

	/// <summary>
    /// 相册类型表
	/// Display_PhotoAlbumsType object for mapped table 'Display_PhotoAlbumsType'.
	/// </summary>
	public partial class Display_PhotoAlbumsType
	{
		
		#region Constructors
        
		public Display_PhotoAlbumsType() { }        
        
		public Display_PhotoAlbumsType( Guid iD, int identity, string name, int? sort, bool isShowIndexPage, bool isShowTypeListPage, int indexShowType )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Sort = sort;
			this.IsShowIndexPage = isShowIndexPage;
			this.IsShowTypeListPage = isShowTypeListPage;
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
        public virtual IList<Display_PhotoAlbums> Display_PhotoAlbums{get;set;}


		#endregion
	 
	}
	#endregion
}
 