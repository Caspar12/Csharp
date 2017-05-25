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
	#region Maint_MaintItem

	/// <summary>
    /// 
	/// Maint_MaintItem object for mapped table 'Maint_MaintItem'.
	/// </summary>
	public partial class Maint_MaintItem
	{
		
		#region Constructors
        
		public Maint_MaintItem() { }        
        
		public Maint_MaintItem( Guid iD, int identity, string name, decimal price, int sort, Guid maintId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Price = price;
			this.Sort = sort;
			this.MaintId = maintId;
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
        public virtual Maint_Main Maint_Main{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 