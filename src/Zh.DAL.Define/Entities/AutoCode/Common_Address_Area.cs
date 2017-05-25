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
	#region Common_Address_Area

	/// <summary>
    /// 镇级
	/// Common_Address_Area object for mapped table 'Common_Address_Area'.
	/// </summary>
	public partial class Common_Address_Area
	{
		
		#region Constructors
        
		public Common_Address_Area() { }        
        
		public Common_Address_Area( int iD, int order, string name, int provinceID, int cityID )
		{
			this.ID = iD;
			this.Order = order;
			this.Name = name;
			this.ProvinceID = provinceID;
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
        /// 名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 省份ID
        /// </summary>
		public virtual int ProvinceID { get; set; }
        /// <summary>
        /// 市区Id
        /// </summary>
		public virtual int CityID { get; set; }
        
        /// <summary>
        /// 市区
        /// </summary>            
        public virtual Common_Address_City Common_Address_City{get;set;}
        /// <summary>
        /// 省份
        /// </summary>            
        public virtual Common_Address_Province Common_Address_Province{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Car_Enquiry> Car_Enquiry{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Car_Exchange> Car_Exchange{get;set;}
        /// <summary>
        /// 会员资料表
        /// </summary>
        public virtual IList<Member_Profile> Member_Profile{get;set;}


		#endregion
	 
	}
	#endregion
}
 