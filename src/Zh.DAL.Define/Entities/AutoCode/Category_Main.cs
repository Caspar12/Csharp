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
	#region Category_Main

	/// <summary>
    /// 分类表
	/// Category_Main object for mapped table 'Category_Main'.
	/// </summary>
	public partial class Category_Main
	{
		
		#region Constructors
        
		public Category_Main() { }        
        
		public Category_Main( Guid iD, int identity, string name, int sort, bool isShowInFront, int xType )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Sort = sort;
			this.IsShowInFront = isShowInFront;
			this.XType = xType;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual bool IsShowInFront { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int XType { get; set; }
        
        
        /// <summary>
        /// 活动表
        /// </summary>
        public virtual IList<CWX_ExplorationActivity_Main> CWX_ExplorationActivity_Main{get;set;}


		#endregion
	 
	}
	#endregion
}
 