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
	#region dtMessageCountStaticDto

	/// <summary>
    /// 
	/// dtMessageCountStaticDto data view model for mapped table 'dt_MessageCountStatic'.
	/// </summary>
	public partial class dtMessageCountStaticDto
	{
		
		#region Constructors
        
		public dtMessageCountStaticDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int id { get; set; }
        /// <summary>
        /// 店名
        /// </summary>
		public virtual string shopid { get; set; }
        /// <summary>
        /// 增加条数
        /// </summary>
		public virtual int messagecount { get; set; }
        /// <summary>
        /// 剩余条数
        /// </summary>
		public virtual int sumcount { get; set; }
        /// <summary>
        /// 操作日期
        /// </summary>
		public virtual DateTime opdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual decimal pay_amout { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 