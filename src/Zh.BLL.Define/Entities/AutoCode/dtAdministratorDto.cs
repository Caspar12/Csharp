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
	#region dtAdministratorDto

	/// <summary>
    /// 
	/// dtAdministratorDto data view model for mapped table 'dt_Administrator'.
	/// </summary>
	public partial class dtAdministratorDto
	{
		
		#region Constructors
        
		public dtAdministratorDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 
        /// </summary>
		public virtual int Id { get; set; }
        /// <summary>
        /// 登录用户名
        /// </summary>
		public virtual string UserName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
		public virtual string UserPwd { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
		public virtual string ReadName { get; set; }
        /// <summary>
        /// 联系邮箱
        /// </summary>
		public virtual string UserEmail { get; set; }
        /// <summary>
        /// 管理员类型
        /// </summary>
		public virtual int UserType { get; set; }
        /// <summary>
        /// 权限列表
        /// </summary>
		public virtual string UserLevel { get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
		public virtual int IsLock { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime? AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        
        /// <summary>
        /// 后台账号与角色关系表
        /// </summary>
        public virtual IList<AuthAdministratorRoleRefDto> AuthAdministratorRoleRefDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 