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
	#region T_Needs

	/// <summary>
    /// 
	/// T_Needs object for mapped table 'T_Needs'.
	/// </summary>
	public partial class T_Needs
	{
		
		#region Constructors
        
		public T_Needs() { }        
        
		public T_Needs( int needsIndex, int? feedbackID, string title, string isNeed )
		{
			this.NeedsIndex = needsIndex;
			this.FeedbackID = feedbackID;
			this.Title = title;
			this.IsNeed = isNeed;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 需求表
        /// </summary>
		public virtual int NeedsIndex { get; set; }
        /// <summary>
        /// 留言表ID
        /// </summary>
		public virtual int? FeedbackID { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 是否需要,0不需要,1需要，其他为保存内容
        /// </summary>
		public virtual string IsNeed { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 