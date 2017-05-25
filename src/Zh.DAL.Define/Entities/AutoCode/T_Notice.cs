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
	#region T_Notice

	/// <summary>
    /// 
	/// T_Notice object for mapped table 'T_Notice'.
	/// </summary>
	public partial class T_Notice
	{
		
		#region Constructors
        
		public T_Notice() { }        
        
		public T_Notice( int id, string title, DateTime addTime, string author, string notice, int? isTop )
		{
			this.id = id;
			this.title = title;
			this.addTime = addTime;
			this.author = author;
			this.notice = notice;
			this.isTop = isTop;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 主键
        /// </summary>
		public virtual int id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
		public virtual string title { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
		public virtual DateTime addTime { get; set; }
        /// <summary>
        /// 发布人
        /// </summary>
		public virtual string author { get; set; }
        /// <summary>
        /// 公告内容
        /// </summary>
		public virtual string notice { get; set; }
        /// <summary>
        /// 是否置顶
        /// </summary>
		public virtual int? isTop { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<T_NoticeReciver> T_NoticeReciver{get;set;}


		#endregion
	 
	}
	#endregion
}
 