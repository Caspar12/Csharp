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
	#region Car_MainToStore_MainRef

	/// <summary>
    /// 抽象关系表
	/// Car_MainToStore_MainRef object for mapped table 'Car_MainToStore_MainRef'.
	/// </summary>
	public partial class Car_MainToStore_MainRef
	{
		
		#region Constructors
        
		public Car_MainToStore_MainRef() { }        
        
		public Car_MainToStore_MainRef( Guid id, Guid carMainId, Guid storeMainId, int sort, DateTime createdDatetime, int isShowInGoodCar, int isShowInCarMainDetal, int isShowInTalkPrice )
		{
			this.Id = id;
			this.CarMainId = carMainId;
			this.StoreMainId = storeMainId;
			this.Sort = sort;
			this.CreatedDatetime = createdDatetime;
			this.IsShowInGoodCar = isShowInGoodCar;
			this.IsShowInCarMainDetal = isShowInCarMainDetal;
			this.IsShowInTalkPrice = isShowInTalkPrice;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// Id
        /// </summary>
		public virtual Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid CarMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid StoreMainId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
		public virtual int Sort { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
		public virtual DateTime CreatedDatetime { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int IsShowInGoodCar { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int IsShowInCarMainDetal { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int IsShowInTalkPrice { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual Car_Main Car_Main{get;set;}
        /// <summary>
        /// 
        /// </summary>            
        public virtual Store_Main Store_Main{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 