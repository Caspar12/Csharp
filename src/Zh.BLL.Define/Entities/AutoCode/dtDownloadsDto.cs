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
	#region dtDownloadsDto

	/// <summary>
    /// 
	/// dtDownloadsDto data view model for mapped table 'dt_Downloads'.
	/// </summary>
	public partial class dtDownloadsDto
	{
		
		#region Constructors
        
		public dtDownloadsDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 文件标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 所属类别
        /// </summary>
		public virtual int ClassId { get; set; }
        /// <summary>
        /// 预览图片
        /// </summary>
		public virtual string ImgUrl { get; set; }
        /// <summary>
        /// 文件类型
        /// </summary>
		public virtual string FileType { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
		public virtual int FileSize { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary>
		public virtual string FilePath { get; set; }
        /// <summary>
        /// 浏览数量
        /// </summary>
		public virtual int Click { get; set; }
        /// <summary>
        /// 下载次数
        /// </summary>
		public virtual int DownNum { get; set; }
        /// <summary>
        /// 详细说明
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int IsMsg { get; set; }
        /// <summary>
        /// 是否推荐
        /// </summary>
		public virtual int IsRed { get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
		public virtual int IsLock { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
		public virtual DateTime AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 