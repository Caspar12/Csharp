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
    #region WeiXin_MerchantBIllNo

    /// <summary>
    /// 微信商户账单号信息表
    /// WeiXin_MerchantBIllNo object for mapped table 'WeiXin_MerchantBIllNo'.
    /// </summary>
    public partial class WeiXin_MerchantBIllNo
    {

        #region Constructors

        public WeiXin_MerchantBIllNo() { }

        public WeiXin_MerchantBIllNo(Guid webApplicationId, DateTime billCreatedDate, int numeroSign)
        {

            this.WebApplicationId = webApplicationId;

            this.BillCreatedDate = billCreatedDate;

            this.NumeroSign = numeroSign;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// 微信关联WebAppId
        /// </summary>
        public virtual Guid WebApplicationId { get; set; }
        /// <summary>
        /// 账单日期
        /// </summary>
        public virtual DateTime BillCreatedDate { get; set; }
        /// <summary>
        /// 账单日期内不能重复数字
        /// </summary>
        public virtual int NumeroSign { get; set; }


        /// <summary>
        /// 判断两个对象是否相同，这个方法需要重写
        /// </summary>
        /// <param name="obj">进行比较的对象</param>
        /// <returns>真true或假false</returns>
        public override bool Equals(object obj)
        {
            if (obj is WeiXin_MerchantBIllNo)
            {
                WeiXin_MerchantBIllNo pk = obj as WeiXin_MerchantBIllNo;
                if (this.BillCreatedDate == pk.BillCreatedDate &&
                    this.NumeroSign == pk.NumeroSign &&
                    this.WebApplicationId == pk.WebApplicationId)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    }
    #endregion
}
