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
	#region Repair_SetTripDistance

	/// <summary>
    /// 维修套餐行驶里程表
	/// Repair_SetTripDistance object for mapped table 'Repair_SetTripDistance'.
	/// </summary>
	public partial class Repair_SetTripDistance
	{
		
		#region Constructors
        
		public Repair_SetTripDistance() { }        
        
		public Repair_SetTripDistance( Guid iD, int identity, string name, string shopID, int sort )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Name = name;
			this.ShopID = shopID;
			this.Sort = sort;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 网点ID
        /// </summary>
		public virtual string ShopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        
        
        /// <summary>
        /// 维修套餐表
        /// </summary>
        public virtual IList<Repair_Set> Repair_Set{get;set;}


		#endregion
	 
	}
	#endregion
}
 