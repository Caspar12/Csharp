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
	#region t_city

	/// <summary>
    /// 
	/// t_city object for mapped table 't_city'.
	/// </summary>
	public partial class t_city
	{
		
		#region Constructors
        
		public t_city() { }        
        
		public t_city( int? id, int? cityID, string city, int? fatherID )
		{
			this.id = id;
			this.cityID = cityID;
			this.city = city;
			this.fatherID = fatherID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int? id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? cityID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string city { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? fatherID { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 