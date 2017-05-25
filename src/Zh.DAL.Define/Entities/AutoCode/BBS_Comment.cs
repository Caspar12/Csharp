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
	#region BBS_Comment

	/// <summary>
    /// 评论内容表
	/// BBS_Comment object for mapped table 'BBS_Comment'.
	/// </summary>
	public partial class BBS_Comment
	{
		
		#region Constructors
        
		public BBS_Comment() { }        
        
		public BBS_Comment( Guid iD, int identity, string comment, Guid memberId, Guid commentTypeId, Guid commentObjectId, DateTime createdDate, Guid? commentParentID )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Comment = comment;
			this.MemberId = memberId;
			this.CommentTypeId = commentTypeId;
			this.CommentObjectId = commentObjectId;
			this.CreatedDate = createdDate;
			this.CommentParentID = commentParentID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
		public virtual string Comment { get; set; }
        /// <summary>
        /// 会员Id
        /// </summary>
		public virtual Guid MemberId { get; set; }
        /// <summary>
        /// 评论类开型Id
        /// </summary>
		public virtual Guid CommentTypeId { get; set; }
        /// <summary>
        /// 评论对象Id
        /// </summary>
		public virtual Guid CommentObjectId { get; set; }
        /// <summary>
        /// 评论时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? CommentParentID { get; set; }
        
        /// <summary>
        /// 评论类型表
        /// </summary>            
        public virtual BBS_CommentType BBS_CommentType{get;set;}
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual Member_Account Member_Account{get;set;}
        
        /// <summary>
        /// 评论汇总表
        /// </summary>
        public virtual BBS_CommentExtInfo BBS_CommentExtInfo{get;set;}
        /// <summary>
        /// 评论支持记录表
        /// </summary>
        public virtual IList<BBS_CommentSupportRecord> BBS_CommentSupportRecord{get;set;}


		#endregion
	 
	}
	#endregion
}
 