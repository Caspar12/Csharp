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
	#region PrestigePostCollectionDto

	/// <summary>
    /// 口碑收藏表
	/// PrestigePostCollectionDto data view model for mapped table 'Prestige_PostCollection'.
	/// </summary>
	public partial class PrestigePostCollectionDto
	{
		
		#region Constructors
        
		public PrestigePostCollectionDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 帖子ID
        /// </summary>
		public virtual Guid PostID { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
		public virtual Guid MemberID { get; set; }
        
        /// <summary>
        /// 会员账号信息
        /// </summary>            
        public virtual MemberAccountDto MemberAccountDto{get;set;}
        /// <summary>
        /// 车辆口碑帖子
        /// </summary>            
        public virtual PrestigePostDto PrestigePostDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 