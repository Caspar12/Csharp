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
	#region tarea2Dto

	/// <summary>
    /// 
	/// tarea2Dto data view model for mapped table 't_area2'.
	/// </summary>
	public partial class tarea2Dto
	{
		
		#region Constructors
        
		public tarea2Dto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int? areaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string area { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? provinceid { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? fatherid { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 