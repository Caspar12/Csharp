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
	#region Car_OtherGoodCar

	/// <summary>
    /// 其它重磅好车表
	/// Car_OtherGoodCar object for mapped table 'Car_OtherGoodCar'.
	/// </summary>
	public partial class Car_OtherGoodCar
	{
		
		#region Constructors
        
		public Car_OtherGoodCar() { }        
        
		public Car_OtherGoodCar( Guid iD, int identity, Guid carMainId, Guid otherGoodCarId, int sort )
		{
			this.ID = iD;
			this.Identity = identity;
			this.CarMainId = carMainId;
			this.OtherGoodCarId = otherGoodCarId;
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
		public virtual Guid CarMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid OtherGoodCarId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual Car_Main Car_Main{get;set;}
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual Car_Main Car_Main2{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 