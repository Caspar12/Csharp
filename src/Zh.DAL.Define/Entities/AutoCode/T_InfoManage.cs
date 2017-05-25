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
	#region T_InfoManage

	/// <summary>
    /// 
	/// T_InfoManage object for mapped table 'T_InfoManage'.
	/// </summary>
	public partial class T_InfoManage
	{
		
		#region Constructors
        
		public T_InfoManage() { }        
        
		public T_InfoManage( int infoIndex, string imgUrl, string title, string summary, string link, byte[] stamp, int? positionID, int? isShow )
		{
			this.InfoIndex = infoIndex;
			this.ImgUrl = imgUrl;
			this.Title = title;
			this.Summary = summary;
			this.Link = link;
			this.Stamp = stamp;
			this.PositionID = positionID;
			this.IsShow = isShow;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 资讯管理表
        /// </summary>
		public virtual int InfoIndex { get; set; }
        /// <summary>
        /// 图片Url
        /// </summary>
		public virtual string ImgUrl { get; set; }
        /// <summary>
        /// 资讯标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 资讯摘要
        /// </summary>
		public virtual string Summary { get; set; }
        /// <summary>
        /// 资讯链接
        /// </summary>
		public virtual string Link { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        /// <summary>
        /// 位置ID
        /// </summary>
		public virtual int? PositionID { get; set; }
        /// <summary>
        /// 是否在首页显示。0=不显示，1=显示
        /// </summary>
		public virtual int? IsShow { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 