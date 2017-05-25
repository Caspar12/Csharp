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
	#region dtAllReviewsDto

	/// <summary>
    /// 
	/// dtAllReviewsDto data view model for mapped table 'dt_AllReviews'.
	/// </summary>
	public partial class dtAllReviewsDto
	{
		
		#region Constructors
        
		public dtAllReviewsDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 所属评论频道栏目
        /// </summary>
		public virtual int KindId { get; set; }
        /// <summary>
        /// 所属评论信息ID
        /// </summary>
		public virtual int ParentId { get; set; }
        /// <summary>
        /// 评论用户
        /// </summary>
		public virtual string UserName { get; set; }
        /// <summary>
        /// 星级
        /// </summary>
		public virtual int? Grade { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
		public virtual int? IsLock { get; set; }
        /// <summary>
        /// 评论时间
        /// </summary>
		public virtual DateTime AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 