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
	#region AuthPermissionDto

	/// <summary>
    /// 权限表
	/// AuthPermissionDto data view model for mapped table 'Auth_Permission'.
	/// </summary>
	public partial class AuthPermissionDto
	{
		
		#region Constructors
        
		public AuthPermissionDto() { }        
        
	 
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
        /// 名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
		public virtual string Description { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        
        
        /// <summary>
        /// 权限资源关系表
        /// </summary>
        public virtual IList<AuthPermissionResourceRefDto> AuthPermissionResourceRefDto{get;set;}
        /// <summary>
        /// 权限与角色关系表
        /// </summary>
        public virtual IList<AuthPermissionRoleRefDto> AuthPermissionRoleRefDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 