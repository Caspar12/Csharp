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
	#region CommonAddressAreaDto

	/// <summary>
    /// 镇级
	/// CommonAddressAreaDto data view model for mapped table 'Common_Address_Area'.
	/// </summary>
	public partial class CommonAddressAreaDto
	{
		
		#region Constructors
        
		public CommonAddressAreaDto() { }        
        
	 
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
        public virtual CommonAddressCityDto CommonAddressCityDto{get;set;}
        /// <summary>
        /// 省份
        /// </summary>            
        public virtual CommonAddressProvinceDto CommonAddressProvinceDto{get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<CarEnquiryDto> CarEnquiryDto{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<CarExchangeDto> CarExchangeDto{get;set;}
        /// <summary>
        /// 会员资料表
        /// </summary>
        public virtual IList<MemberProfileDto> MemberProfileDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 