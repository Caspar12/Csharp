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
	#region BBS_CommentSupportRecord

	/// <summary>
    /// 评论支持记录表
	/// BBS_CommentSupportRecord object for mapped table 'BBS_CommentSupportRecord'.
	/// </summary>
	public partial class BBS_CommentSupportRecord
	{
		
		#region Constructors
        
		public BBS_CommentSupportRecord() { }        
        
		public BBS_CommentSupportRecord( Guid iD, Guid? memberId, DateTime createdDate, Guid commentId )
		{
			this.ID = iD;
			this.MemberId = memberId;
			this.CreatedDate = createdDate;
			this.CommentId = commentId;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 会员Id
        /// </summary>
		public virtual Guid? MemberId { get; set; }
        /// <summary>
        /// 评论时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 评论Id
        /// </summary>
		public virtual Guid CommentId { get; set; }
        
        /// <summary>
        /// 评论内容表
        /// </summary>            
        public virtual BBS_Comment BBS_Comment{get;set;}
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual Member_Account Member_Account{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 