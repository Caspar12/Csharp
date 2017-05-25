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
	#region T_Employee

	/// <summary>
    /// 
	/// T_Employee object for mapped table 'T_Employee'.
	/// </summary>
	public partial class T_Employee
	{
		
		#region Constructors
        
		public T_Employee() { }        
        
		public T_Employee( int employeeID, string employeeName, string employeePost, byte[] stamp )
		{
			this.EmployeeID = employeeID;
			this.EmployeeName = employeeName;
			this.EmployeePost = employeePost;
			this.Stamp = stamp;
		}
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
        public virtual IList<T_ActivityGuestItem> T_ActivityGuestItem{get;set;}


		#endregion
	 
	}
	#endregion
}
 