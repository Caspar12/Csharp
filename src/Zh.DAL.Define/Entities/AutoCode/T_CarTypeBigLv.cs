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
	#region T_CarTypeBigLv

	/// <summary>
    /// 
	/// T_CarTypeBigLv object for mapped table 'T_CarTypeBigLv'.
	/// </summary>
	public partial class T_CarTypeBigLv
	{
		
		#region Constructors
        
		public T_CarTypeBigLv() { }        
        
		public T_CarTypeBigLv( int carTypeBigLVIndex, string carTypeBigLVName, decimal? addQuotiety, string remark, byte[] stamp )
		{
			this.CarTypeBigLVIndex = carTypeBigLVIndex;
			this.CarTypeBigLVName = carTypeBigLVName;
			this.AddQuotiety = addQuotiety;
			this.Remark = remark;
			this.Stamp = stamp;
		}
		#endregion

		#region Public Properties
        /// <summary>
        /// 大车型等级表索引
        /// </summary>
		public virtual int CarTypeBigLVIndex { get; set; }
        /// <summary>
        /// 等级名称,微型 小型 紧凑型 中型 中大型 豪华 MPV SUV 跑车 面包车
        /// </summary>
		public virtual string CarTypeBigLVName { get; set; }
        /// <summary>
        /// 加权系数,系数或率都以百分比计，例如百分80则此字段填写80
        /// </summary>
		public virtual decimal? AddQuotiety { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
		public virtual string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<T_CarTypeBig> T_CarTypeBig{get;set;}


		#endregion
	 
	}
	#endregion
}
 