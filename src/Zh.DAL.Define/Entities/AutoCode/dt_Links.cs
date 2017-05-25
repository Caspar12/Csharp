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
	#region dt_Links

	/// <summary>
    /// 
	/// dt_Links object for mapped table 'dt_Links'.
	/// </summary>
	public partial class dt_Links
	{
		
		#region Constructors
        
		public dt_Links() { }        
        
		public dt_Links( int id, string title, string userName, string userTel, string userMail, string webUrl, string imgUrl, int isImage, int sortId, int isRed, int isLock, DateTime addTime, string classIdList, byte[] stamp )
		{
			this.Id = id;
			this.Title = title;
			this.UserName = userName;
			this.UserTel = userTel;
			this.UserMail = userMail;
			this.WebUrl = webUrl;
			this.ImgUrl = imgUrl;
			this.IsImage = isImage;
			this.SortId = sortId;
			this.IsRed = isRed;
			this.IsLock = isLock;
			this.AddTime = addTime;
			this.ClassIdList = classIdList;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 网站标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
		public virtual string UserName { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
		public virtual string UserTel { get; set; }
        /// <summary>
        /// 联系邮箱
        /// </summary>
		public virtual string UserMail { get; set; }
        /// <summary>
        /// 网址
        /// </summary>
		public virtual string WebUrl { get; set; }
        /// <summary>
        /// LOGO网址
        /// </summary>
		public virtual string ImgUrl { get; set; }
        /// <summary>
        /// 是否图片链接
        /// </summary>
		public virtual int IsImage { get; set; }
        /// <summary>
        /// 排序数字，越小越向前
        /// </summary>
		public virtual int SortId { get; set; }
        /// <summary>
        /// 是否推荐到首页
        /// </summary>
		public virtual int IsRed { get; set; }
        /// <summary>
        /// 是否锁定，0正常1锁定
        /// </summary>
		public virtual int IsLock { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
		public virtual DateTime AddTime { get; set; }
        /// <summary>
        /// 分类ID列表,用‘，’分割
        /// </summary>
		public virtual string ClassIdList { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 