﻿/*
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
	#region tareaDto

	/// <summary>
    /// 
	/// tareaDto data view model for mapped table 't_area'.
	/// </summary>
	public partial class tareaDto
	{
		
		#region Constructors
        
		public tareaDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int? id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? areaID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string area { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? fatherID { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 