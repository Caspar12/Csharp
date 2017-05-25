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
	#region T_SMSList

	/// <summary>
    /// 
	/// T_SMSList object for mapped table 'T_SMSList'.
	/// </summary>
	public partial class T_SMSList
	{
		
		#region Constructors
        
		public T_SMSList() { }        
        
		public T_SMSList( int id, string phonenumber, string remark )
		{
			this.id = id;
			this.phonenumber = phonenumber;
			this.remark = remark;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string phonenumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string remark { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 