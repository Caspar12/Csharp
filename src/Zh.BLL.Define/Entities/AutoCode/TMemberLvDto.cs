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
	#region TMemberLvDto

	/// <summary>
    /// 
	/// TMemberLvDto data view model for mapped table 'T_MemberLv'.
	/// </summary>
	public partial class TMemberLvDto
	{
		
		#region Constructors
        
		public TMemberLvDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 会员等级索引
        /// </summary>
		public virtual int MemberLvIndex { get; set; }
        /// <summary>
        /// 会员级别名称：铂金会员、白金会员、黄金会员、普通会员。
        /// </summary>
		public virtual string MemberLvName { get; set; }
        /// <summary>
        /// 会员年费
        /// </summary>
		public virtual decimal MemberLvPayment { get; set; }
        /// <summary>
        /// 会员权利描述
        /// </summary>
		public virtual string MemberLvDescription { get; set; }
        /// <summary>
        /// 会员商品折扣
        /// </summary>
		public virtual decimal? MemberLvAgioWare { get; set; }
        /// <summary>
        /// 会员服务折扣
        /// </summary>
		public virtual decimal? MemberLvAgioServe { get; set; }
        /// <summary>
        /// 升级值,0为不升级
        /// </summary>
		public virtual decimal? MemberLvUpValue { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
		public virtual string MemberRemark { get; set; }
        /// <summary>
        /// 店号
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 