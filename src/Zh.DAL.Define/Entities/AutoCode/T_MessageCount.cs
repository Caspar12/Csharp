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
	#region T_MessageCount

	/// <summary>
    /// 
	/// T_MessageCount object for mapped table 'T_MessageCount'.
	/// </summary>
	public partial class T_MessageCount
	{
		
		#region Constructors
        
		public T_MessageCount() { }        
        
		public T_MessageCount( int id, string shopid, int? sumcount )
		{
			this.id = id;
			this.shopid = shopid;
			this.sumcount = sumcount;
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
		public virtual string shopid { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? sumcount { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 