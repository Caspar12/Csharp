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
	#region dt_Adbanner

	/// <summary>
    /// 
	/// dt_Adbanner object for mapped table 'dt_Adbanner'.
	/// </summary>
	public partial class dt_Adbanner
	{
		
		#region Constructors
        
		public dt_Adbanner() { }        
        
		public dt_Adbanner( int id, int aid, string title, DateTime startTime, DateTime endTime, string adUrl, string linkUrl, string adRemark, int sortId, int isLock, DateTime addTime, byte[] stamp )
		{
			this.id = id;
			this.Aid = aid;
			this.Title = title;
			this.StartTime = startTime;
			this.EndTime = endTime;
			this.AdUrl = adUrl;
			this.LinkUrl = linkUrl;
			this.AdRemark = adRemark;
			this.SortId = sortId;
			this.IsLock = isLock;
			this.AddTime = addTime;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 自增ID PK
        /// </summary>
		public virtual int id { get; set; }
        /// <summary>
        /// 广告位ID
        /// </summary>
		public virtual int Aid { get; set; }
        /// <summary>
        /// 广告条名称
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
		public virtual DateTime StartTime { get; set; }
        /// <summary>
        /// 到期时间
        /// </summary>
		public virtual DateTime EndTime { get; set; }
        /// <summary>
        /// 广告地址
        /// </summary>
		public virtual string AdUrl { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
		public virtual string LinkUrl { get; set; }
        /// <summary>
        /// 备注说明
        /// </summary>
		public virtual string AdRemark { get; set; }
        /// <summary>
        /// 排序数字，越小越向前
        /// </summary>
		public virtual int SortId { get; set; }
        /// <summary>
        /// 状态，0正常，1暂停
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
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual dt_Advertising dt_Advertising{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 