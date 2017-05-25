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
	#region Common_Address_Province

	/// <summary>
    /// 省份
	/// Common_Address_Province object for mapped table 'Common_Address_Province'.
	/// </summary>
	public partial class Common_Address_Province
	{
		
		#region Constructors
        
		public Common_Address_Province() { }        
        
		public Common_Address_Province( int iD, string name, string order )
		{
			this.ID = iD;
			this.Name = name;
			this.Order = order;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual int ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Order { get; set; }
        
        
        /// <summary>
        /// 镇级
        /// </summary>
        public virtual IList<Common_Address_Area> Common_Address_Area{get;set;}
        /// <summary>
        /// 市区
        /// </summary>
        public virtual IList<Common_Address_City> Common_Address_City{get;set;}
        /// <summary>
        /// 会员资料表
        /// </summary>
        public virtual IList<Member_Profile> Member_Profile{get;set;}


		#endregion
	 
	}
	#endregion
}
 