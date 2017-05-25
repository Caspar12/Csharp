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
	#region TNoticeDto

	/// <summary>
    /// 
	/// TNoticeDto data view model for mapped table 'T_Notice'.
	/// </summary>
	public partial class TNoticeDto
	{
		
		#region Constructors
        
		public TNoticeDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 主键
        /// </summary>
		public virtual int id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
		public virtual string title { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
		public virtual DateTime addTime { get; set; }
        /// <summary>
        /// 发布人
        /// </summary>
		public virtual string author { get; set; }
        /// <summary>
        /// 公告内容
        /// </summary>
		public virtual string notice { get; set; }
        /// <summary>
        /// 是否置顶
        /// </summary>
		public virtual int? isTop { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TNoticeReciverDto> TNoticeReciverDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 