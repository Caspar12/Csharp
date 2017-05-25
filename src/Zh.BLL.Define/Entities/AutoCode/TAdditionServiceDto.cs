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
	#region TAdditionServiceDto

	/// <summary>
    /// 
	/// TAdditionServiceDto data view model for mapped table 'T_AdditionService'.
	/// </summary>
	public partial class TAdditionServiceDto
	{
		
		#region Constructors
        
		public TAdditionServiceDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 附加业务表
        /// </summary>
		public virtual int ServiceIndex { get; set; }
        /// <summary>
        /// 位置ID
        /// </summary>
		public virtual int? PositionID { get; set; }
        /// <summary>
        /// 类别ID
        /// </summary>
		public virtual int? TypeID { get; set; }
        /// <summary>
        /// LOGO图片
        /// </summary>
		public virtual string LogoUrl { get; set; }
        /// <summary>
        /// 内容图片
        /// </summary>
		public virtual string ContentUrl { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
		public virtual string Link { get; set; }
        /// <summary>
        /// 新浪微博
        /// </summary>
		public virtual string Weibo { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
		public virtual string QQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 