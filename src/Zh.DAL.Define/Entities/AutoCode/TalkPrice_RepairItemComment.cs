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
	#region TalkPrice_RepairItemComment

	/// <summary>
    ///  
	/// TalkPrice_RepairItemComment object for mapped table 'TalkPrice_RepairItemComment'.
	/// </summary>
	public partial class TalkPrice_RepairItemComment
	{
		
		#region Constructors
        
		public TalkPrice_RepairItemComment() { }        
        
		public TalkPrice_RepairItemComment( Guid iD, int identity, string name, string description, DateTime createdDate, Guid repairItemId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.Description = description;
			this.CreatedDate = createdDate;
			this.RepairItemId = repairItemId;
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
		public virtual Guid RepairItemId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual TalkPrice_RepairItem TalkPrice_RepairItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 