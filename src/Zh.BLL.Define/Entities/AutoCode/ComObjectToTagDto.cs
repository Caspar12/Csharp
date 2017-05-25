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
	#region ComObjectToTagDto

	/// <summary>
    /// 对象关联标签表
	/// ComObjectToTagDto data view model for mapped table 'Com_ObjectToTag'.
	/// </summary>
	public partial class ComObjectToTagDto
	{
		
		#region Constructors
        
		public ComObjectToTagDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid? ObjectGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid TagId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? ObjectIntId { get; set; }
        
        /// <summary>
        /// 标签表
        /// </summary>            
        public virtual ComTagDto ComTagDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 