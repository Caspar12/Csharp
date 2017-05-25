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
	#region VideoMainDto

	/// <summary>
    /// 
	/// VideoMainDto data view model for mapped table 'Video_Main'.
	/// </summary>
	public partial class VideoMainDto
	{
		
		#region Constructors
        
		public VideoMainDto() { }        
        
	 
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
        public virtual CommonUploadsDto CommonUploadsDto{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<VideoMainToVideoDto> VideoMainToVideoDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 