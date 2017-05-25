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
	#region dt_PicturesField

	/// <summary>
    /// 
	/// dt_PicturesField object for mapped table 'dt_PicturesField'.
	/// </summary>
	public partial class dt_PicturesField
	{
		
		#region Constructors
        
		public dt_PicturesField() { }        
        
		public dt_PicturesField( int id, string title, string fieldRemark, string fieldType, bool isNull, int sortId, byte[] stamp )
		{
			this.Id = id;
			this.Title = title;
			this.FieldRemark = fieldRemark;
			this.FieldType = fieldType;
			this.IsNull = isNull;
			this.SortId = sortId;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 字段标题
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 字段说明
        /// </summary>
		public virtual string FieldRemark { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
		public virtual string FieldType { get; set; }
        /// <summary>
        /// 是否可以为空
        /// </summary>
		public virtual bool IsNull { get; set; }
        /// <summary>
        /// 排序数字
        /// </summary>
		public virtual int SortId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<dt_PicturesExtension> dt_PicturesExtension{get;set;}


		#endregion
	 
	}
	#endregion
}
 