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
	#region dt_SystemLog

	/// <summary>
    /// 
	/// dt_SystemLog object for mapped table 'dt_SystemLog'.
	/// </summary>
	public partial class dt_SystemLog
	{
		
		#region Constructors
        
		public dt_SystemLog() { }        
        
		public dt_SystemLog( int id, string userName, string title, DateTime? addTime, byte[] stamp )
		{
			this.Id = id;
			this.UserName = userName;
			this.Title = title;
			this.AddTime = addTime;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 