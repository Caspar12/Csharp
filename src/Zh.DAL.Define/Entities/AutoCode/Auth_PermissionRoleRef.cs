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
	#region Auth_PermissionRoleRef

	/// <summary>
    /// 权限与角色关系表
	/// Auth_PermissionRoleRef object for mapped table 'Auth_PermissionRoleRef'.
	/// </summary>
	public partial class Auth_PermissionRoleRef
	{
		
		#region Constructors
        
		public Auth_PermissionRoleRef() { }        
        
		public Auth_PermissionRoleRef( Guid iD, int identity, Guid permissionId, Guid roleId, int priority )
		{
			this.ID = iD;
			this.Identity = identity;
			this.PermissionId = permissionId;
			this.RoleId = roleId;
			this.Priority = priority;
		}
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
        public virtual Auth_Permission Auth_Permission{get;set;}
        /// <summary>
        /// 权限角色表
        /// </summary>            
        public virtual Auth_Role Auth_Role{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 