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
	#region dt_PicturesExtension

	/// <summary>
    /// 
	/// dt_PicturesExtension object for mapped table 'dt_PicturesExtension'.
	/// </summary>
	public partial class dt_PicturesExtension
	{
		
		#region Constructors
        
		public dt_PicturesExtension() { }        
        
		public dt_PicturesExtension( int id, int pictureId, int fieldId, string fieldName, string content, byte[] stamp )
		{
			this.Id = id;
			this.PictureId = pictureId;
			this.FieldId = fieldId;
			this.FieldName = fieldName;
			this.Content = content;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 所属图文ID
        /// </summary>
		public virtual int PictureId { get; set; }
        /// <summary>
        /// 扩展字段ID
        /// </summary>
		public virtual int FieldId { get; set; }
        /// <summary>
        /// 字段标题
        /// </summary>
		public virtual string FieldName { get; set; }
        /// <summary>
        /// 填写内容
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual dt_Pictures dt_Pictures{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual dt_PicturesField dt_PicturesField{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 