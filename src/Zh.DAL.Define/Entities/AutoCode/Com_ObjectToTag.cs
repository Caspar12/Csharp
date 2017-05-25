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
	#region Com_ObjectToTag

	/// <summary>
    /// 对象关联标签表
	/// Com_ObjectToTag object for mapped table 'Com_ObjectToTag'.
	/// </summary>
	public partial class Com_ObjectToTag
	{
		
		#region Constructors
        
		public Com_ObjectToTag() { }        
        
		public Com_ObjectToTag( Guid iD, int identity, Guid? objectGuid, Guid tagId, int? objectIntId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.ObjectGuid = objectGuid;
			this.TagId = tagId;
			this.ObjectIntId = objectIntId;
		}
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
        public virtual Com_Tag Com_Tag{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 