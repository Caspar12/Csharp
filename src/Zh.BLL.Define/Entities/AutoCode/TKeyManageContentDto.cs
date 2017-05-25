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
	#region TKeyManageContentDto

	/// <summary>
    /// 
	/// TKeyManageContentDto data view model for mapped table 'T_KeyManageContent'.
	/// </summary>
	public partial class TKeyManageContentDto
	{
		
		#region Constructors
        
		public TKeyManageContentDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 重点管理内容表
        /// </summary>
		public virtual int ContentIndex { get; set; }
        /// <summary>
        /// 位置ID
        /// </summary>
		public virtual int? PositionID { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
		public virtual int? TypeID { get; set; }
        /// <summary>
        /// 图片Url
        /// </summary>
		public virtual string ImgUrl { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
		public virtual string Link { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        /// <summary>
        /// 是否显示在首页，0不允许，1允许
        /// </summary>
		public virtual int IsShow { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 