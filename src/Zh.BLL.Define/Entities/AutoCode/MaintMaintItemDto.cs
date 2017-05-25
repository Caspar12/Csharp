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
	#region MaintMaintItemDto

	/// <summary>
    /// 
	/// MaintMaintItemDto data view model for mapped table 'Maint_MaintItem'.
	/// </summary>
	public partial class MaintMaintItemDto
	{
		
		#region Constructors
        
		public MaintMaintItemDto() { }        
        
	 
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
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid MaintId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual MaintMainDto MaintMainDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 