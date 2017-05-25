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
	#region t_area2

	/// <summary>
    /// 
	/// t_area2 object for mapped table 't_area2'.
	/// </summary>
	public partial class t_area2
	{
		
		#region Constructors
        
		public t_area2() { }        
        
		public t_area2( int? areaid, int? id, string area, int? provinceid, int? fatherid )
		{
			this.areaid = areaid;
			this.id = id;
			this.area = area;
			this.provinceid = provinceid;
			this.fatherid = fatherid;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int? areaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string area { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? provinceid { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? fatherid { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 