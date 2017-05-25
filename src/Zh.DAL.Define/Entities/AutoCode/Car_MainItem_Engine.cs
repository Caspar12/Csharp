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
	#region Car_MainItem_Engine

	/// <summary>
    /// 车辆发动机参数
	/// Car_MainItem_Engine object for mapped table 'Car_MainItem_Engine'.
	/// </summary>
	public partial class Car_MainItem_Engine
	{
		
		#region Constructors
        
		public Car_MainItem_Engine() { }        
        
		public Car_MainItem_Engine( Guid iD, string version, string outputVolume, string inputMethod, string cylinderListStyle, string cylinderCount, string doorOfCylinderCount, string compressPercent, string valveTrain, string cylinderDistance, string moveDistance, string maxHorsePower, string maxPower, string maxRPM, string maxNm, string maxRNM, string specialTech, string fuel, string fuelVersion, string fuelMethod, string cylinderCoverMaterial, string cylinderBodyMaterial, string environmentalProtectionStandard )
		{
			this.ID = iD;
			this.Version = version;
			this.OutputVolume = outputVolume;
			this.InputMethod = inputMethod;
			this.CylinderListStyle = cylinderListStyle;
			this.CylinderCount = cylinderCount;
			this.DoorOfCylinderCount = doorOfCylinderCount;
			this.CompressPercent = compressPercent;
			this.ValveTrain = valveTrain;
			this.CylinderDistance = cylinderDistance;
			this.MoveDistance = moveDistance;
			this.MaxHorsePower = maxHorsePower;
			this.MaxPower = maxPower;
			this.MaxRPM = maxRPM;
			this.MaxNm = maxNm;
			this.MaxRNM = maxRNM;
			this.SpecialTech = specialTech;
			this.Fuel = fuel;
			this.FuelVersion = fuelVersion;
			this.FuelMethod = fuelMethod;
			this.CylinderCoverMaterial = cylinderCoverMaterial;
			this.CylinderBodyMaterial = cylinderBodyMaterial;
			this.EnvironmentalProtectionStandard = environmentalProtectionStandard;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 发动机型号
        /// </summary>
		public virtual string Version { get; set; }
        /// <summary>
        /// 排量(mL)
        /// </summary>
		public virtual string OutputVolume { get; set; }
        /// <summary>
        /// 进气形式
        /// </summary>
		public virtual string InputMethod { get; set; }
        /// <summary>
        /// 气缸排列形式
        /// </summary>
		public virtual string CylinderListStyle { get; set; }
        /// <summary>
        /// 气缸数(个)
        /// </summary>
		public virtual string CylinderCount { get; set; }
        /// <summary>
        /// 每缸气门数(个)
        /// </summary>
		public virtual string DoorOfCylinderCount { get; set; }
        /// <summary>
        /// 压缩比
        /// </summary>
		public virtual string CompressPercent { get; set; }
        /// <summary>
        /// 配气机构
        /// </summary>
		public virtual string ValveTrain { get; set; }
        /// <summary>
        /// 缸径(mm)
        /// </summary>
		public virtual string CylinderDistance { get; set; }
        /// <summary>
        /// 行程(mm)
        /// </summary>
		public virtual string MoveDistance { get; set; }
        /// <summary>
        /// 最大马力(Ps)
        /// </summary>
		public virtual string MaxHorsePower { get; set; }
        /// <summary>
        /// 最大功率(kw)
        /// </summary>
		public virtual string MaxPower { get; set; }
        /// <summary>
        /// 最大功率转速(rpm)
        /// </summary>
		public virtual string MaxRPM { get; set; }
        /// <summary>
        /// 最大扭矩(N*m)
        /// </summary>
		public virtual string MaxNm { get; set; }
        /// <summary>
        /// 最大扭矩转速(rpm)
        /// </summary>
		public virtual string MaxRNM { get; set; }
        /// <summary>
        /// 发动机特有技术
        /// </summary>
		public virtual string SpecialTech { get; set; }
        /// <summary>
        /// 燃料形式
        /// </summary>
		public virtual string Fuel { get; set; }
        /// <summary>
        /// 燃油标号
        /// </summary>
		public virtual string FuelVersion { get; set; }
        /// <summary>
        /// 供油方式
        /// </summary>
		public virtual string FuelMethod { get; set; }
        /// <summary>
        /// 缸盖材料
        /// </summary>
		public virtual string CylinderCoverMaterial { get; set; }
        /// <summary>
        /// 缸体材料
        /// </summary>
		public virtual string CylinderBodyMaterial { get; set; }
        /// <summary>
        /// 环保标准
        /// </summary>
		public virtual string EnvironmentalProtectionStandard { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 