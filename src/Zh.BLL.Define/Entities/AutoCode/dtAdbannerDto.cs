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
	#region dtAdbannerDto

	/// <summary>
    /// 
	/// dtAdbannerDto data view model for mapped table 'dt_Adbanner'.
	/// </summary>
	public partial class dtAdbannerDto
	{
		
		#region Constructors
        
		public dtAdbannerDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 自增ID PK
        /// </summary>
		public virtual int id { get; set; }
        /// <summary>
        /// 广告位ID
        /// </summary>
		public virtual int Aid { get; set; }
        /// <summary>
        /// 广告条名称
        /// </summary>
		public virtual string Title { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
		public virtual DateTime StartTime { get; set; }
        /// <summary>
        /// 到期时间
        /// </summary>
		public virtual DateTime EndTime { get; set; }
        /// <summary>
        /// 广告地址
        /// </summary>
		public virtual string AdUrl { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
		public virtual string LinkUrl { get; set; }
        /// <summary>
        /// 备注说明
        /// </summary>
		public virtual string AdRemark { get; set; }
        /// <summary>
        /// 排序数字，越小越向前
        /// </summary>
		public virtual int SortId { get; set; }
        /// <summary>
        /// 状态，0正常，1暂停
        /// </summary>
		public virtual int IsLock { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
		public virtual DateTime AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual dtAdvertisingDto dtAdvertisingDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 