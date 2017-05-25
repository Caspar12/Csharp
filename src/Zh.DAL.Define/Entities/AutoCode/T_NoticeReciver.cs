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
	#region T_NoticeReciver

	/// <summary>
    /// 
	/// T_NoticeReciver object for mapped table 'T_NoticeReciver'.
	/// </summary>
	public partial class T_NoticeReciver
	{
		
		#region Constructors
        
		public T_NoticeReciver() { }        
        
		public T_NoticeReciver( Guid iD, int noticeID, Guid webSiteID )
		{
			this.ID = iD;
			this.NoticeID = noticeID;
			this.WebSiteID = webSiteID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int NoticeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid WebSiteID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual T_Notice T_Notice{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual WebSite WebSite{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 