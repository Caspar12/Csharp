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
	#region Store_MainGoodCar

	/// <summary>
    ///  
	/// Store_MainGoodCar object for mapped table 'Store_MainGoodCar'.
	/// </summary>
	public partial class Store_MainGoodCar
	{
		
		#region Constructors
        
		public Store_MainGoodCar() { }        
        
		public Store_MainGoodCar( Guid iD, int identity, string url, string name, Guid mainId )
		{
			this.ID = iD;
			this.Identity = identity;
			this.Url = url;
			this.Name = name;
			this.MainId = mainId;
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
		public virtual string Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid MainId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual Store_Main Store_Main{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 