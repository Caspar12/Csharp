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
	#region TEmployeeDto

	/// <summary>
    /// 
	/// TEmployeeDto data view model for mapped table 'T_Employee'.
	/// </summary>
	public partial class TEmployeeDto
	{
		
		#region Constructors
        
		public TEmployeeDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 员工表ID
        /// </summary>
		public virtual int EmployeeID { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
		public virtual string EmployeeName { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
		public virtual string EmployeePost { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<TActivityGuestItemDto> TActivityGuestItemDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 