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
	#region Prestige_PostImage

	/// <summary>
    /// 口碑图片表
	/// Prestige_PostImage object for mapped table 'Prestige_PostImage'.
	/// </summary>
	public partial class Prestige_PostImage
	{
		
		#region Constructors
        
		public Prestige_PostImage() { }        
        
		public Prestige_PostImage( Guid postID, Guid imageID )
		{
			this.PostID = postID;
			this.ImageID = imageID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 帖子ID
        /// </summary>
		public virtual Guid PostID { get; set; }
        /// <summary>
        /// 图片ID
        /// </summary>
		public virtual Guid ImageID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual Common_Uploads Common_Uploads{get;set;}
        /// <summary>
        /// 车辆口碑帖子
        /// </summary>            
        public virtual Prestige_Post Prestige_Post{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 