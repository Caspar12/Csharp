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
	#region Car_MainItemToInColor

	/// <summary>
    /// 车辆内观颜色关系表
	/// Car_MainItemToInColor object for mapped table 'Car_MainItemToInColor'.
	/// </summary>
	public partial class Car_MainItemToInColor
	{
		
		#region Constructors
        
		public Car_MainItemToInColor() { }        
        
		public Car_MainItemToInColor( Guid iD, Guid mainItemID, Guid colorID )
		{
			this.ID = iD;
			this.MainItemID = mainItemID;
			this.ColorID = colorID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 车系ID
        /// </summary>
		public virtual Guid MainItemID { get; set; }
        /// <summary>
        /// 颜色ID
        /// </summary>
		public virtual Guid ColorID { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        /// <summary>
        /// 车辆颜色
        /// </summary>            
        public virtual Car_Color Car_Color{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 