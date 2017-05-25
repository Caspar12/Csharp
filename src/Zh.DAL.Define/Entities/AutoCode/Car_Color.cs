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
	#region Car_Color

	/// <summary>
    /// 车辆颜色
	/// Car_Color object for mapped table 'Car_Color'.
	/// </summary>
	public partial class Car_Color
	{
		
		#region Constructors
        
		public Car_Color() { }        
        
		public Car_Color( Guid iD, string name, string rGB )
		{
			this.ID = iD;
			this.Name = name;
			this.RGB = rGB;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 颜色RGB值
        /// </summary>
		public virtual string RGB { get; set; }
        
        
        /// <summary>
        /// 车辆外观颜色关系表
        /// </summary>
        public virtual IList<Car_MainItemToExColor> Car_MainItemToExColor{get;set;}
        /// <summary>
        /// 车辆内观颜色关系表
        /// </summary>
        public virtual IList<Car_MainItemToInColor> Car_MainItemToInColor{get;set;}


		#endregion
	 
	}
	#endregion
}
 