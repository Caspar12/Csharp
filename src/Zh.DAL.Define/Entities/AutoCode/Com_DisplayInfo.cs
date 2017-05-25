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
	#region Com_DisplayInfo

	/// <summary>
    /// 通用展示信息关联表
	/// Com_DisplayInfo object for mapped table 'Com_DisplayInfo'.
	/// </summary>
	public partial class Com_DisplayInfo
	{
		
		#region Constructors
        
		public Com_DisplayInfo() { }        
        
		public Com_DisplayInfo( Guid iD, string displayTypeId, int sort, Guid objectId, bool isShow )
		{
			this.ID = iD;
			this.DisplayTypeId = displayTypeId;
			this.Sort = sort;
			this.ObjectId = objectId;
			this.IsShow = isShow;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 展示类型Id
        /// </summary>
		public virtual string DisplayTypeId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 关联对象Id
        /// </summary>
		public virtual Guid ObjectId { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
		public virtual bool IsShow { get; set; }
        
        /// <summary>
        /// 通用展示类型表
        /// </summary>            
        public virtual Com_DisplayType Com_DisplayType{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 