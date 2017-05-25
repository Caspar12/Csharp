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
	#region dt_Pictures

	/// <summary>
    /// 
	/// dt_Pictures object for mapped table 'dt_Pictures'.
	/// </summary>
	public partial class dt_Pictures
	{
		
		#region Constructors
        
		public dt_Pictures() { }        
        
		public dt_Pictures( int id, string title, int classId, decimal price, string imgUrl, string content, int click, int isMsg, int isTop, int isRed, int isHot, int isSlide, int isLock, int sortId, DateTime addTime, byte[] stamp )
		{
			this.Id = id;
			this.Title = title;
			this.ClassId = classId;
			this.Price = price;
			this.ImgUrl = imgUrl;
			this.Content = content;
			this.Click = click;
			this.IsMsg = isMsg;
			this.IsTop = isTop;
			this.IsRed = isRed;
			this.IsHot = isHot;
			this.IsSlide = isSlide;
			this.IsLock = isLock;
			this.SortId = sortId;
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
        /// 图文标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 所属类别
        /// </summary>
		public virtual int ClassId { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
		public virtual decimal Price { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
		public virtual string ImgUrl { get; set; }
        /// <summary>
        /// 详细介绍
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 点击次数
        /// </summary>
		public virtual int Click { get; set; }
        /// <summary>
        /// 是否允许评论
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
        /// 排序数字
        /// </summary>
		public virtual int SortId { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
		public virtual DateTime AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<dt_PicturesAlbum> dt_PicturesAlbum{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<dt_PicturesExtension> dt_PicturesExtension{get;set;}


		#endregion
	 
	}
	#endregion
}
 