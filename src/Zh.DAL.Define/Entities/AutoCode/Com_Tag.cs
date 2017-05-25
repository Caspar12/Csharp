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
	#region Com_Tag

	/// <summary>
    /// 标签表
	/// Com_Tag object for mapped table 'Com_Tag'.
	/// </summary>
	public partial class Com_Tag
	{
		
		#region Constructors
        
		public Com_Tag() { }        
        
		public Com_Tag( Guid iD, int identity, string name, Guid? parentId, string key )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.ParentId = parentId;
			this.Key = key;
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
        public virtual Com_Tag Com_Tag2{get;set;}
        
        /// <summary>
        /// 对象关联标签表
        /// </summary>
        public virtual IList<Com_ObjectToTag> Com_ObjectToTag{get;set;}
        /// <summary>
        /// 标签表
        /// </summary>
        public virtual IList<Com_Tag> Com_Tag3{get;set;}


		#endregion
	 
	}
	#endregion
}
 