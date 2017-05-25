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
	#region dtPicturesAlbumDto

	/// <summary>
    /// 
	/// dtPicturesAlbumDto data view model for mapped table 'dt_PicturesAlbum'.
	/// </summary>
	public partial class dtPicturesAlbumDto
	{
		
		#region Constructors
        
		public dtPicturesAlbumDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int PictureId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ImgUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual dtPicturesDto dtPicturesDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 