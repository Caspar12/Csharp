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
	#region Video_Main

	/// <summary>
    /// 
	/// Video_Main object for mapped table 'Video_Main'.
	/// </summary>
	public partial class Video_Main
	{
		
		#region Constructors
        
		public Video_Main() { }        
        
		public Video_Main( Guid iD, string title, string videoURL, DateTime addTime, int? clickNum, Guid? imageID, int? order, bool isShowFront, bool? externalLinks )
		{
			this.ID = iD;
			this.Title = title;
			this.VideoURL = videoURL;
			this.AddTime = addTime;
			this.ClickNum = clickNum;
			this.ImageID = imageID;
			this.Order = order;
			this.IsShowFront = isShowFront;
			this.ExternalLinks = externalLinks;
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
		public virtual string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string VideoURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? ClickNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? ImageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsShowFront { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool? ExternalLinks { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual Common_Uploads Common_Uploads{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Video_MainToVideo> Video_MainToVideo{get;set;}


		#endregion
	 
	}
	#endregion
}
 