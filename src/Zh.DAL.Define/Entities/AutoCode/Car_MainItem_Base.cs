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
	#region Car_MainItem_Base

	/// <summary>
    /// 车辆基本参数
	/// Car_MainItem_Base object for mapped table 'Car_MainItem_Base'.
	/// </summary>
	public partial class Car_MainItem_Base
	{
		
		#region Constructors
        
		public Car_MainItem_Base() { }        
        
		public Car_MainItem_Base( Guid iD, string engine, string bodyWork, string maxSpeed, string officialSpeedUp, string realTestSpeedUp, string realTestBraking, string realTestOilConsumption, string confirmdriverAvgOilConsumption, string oilComsumptionOfMIIT, string qualityAssuranceOfCar )
		{
			this.ID = iD;
			this.Engine = engine;
			this.BodyWork = bodyWork;
			this.MaxSpeed = maxSpeed;
			this.OfficialSpeedUp = officialSpeedUp;
			this.RealTestSpeedUp = realTestSpeedUp;
			this.RealTestBraking = realTestBraking;
			this.RealTestOilConsumption = realTestOilConsumption;
			this.ConfirmdriverAvgOilConsumption = confirmdriverAvgOilConsumption;
			this.OilComsumptionOfMIIT = oilComsumptionOfMIIT;
			this.QualityAssuranceOfCar = qualityAssuranceOfCar;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 发动机
        /// </summary>
		public virtual string Engine { get; set; }
        /// <summary>
        /// 车身结构
        /// </summary>
		public virtual string BodyWork { get; set; }
        /// <summary>
        /// 最高车速
        /// </summary>
		public virtual string MaxSpeed { get; set; }
        /// <summary>
        /// 官方0-100km/h加速(s)
        /// </summary>
		public virtual string OfficialSpeedUp { get; set; }
        /// <summary>
        /// 实测试0-100km/h加速(s)
        /// </summary>
		public virtual string RealTestSpeedUp { get; set; }
        /// <summary>
        /// 实测试0-100km/h制动(M)
        /// </summary>
		public virtual string RealTestBraking { get; set; }
        /// <summary>
        /// 实测油耗(L/100KM)
        /// </summary>
		public virtual string RealTestOilConsumption { get; set; }
        /// <summary>
        /// 认证车主平均油耗(L/100km)
        /// </summary>
		public virtual string ConfirmdriverAvgOilConsumption { get; set; }
        /// <summary>
        /// 工信部综合油耗
        /// </summary>
		public virtual string OilComsumptionOfMIIT { get; set; }
        /// <summary>
        /// 整车质保
        /// </summary>
		public virtual string QualityAssuranceOfCar { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 