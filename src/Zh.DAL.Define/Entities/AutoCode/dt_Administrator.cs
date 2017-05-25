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
	#region dt_Administrator

	/// <summary>
    /// 
	/// dt_Administrator object for mapped table 'dt_Administrator'.
	/// </summary>
	public partial class dt_Administrator
	{
		
		#region Constructors
        
		public dt_Administrator() { }        
        
		public dt_Administrator( int id, string userName, string userPwd, string readName, string userEmail, int userType, string userLevel, int isLock, DateTime? addTime, byte[] stamp )
		{
			this.Id = id;
			this.UserName = userName;
			this.UserPwd = userPwd;
			this.ReadName = readName;
			this.UserEmail = userEmail;
			this.UserType = userType;
			this.UserLevel = userLevel;
			this.IsLock = isLock;
			this.AddTime = addTime;
			this.Stamp = stamp;
		}
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
        public virtual IList<Auth_AdministratorRoleRef> Auth_AdministratorRoleRef{get;set;}


		#endregion
	 
	}
	#endregion
}
 