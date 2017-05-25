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
	#region WeiXinMerchantBIllNoDto

	/// <summary>
    /// 微信商户账单号信息表
	/// WeiXinMerchantBIllNoDto data view model for mapped table 'WeiXin_MerchantBIllNo'.
	/// </summary>
	public partial class WeiXinMerchantBIllNoDto
	{
		
		#region Constructors
        
		public WeiXinMerchantBIllNoDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 微信关联WebAppId
        /// </summary>
		public virtual Guid WebApplicationId { get; set; }
        /// <summary>
        /// 账单日期
        /// </summary>
		public virtual DateTime BillCreatedDate { get; set; }
        /// <summary>
        /// 账单日期内不能重复数字
        /// </summary>
		public virtual int NumeroSign { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 