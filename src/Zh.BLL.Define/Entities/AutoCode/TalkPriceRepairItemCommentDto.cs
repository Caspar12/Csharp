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
	#region TalkPriceRepairItemCommentDto

	/// <summary>
    ///  
	/// TalkPriceRepairItemCommentDto data view model for mapped table 'TalkPrice_RepairItemComment'.
	/// </summary>
	public partial class TalkPriceRepairItemCommentDto
	{
		
		#region Constructors
        
		public TalkPriceRepairItemCommentDto() { }        
        
	 
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
        public virtual TalkPriceRepairItemDto TalkPriceRepairItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 