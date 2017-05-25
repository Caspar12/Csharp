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
	#region ComTagDto

	/// <summary>
    /// 标签表
	/// ComTagDto data view model for mapped table 'Com_Tag'.
	/// </summary>
	public partial class ComTagDto
	{
		
		#region Constructors
        
		public ComTagDto() { }        
        
	 
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
        /// 名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// ParentId
        /// </summary>
		public virtual Guid? ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Key { get; set; }
        
        /// <summary>
        /// 标签表
        /// </summary>            
        public virtual ComTagDto ComTagDto2{get;set;}
        
        /// <summary>
        /// 对象关联标签表
        /// </summary>
        public virtual IList<ComObjectToTagDto> ComObjectToTagDto{get;set;}
        /// <summary>
        /// 标签表
        /// </summary>
        public virtual IList<ComTagDto> ComTagDto3{get;set;}


		#endregion
	 
	}
	#endregion
}
 