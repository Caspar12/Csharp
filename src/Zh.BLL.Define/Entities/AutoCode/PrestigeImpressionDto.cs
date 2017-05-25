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
	#region PrestigeImpressionDto

	/// <summary>
    /// 口啤印象表
	/// PrestigeImpressionDto data view model for mapped table 'Prestige_Impression'.
	/// </summary>
	public partial class PrestigeImpressionDto
	{
		
		#region Constructors
        
		public PrestigeImpressionDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增Id
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 印象类型(0-优点，1-缺点)
        /// </summary>
		public virtual int Type { get; set; }
        /// <summary>
        /// 印象内容
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
		public virtual Guid? MemberID { get; set; }
        /// <summary>
        /// 车款ID
        /// </summary>
		public virtual Guid? CarItemID { get; set; }
        /// <summary>
        /// 车型ID
        /// </summary>
		public virtual Guid CarMainID { get; set; }
        
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual MemberAccountDto MemberAccountDto{get;set;}
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 