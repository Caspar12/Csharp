/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据契约实体模型文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
using System.Collections.Generic;
namespace Zh.BLL.Define.Entities
{
	#region BBSCommentDto

	/// <summary>
    /// 评论内容表
	/// BBSCommentDto data view model for mapped table 'BBS_Comment'.
	/// </summary>
	public partial class BBSCommentDto
	{
		
		#region Constructors
        
		public BBSCommentDto() { }        
        
	 
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
        public virtual BBSCommentTypeDto BBSCommentTypeDto{get;set;}
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual MemberAccountDto MemberAccountDto{get;set;}
        
        /// <summary>
        /// 评论汇总表
        /// </summary>
        public virtual BBSCommentExtInfoDto BBSCommentExtInfoDto{get;set;}
        /// <summary>
        /// 评论支持记录表
        /// </summary>
        public virtual IList<BBSCommentSupportRecordDto> BBSCommentSupportRecordDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 