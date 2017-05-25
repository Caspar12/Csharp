/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据契约实体模型文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
using System.Collections.Generic;
namespace Zh.BLL.Define.Entities
{
	#region CarSecurityEquipDto

	/// <summary>
    /// 车辆安全装备
	/// CarSecurityEquipDto data view model for mapped table 'Car_SecurityEquip'.
	/// </summary>
	public partial class CarSecurityEquipDto
	{
		
		#region Constructors
        
		public CarSecurityEquipDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 主驾驶座安全气囊
        /// </summary>
		public virtual bool? HasMainAirBag { get; set; }
        /// <summary>
        /// 辅驾驶座安全气囊
        /// </summary>
		public virtual bool? HasSubsidiaryAirBag { get; set; }
        /// <summary>
        /// 前排侧安全气囊
        /// </summary>
		public virtual bool? HasFrontSideAirBag { get; set; }
        /// <summary>
        /// 后排侧安全气囊
        /// </summary>
		public virtual bool? HasBackSideAirBag { get; set; }
        /// <summary>
        /// 前排头部安全气囊
        /// </summary>
		public virtual bool? HasFrontHeadAirBag { get; set; }
        /// <summary>
        /// 后排头部安全气囊
        /// </summary>
		public virtual bool? HasBackHeadAirBag { get; set; }
        /// <summary>
        /// 膝部气囊
        /// </summary>
		public virtual bool? HasKneeAirBag { get; set; }
        /// <summary>
        /// 胎压监测装置
        /// </summary>
		public virtual bool? HasTireMonitorDevice { get; set; }
        /// <summary>
        /// 零胎压继续行驶
        /// </summary>
		public virtual bool? HasZeroTirePressureGoing { get; set; }
        /// <summary>
        /// 安全带未系提示
        /// </summary>
		public virtual bool? HasUnlinkLifeBeltTips { get; set; }
        /// <summary>
        /// ISOFIX儿童座椅接口
        /// </summary>
		public virtual bool? HasISOFIXChildSeatInterface { get; set; }
        /// <summary>
        /// 发动机电子防盗
        /// </summary>
		public virtual bool? HasEngineAntiTheftSystem { get; set; }
        /// <summary>
        /// 车内中控锁
        /// </summary>
		public virtual bool? HasInCarControlLock { get; set; }
        /// <summary>
        /// 遥控钥匙
        /// </summary>
		public virtual bool? HasRemoteKey { get; set; }
        /// <summary>
        /// 无钥匙启动系统
        /// </summary>
		public virtual bool? HasNoKeyStartSystem { get; set; }
        /// <summary>
        /// 无钥匙进入系统
        /// </summary>
		public virtual bool? HasNoKeyEnterSystem { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 