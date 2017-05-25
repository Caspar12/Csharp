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
	#region dt_Channel

	/// <summary>
    /// 
	/// dt_Channel object for mapped table 'dt_Channel'.
	/// </summary>
	public partial class dt_Channel
	{
		
		#region Constructors
        
		public dt_Channel() { }        
        
		public dt_Channel( int id, string title, int parentId, string classList, int classLayer, int sortId, string pageUrl, int kindId, byte[] stamp )
		{
			this.Id = id;
			this.Title = title;
			this.ParentId = parentId;
			this.ClassList = classList;
			this.ClassLayer = classLayer;
			this.SortId = sortId;
			this.PageUrl = pageUrl;
			this.KindId = kindId;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 栏目名称
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 父栏目ID
        /// </summary>
		public virtual int ParentId { get; set; }
        /// <summary>
        /// 子栏目ID列表
        /// </summary>
		public virtual string ClassList { get; set; }
        /// <summary>
        /// 栏目深度
        /// </summary>
		public virtual int ClassLayer { get; set; }
        /// <summary>
        /// 排序数字
        /// </summary>
		public virtual int SortId { get; set; }
        /// <summary>
        /// 栏目管理地址
        /// </summary>
		public virtual string PageUrl { get; set; }
        /// <summary>
        /// 栏目自定义数字
        /// </summary>
		public virtual int KindId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 