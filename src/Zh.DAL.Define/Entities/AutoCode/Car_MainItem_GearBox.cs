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
	#region Car_MainItem_GearBox

	/// <summary>
    /// 车辆变速箱参数
	/// Car_MainItem_GearBox object for mapped table 'Car_MainItem_GearBox'.
	/// </summary>
	public partial class Car_MainItem_GearBox
	{
		
		#region Constructors
        
		public Car_MainItem_GearBox() { }        
        
		public Car_MainItem_GearBox( Guid iD, string name, string levelCount, string type )
		{
			this.ID = iD;
			this.Name = name;
			this.LevelCount = levelCount;
			this.Type = type;
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
        /// 挡位个数
        /// </summary>
		public virtual string LevelCount { get; set; }
        /// <summary>
        /// 变速箱类型
        /// </summary>
		public virtual string Type { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 