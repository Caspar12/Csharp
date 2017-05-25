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
	#region Car_Domain_Config

	/// <summary>
    /// 车辆域配置
	/// Car_Domain_Config object for mapped table 'Car_Domain_Config'.
	/// </summary>
	public partial class Car_Domain_Config
	{
		
		#region Constructors
        
		public Car_Domain_Config() { }        
        
		public Car_Domain_Config( Guid iD, int identity, string configXml )
		{
			this.ID = iD;
			this.Identity = identity;
			this.ConfigXml = configXml;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 配置Xml
        /// </summary>
		public virtual string ConfigXml { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 