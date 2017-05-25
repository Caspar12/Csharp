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
	#region Car_MultiMediaConfig

	/// <summary>
    /// 车辆多媒体配置
	/// Car_MultiMediaConfig object for mapped table 'Car_MultiMediaConfig'.
	/// </summary>
	public partial class Car_MultiMediaConfig
	{
		
		#region Constructors
        
		public Car_MultiMediaConfig() { }        
        
		public Car_MultiMediaConfig( Guid iD, bool? hasGPS, bool? hasGPSInteractionService, bool? hasCenterControlMultiColorDisplay, bool? hasInternalDisk, bool? hasBlueTooth, bool? hasCarPhone, bool? hasCarTV, bool? hasBackLineLCD, bool? hasAuxilityVoice, bool? isCDSupportMP3OrWMA, string multiMediaSytem, string sounderCount )
		{
			this.ID = iD;
			this.HasGPS = hasGPS;
			this.HasGPSInteractionService = hasGPSInteractionService;
			this.HasCenterControlMultiColorDisplay = hasCenterControlMultiColorDisplay;
			this.HasInternalDisk = hasInternalDisk;
			this.HasBlueTooth = hasBlueTooth;
			this.HasCarPhone = hasCarPhone;
			this.HasCarTV = hasCarTV;
			this.HasBackLineLCD = hasBackLineLCD;
			this.HasAuxilityVoice = hasAuxilityVoice;
			this.IsCDSupportMP3OrWMA = isCDSupportMP3OrWMA;
			this.MultiMediaSytem = multiMediaSytem;
			this.SounderCount = sounderCount;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// GPS导航系统
        /// </summary>
		public virtual bool? HasGPS { get; set; }
        /// <summary>
        /// 定位互动服务
        /// </summary>
		public virtual bool? HasGPSInteractionService { get; set; }
        /// <summary>
        /// 中控台彩色大屏
        /// </summary>
		public virtual bool? HasCenterControlMultiColorDisplay { get; set; }
        /// <summary>
        /// 内置硬盘
        /// </summary>
		public virtual bool? HasInternalDisk { get; set; }
        /// <summary>
        /// 蓝牙
        /// </summary>
		public virtual bool? HasBlueTooth { get; set; }
        /// <summary>
        /// 车载电话
        /// </summary>
		public virtual bool? HasCarPhone { get; set; }
        /// <summary>
        /// 车载电视
        /// </summary>
		public virtual bool? HasCarTV { get; set; }
        /// <summary>
        /// 后排液晶
        /// </summary>
		public virtual bool? HasBackLineLCD { get; set; }
        /// <summary>
        /// 外接音源接口(AUX/USB/IPOD等)
        /// </summary>
		public virtual bool? HasAuxilityVoice { get; set; }
        /// <summary>
        /// cd支持mp3/wma
        /// </summary>
		public virtual bool? IsCDSupportMP3OrWMA { get; set; }
        /// <summary>
        /// 多媒体系统
        /// </summary>
		public virtual string MultiMediaSytem { get; set; }
        /// <summary>
        /// 扬声器数量
        /// </summary>
		public virtual string SounderCount { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual Car_MainItem Car_MainItem{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 