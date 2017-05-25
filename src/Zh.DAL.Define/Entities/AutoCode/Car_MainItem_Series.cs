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
	#region Car_MainItem_Series

	/// <summary>
    /// 车型系统表
	/// Car_MainItem_Series object for mapped table 'Car_MainItem_Series'.
	/// </summary>
	public partial class Car_MainItem_Series
	{
		
		#region Constructors
        
		public Car_MainItem_Series() { }        
        
		public Car_MainItem_Series( int identity, Guid iD, string name )
		{
			this.Identity = identity;
			this.ID = iD;
			this.Name = name;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 车型系列名称
        /// </summary>
		public virtual string Name { get; set; }
        
        
        /// <summary>
        /// 指定车辆表
        /// </summary>
        public virtual IList<Car_MainItem> Car_MainItem{get;set;}


		#endregion
	 
	}
	#endregion
}
 