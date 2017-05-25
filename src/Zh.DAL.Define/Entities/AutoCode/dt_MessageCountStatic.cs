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
	#region dt_MessageCountStatic

	/// <summary>
    /// 
	/// dt_MessageCountStatic object for mapped table 'dt_MessageCountStatic'.
	/// </summary>
	public partial class dt_MessageCountStatic
	{
		
		#region Constructors
        
		public dt_MessageCountStatic() { }        
        
		public dt_MessageCountStatic( int id, string shopid, int messagecount, int sumcount, DateTime opdate, decimal pay_amout )
		{
			this.id = id;
			this.shopid = shopid;
			this.messagecount = messagecount;
			this.sumcount = sumcount;
			this.opdate = opdate;
			this.pay_amout = pay_amout;
		}
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
 