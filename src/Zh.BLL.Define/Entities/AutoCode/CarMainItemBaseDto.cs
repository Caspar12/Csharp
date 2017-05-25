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
	#region CarMainItemBaseDto

	/// <summary>
    /// 车辆基本参数
	/// CarMainItemBaseDto data view model for mapped table 'Car_MainItem_Base'.
	/// </summary>
	public partial class CarMainItemBaseDto
	{
		
		#region Constructors
        
		public CarMainItemBaseDto() { }        
        
	 
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
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 