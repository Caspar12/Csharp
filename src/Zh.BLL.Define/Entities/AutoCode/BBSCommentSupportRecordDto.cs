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
	#region BBSCommentSupportRecordDto

	/// <summary>
    /// 评论支持记录表
	/// BBSCommentSupportRecordDto data view model for mapped table 'BBS_CommentSupportRecord'.
	/// </summary>
	public partial class BBSCommentSupportRecordDto
	{
		
		#region Constructors
        
		public BBSCommentSupportRecordDto() { }        
        
	 
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
        public virtual BBSCommentDto BBSCommentDto{get;set;}
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual MemberAccountDto MemberAccountDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 