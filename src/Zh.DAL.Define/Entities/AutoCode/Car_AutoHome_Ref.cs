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
	#region Car_AutoHome_Ref

	/// <summary>
    /// 汽车之家关系表
	/// Car_AutoHome_Ref object for mapped table 'Car_AutoHome_Ref'.
	/// </summary>
	public partial class Car_AutoHome_Ref
	{
		
		#region Constructors
        
		public Car_AutoHome_Ref() { }        
        
		public Car_AutoHome_Ref( Guid iD, string identity, string tableName, string tableID )
		{
			this.ID = iD;
			this.Identity = identity;
			this.TableName = tableName;
			this.TableID = tableID;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 汽车之家ID
        /// </summary>
		public virtual string Identity { get; set; }
        /// <summary>
        /// 关联表名
        /// </summary>
		public virtual string TableName { get; set; }
        /// <summary>
        /// 表ID
        /// </summary>
		public virtual string TableID { get; set; }
        
        


		#endregion
	 
	}
	#endregion
}
 