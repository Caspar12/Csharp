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
	#region BBS_CommentExtInfo

	/// <summary>
    /// 评论汇总表
	/// BBS_CommentExtInfo object for mapped table 'BBS_CommentExtInfo'.
	/// </summary>
	public partial class BBS_CommentExtInfo
	{
		
		#region Constructors
        
		public BBS_CommentExtInfo() { }        
        
		public BBS_CommentExtInfo( Guid iD, int replyCount, int supportCount )
		{
			this.ID = iD;
			this.ReplyCount = replyCount;
			this.SupportCount = supportCount;
		}
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
        public virtual BBS_Comment BBS_Comment{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 