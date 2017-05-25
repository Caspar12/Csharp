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
	#region tprovinceDto

	/// <summary>
    /// 
	/// tprovinceDto data view model for mapped table 't_province'.
	/// </summary>
	public partial class tprovinceDto
	{
		
		#region Constructors
        
		public tprovinceDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int provinceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string province { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 