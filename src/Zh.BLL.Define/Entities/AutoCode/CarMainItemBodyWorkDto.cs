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
	#region CarMainItemBodyWorkDto

	/// <summary>
    /// 车辆车身参数
	/// CarMainItemBodyWorkDto data view model for mapped table 'Car_MainItem_BodyWork'.
	/// </summary>
	public partial class CarMainItemBodyWorkDto
	{
		
		#region Constructors
        
		public CarMainItemBodyWorkDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 长度(mm)
        /// </summary>
		public virtual string Length { get; set; }
        /// <summary>
        /// 宽度(mm)
        /// </summary>
		public virtual string Width { get; set; }
        /// <summary>
        /// 高度(mm)
        /// </summary>
		public virtual string Heihgt { get; set; }
        /// <summary>
        /// 轴距(mm)
        /// </summary>
		public virtual string WheelBase { get; set; }
        /// <summary>
        /// 前轮距(mm)
        /// </summary>
		public virtual string FrontWheelDistance { get; set; }
        /// <summary>
        /// 后轮距(mm)
        /// </summary>
		public virtual string BackWheelDistance { get; set; }
        /// <summary>
        /// 最小离地间隙(mm)
        /// </summary>
		public virtual string MinFloorDistance { get; set; }
        /// <summary>
        /// 整备质量
        /// </summary>
		public virtual string WholeKG { get; set; }
        /// <summary>
        /// 车身结构
        /// </summary>
		public virtual string BodyWorkStructure { get; set; }
        /// <summary>
        /// 车门数(个)
        /// </summary>
		public virtual string DoorOfCarCount { get; set; }
        /// <summary>
        /// 座位数(个)
        /// </summary>
		public virtual string SeatOfCarCount { get; set; }
        /// <summary>
        /// 油箱容积(L)
        /// </summary>
		public virtual string SpaceOfOilBox { get; set; }
        /// <summary>
        /// 行李厢容积(L)
        /// </summary>
		public virtual string SpaceOfTravelBox { get; set; }
        
        /// <summary>
        /// 指定车辆表
        /// </summary>            
        public virtual CarMainItemDto CarMainItemDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 