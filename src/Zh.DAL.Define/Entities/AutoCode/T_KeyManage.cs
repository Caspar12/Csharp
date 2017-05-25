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
	#region T_KeyManage

	/// <summary>
    /// 
	/// T_KeyManage object for mapped table 'T_KeyManage'.
	/// </summary>
	public partial class T_KeyManage
	{
		
		#region Constructors
        
		public T_KeyManage() { }        
        
		public T_KeyManage( int keyManageIndex, int? positionID, string imgUrl, string weibo, string link, byte[] stamp, int isTop )
		{
			this.KeyManageIndex = keyManageIndex;
			this.PositionID = positionID;
			this.ImgUrl = imgUrl;
			this.Weibo = weibo;
			this.Link = link;
			this.Stamp = stamp;
			this.IsTop = isTop;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 重点管理表
        /// </summary>
		public virtual int KeyManageIndex { get; set; }
        /// <summary>
        /// 位置ID
        /// </summary>
		public virtual int? PositionID { get; set; }
        /// <summary>
        /// 图片url
        /// </summary>
		public virtual string ImgUrl { get; set; }
        /// <summary>
        /// 微博
        /// </summary>
		public virtual string Weibo { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
		public virtual string Link { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        /// <summary>
        /// 是否允许首页显示,0不允许1允许
        /// </summary>
		public virtual int IsTop { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 