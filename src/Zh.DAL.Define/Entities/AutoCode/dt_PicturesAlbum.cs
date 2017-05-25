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
	#region dt_PicturesAlbum

	/// <summary>
    /// 
	/// dt_PicturesAlbum object for mapped table 'dt_PicturesAlbum'.
	/// </summary>
	public partial class dt_PicturesAlbum
	{
		
		#region Constructors
        
		public dt_PicturesAlbum() { }        
        
		public dt_PicturesAlbum( int id, int pictureId, string imgUrl, byte[] stamp )
		{
			this.Id = id;
			this.PictureId = pictureId;
			this.ImgUrl = imgUrl;
			this.Stamp = stamp;
		}
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
        public virtual dt_Pictures dt_Pictures{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 