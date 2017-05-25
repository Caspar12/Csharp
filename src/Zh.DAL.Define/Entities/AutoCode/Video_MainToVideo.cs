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
	#region Video_MainToVideo

	/// <summary>
    /// 
	/// Video_MainToVideo object for mapped table 'Video_MainToVideo'.
	/// </summary>
	public partial class Video_MainToVideo
	{
		
		#region Constructors
        
		public Video_MainToVideo() { }        
        
		public Video_MainToVideo( Guid iD, int? videoID, Guid? video_MainID, Guid webSiteID )
		{
			this.ID = iD;
			this.VideoID = videoID;
			this.Video_MainID = video_MainID;
			this.WebSiteID = webSiteID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? VideoID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? Video_MainID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid WebSiteID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual Video_Main Video_Main{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSite WebSite{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 