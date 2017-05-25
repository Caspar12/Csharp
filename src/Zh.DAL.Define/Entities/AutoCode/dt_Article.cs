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
	#region dt_Article

	/// <summary>
    /// 
	/// dt_Article object for mapped table 'dt_Article'.
	/// </summary>
	public partial class dt_Article
	{
		
		#region Constructors
        
		public dt_Article() { }        
        
		public dt_Article( int id, int classId, string title, string author, string form, string keyword, string zhaiyao, string daodu, string imgUrl, string content, int click, int isMsg, int isTop, int isRed, int isHot, int isSlide, int isLock, DateTime addTime, byte[] stamp )
		{
			this.Id = id;
			this.ClassId = classId;
			this.Title = title;
			this.Author = author;
			this.Form = form;
			this.Keyword = keyword;
			this.Zhaiyao = zhaiyao;
			this.Daodu = daodu;
			this.ImgUrl = imgUrl;
			this.Content = content;
			this.Click = click;
			this.IsMsg = isMsg;
			this.IsTop = isTop;
			this.IsRed = isRed;
			this.IsHot = isHot;
			this.IsSlide = isSlide;
			this.IsLock = isLock;
			this.AddTime = addTime;
			this.Stamp = stamp;
		}
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
 