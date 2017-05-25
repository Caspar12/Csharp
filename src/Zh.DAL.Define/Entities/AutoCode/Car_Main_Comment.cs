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
	#region Car_Main_Comment

	/// <summary>
    /// 车辆评论表
	/// Car_Main_Comment object for mapped table 'Car_Main_Comment'.
	/// </summary>
	public partial class Car_Main_Comment
	{
		
		#region Constructors
        
		public Car_Main_Comment() { }        
        
		public Car_Main_Comment( Guid iD, int identity, string content, DateTime createdDate, string iPAddress, Guid carMainId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Content = content;
			this.CreatedDate = createdDate;
			this.IPAddress = iPAddress;
			this.CarMainId = carMainId;
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
        public virtual Car_Main Car_Main{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 