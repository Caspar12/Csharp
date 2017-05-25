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
	#region T_AdditionService

	/// <summary>
    /// 
	/// T_AdditionService object for mapped table 'T_AdditionService'.
	/// </summary>
	public partial class T_AdditionService
	{
		
		#region Constructors
        
		public T_AdditionService() { }        
        
		public T_AdditionService( int serviceIndex, int? positionID, int? typeID, string logoUrl, string contentUrl, string link, string weibo, string qQ, byte[] stamp )
		{
			this.ServiceIndex = serviceIndex;
			this.PositionID = positionID;
			this.TypeID = typeID;
			this.LogoUrl = logoUrl;
			this.ContentUrl = contentUrl;
			this.Link = link;
			this.Weibo = weibo;
			this.QQ = qQ;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 附加业务表
        /// </summary>
		public virtual int ServiceIndex { get; set; }
        /// <summary>
        /// 位置ID
        /// </summary>
		public virtual int? PositionID { get; set; }
        /// <summary>
        /// 类别ID
        /// </summary>
		public virtual int? TypeID { get; set; }
        /// <summary>
        /// LOGO图片
        /// </summary>
		public virtual string LogoUrl { get; set; }
        /// <summary>
        /// 内容图片
        /// </summary>
		public virtual string ContentUrl { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
		public virtual string Link { get; set; }
        /// <summary>
        /// 新浪微博
        /// </summary>
		public virtual string Weibo { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
		public virtual string QQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 