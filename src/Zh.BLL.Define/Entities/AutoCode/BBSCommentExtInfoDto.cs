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
	#region BBSCommentExtInfoDto

	/// <summary>
    /// 评论汇总表
	/// BBSCommentExtInfoDto data view model for mapped table 'BBS_CommentExtInfo'.
	/// </summary>
	public partial class BBSCommentExtInfoDto
	{
		
		#region Constructors
        
		public BBSCommentExtInfoDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 回复数
        /// </summary>
		public virtual int ReplyCount { get; set; }
        /// <summary>
        /// 支持数
        /// </summary>
		public virtual int SupportCount { get; set; }
        
        /// <summary>
        /// 评论内容表
        /// </summary>            
        public virtual BBSCommentDto BBSCommentDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 