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
	#region t_area

	/// <summary>
    /// 
	/// t_area object for mapped table 't_area'.
	/// </summary>
	public partial class t_area
	{
		
		#region Constructors
        
		public t_area() { }        
        
		public t_area( int? id, int? areaID, string area, int? fatherID )
		{
			this.id = id;
			this.areaID = areaID;
			this.area = area;
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
		public virtual int? areaID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string area { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int? fatherID { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 