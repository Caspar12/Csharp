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
	#region dtPicturesExtensionDto

	/// <summary>
    /// 
	/// dtPicturesExtensionDto data view model for mapped table 'dt_PicturesExtension'.
	/// </summary>
	public partial class dtPicturesExtensionDto
	{
		
		#region Constructors
        
		public dtPicturesExtensionDto() { }        
        
	 
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
        public virtual dtPicturesDto dtPicturesDto{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual dtPicturesFieldDto dtPicturesFieldDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 