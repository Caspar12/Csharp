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
	#region CarMultiMediaConfigDto

	/// <summary>
    /// 车辆多媒体配置
	/// CarMultiMediaConfigDto data view model for mapped table 'Car_MultiMediaConfig'.
	/// </summary>
	public partial class CarMultiMediaConfigDto
	{
		
		#region Constructors
        
		public CarMultiMediaConfigDto() { }        
        
	 
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
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 