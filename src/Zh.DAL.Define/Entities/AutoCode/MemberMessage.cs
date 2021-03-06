﻿/*
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
	#region MemberMessage

	/// <summary>
    /// 
	/// MemberMessage object for mapped table 'MemberMessage'.
	/// </summary>
	public partial class MemberMessage
	{
		
		#region Constructors
        
		public MemberMessage() { }        
        
		public MemberMessage( Guid iD, string title, string contentText, DateTime sendDate )
		{
			this.ID = iD;
			this.Title = title;
			this.ContentText = contentText;
			this.SendDate = sendDate;
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
		public virtual string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string ContentText { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime SendDate { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<MemberMessageReciver> MemberMessageReciver{get;set;}


		#endregion
	 
	}
	#endregion
}
 