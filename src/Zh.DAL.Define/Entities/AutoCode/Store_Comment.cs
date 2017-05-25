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
	#region Store_Comment

	/// <summary>
    ///  
	/// Store_Comment object for mapped table 'Store_Comment'.
	/// </summary>
	public partial class Store_Comment
	{
		
		#region Constructors
        
		public Store_Comment() { }        
        
		public Store_Comment( Guid iD, int identity, string name, string description, DateTime createdDate, Guid storeId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Description = description;
			this.CreatedDate = createdDate;
			this.StoreId = storeId;
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
		public virtual string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid StoreId { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 