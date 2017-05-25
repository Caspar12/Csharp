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
	#region t_province

	/// <summary>
    /// 
	/// t_province object for mapped table 't_province'.
	/// </summary>
	public partial class t_province
	{
		
		#region Constructors
        
		public t_province() { }        
        
		public t_province( int id, int provinceID, string province )
		{
			this.id = id;
			this.provinceID = provinceID;
			this.province = province;
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
		public virtual int provinceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string province { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 