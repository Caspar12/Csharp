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
	#region ConfigHotCityDto

	/// <summary>
    /// 热门城市
	/// ConfigHotCityDto data view model for mapped table 'Config_HotCity'.
	/// </summary>
	public partial class ConfigHotCityDto
	{
		
		#region Constructors
        
		public ConfigHotCityDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual int ID { get; set; }
        /// <summary>
        /// 顺序
        /// </summary>
		public virtual int Order { get; set; }
        /// <summary>
        /// 城市ID
        /// </summary>
		public virtual int CityID { get; set; }
        
        /// <summary>
        /// 市区
        /// </summary>            
        public virtual CommonAddressCityDto CommonAddressCityDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 