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
	#region Config_HotCity

	/// <summary>
    /// 热门城市
	/// Config_HotCity object for mapped table 'Config_HotCity'.
	/// </summary>
	public partial class Config_HotCity
	{
		
		#region Constructors
        
		public Config_HotCity() { }        
        
		public Config_HotCity( int iD, int order, int cityID )
		{
			this.ID = iD;
			this.Order = order;
			this.CityID = cityID;
		}
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
        public virtual Common_Address_City Common_Address_City{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 