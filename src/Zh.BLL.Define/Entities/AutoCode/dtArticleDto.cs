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
	#region dtArticleDto

	/// <summary>
    /// 
	/// dtArticleDto data view model for mapped table 'dt_Article'.
	/// </summary>
	public partial class dtArticleDto
	{
		
		#region Constructors
        
		public dtArticleDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 所属类别
        /// </summary>
		public virtual int ClassId { get; set; }
        /// <summary>
        /// 文章标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 原文作者
        /// </summary>
		public virtual string Author { get; set; }
        /// <summary>
        /// 文章来源
        /// </summary>
		public virtual string Form { get; set; }
        /// <summary>
        /// 关健字
        /// </summary>
		public virtual string Keyword { get; set; }
        /// <summary>
        /// 文章摘要
        /// </summary>
		public virtual string Zhaiyao { get; set; }
        /// <summary>
        /// 文章导读
        /// </summary>
		public virtual string Daodu { get; set; }
        /// <summary>
        /// 文章图片
        /// </summary>
		public virtual string ImgUrl { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 点击次数
        /// </summary>
		public virtual int Click { get; set; }
        /// <summary>
        /// 是否允许评论,0不允许1允许
        /// </summary>
		public virtual int IsMsg { get; set; }
        /// <summary>
        /// 是否置顶
        /// </summary>
		public virtual int IsTop { get; set; }
        /// <summary>
        /// 是否推荐
        /// </summary>
		public virtual int IsRed { get; set; }
        /// <summary>
        /// 是否热门
        /// </summary>
		public virtual int IsHot { get; set; }
        /// <summary>
        /// 是否幻灯片
        /// </summary>
		public virtual int IsSlide { get; set; }
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
 