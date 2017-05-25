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
	#region CarMainCommentDto

	/// <summary>
    /// 车辆评论表
	/// CarMainCommentDto data view model for mapped table 'Car_Main_Comment'.
	/// </summary>
	public partial class CarMainCommentDto
	{
		
		#region Constructors
        
		public CarMainCommentDto() { }        
        
	 
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
		public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string IPAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid CarMainId { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual CarMainDto CarMainDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 