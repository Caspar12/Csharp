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
	#region Prestige_PostCollection

	/// <summary>
    /// 口碑收藏表
	/// Prestige_PostCollection object for mapped table 'Prestige_PostCollection'.
	/// </summary>
	public partial class Prestige_PostCollection
	{
		
		#region Constructors
        
		public Prestige_PostCollection() { }        
        
		public Prestige_PostCollection( Guid iD, Guid postID, Guid memberID )
		{
			this.ID = iD;
			this.PostID = postID;
			this.MemberID = memberID;
		}
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
        public virtual Member_Account Member_Account{get;set;}
        /// <summary>
        /// 车辆口碑帖子
        /// </summary>            
        public virtual Prestige_Post Prestige_Post{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 