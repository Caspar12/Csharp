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
	#region AuthPermissionRoleRefDto

	/// <summary>
    /// 权限与角色关系表
	/// AuthPermissionRoleRefDto data view model for mapped table 'Auth_PermissionRoleRef'.
	/// </summary>
	public partial class AuthPermissionRoleRefDto
	{
		
		#region Constructors
        
		public AuthPermissionRoleRefDto() { }        
        
	 
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
        /// 权限Id
        /// </summary>
		public virtual Guid PermissionId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
		public virtual Guid RoleId { get; set; }
        /// <summary>
        /// 优先级
        /// </summary>
		public virtual int Priority { get; set; }
        
        /// <summary>
        /// 权限表
        /// </summary>            
        public virtual AuthPermissionDto AuthPermissionDto{get;set;}
        /// <summary>
        /// 权限角色表
        /// </summary>            
        public virtual AuthRoleDto AuthRoleDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 