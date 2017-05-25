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
	#region Car_ExternalConfig

	/// <summary>
    /// 外部配置
	/// Car_ExternalConfig object for mapped table 'Car_ExternalConfig'.
	/// </summary>
	public partial class Car_ExternalConfig
	{
		
		#region Constructors
        
		public Car_ExternalConfig() { }        
        
		public Car_ExternalConfig( Guid iD, bool? powerSunroof, bool? panoramicSunroof, bool? sportAppearancePackag, bool? aluminumAlloyWheels, bool? electricSuctionDoor, string slidingDoor, bool? electricTrunk )
		{
			this.ID = iD;
			this.PowerSunroof = powerSunroof;
			this.PanoramicSunroof = panoramicSunroof;
			this.SportAppearancePackag = sportAppearancePackag;
			this.AluminumAlloyWheels = aluminumAlloyWheels;
			this.ElectricSuctionDoor = electricSuctionDoor;
			this.SlidingDoor = slidingDoor;
			this.ElectricTrunk = electricTrunk;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 电动天窗
        /// </summary>
		public virtual bool? PowerSunroof { get; set; }
        /// <summary>
        /// 全景天窗
        /// </summary>
		public virtual bool? PanoramicSunroof { get; set; }
        /// <summary>
        /// 运动外观套件
        /// </summary>
		public virtual bool? SportAppearancePackag { get; set; }
        /// <summary>
        /// 铝金轮圈
        /// </summary>
		public virtual bool? AluminumAlloyWheels { get; set; }
        /// <summary>
        /// 电动吸合门
        /// </summary>
		public virtual bool? ElectricSuctionDoor { get; set; }
        /// <summary>
        /// 侧滑门
        /// </summary>
		public virtual string SlidingDoor { get; set; }
        /// <summary>
        /// 电动后备厢
        /// </summary>
		public virtual bool? ElectricTrunk { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 