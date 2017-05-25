/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据契约实体模型文件 
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
using Zh.Framework.Exceptions;
namespace Zh.BLL.Define.Entities
{
    public partial class WeiXinQRCodeDto : WeiXin_QRCode
    {
        /// <summary>
        /// 二维码类型,QR_SCENE为临时标识
        /// </summary>
        public static string ACTION_NAME_QR_SCENE = "QR_SCENE";
        /// <summary>
        /// 二维码类型,QR_LIMIT_STR_SCENE为永久
        /// </summary>
        public static string ACTION_NAME_QR_LIMIT_STR_SCENE = "QR_LIMIT_STR_SCENE";
        /// <summary>
        /// 是否临时二维码类型
        /// </summary>
        public bool IsTemporary
        {
            get
            {

                return this.ActionName == WeiXinQRCodeDto.ACTION_NAME_QR_SCENE;
            }
        }
        /// <summary>
        /// 是否永久二维码类型
        /// </summary>
        public bool IsForever
        {
            get
            {

                return this.ActionName == WeiXinQRCodeDto.ACTION_NAME_QR_LIMIT_STR_SCENE;
            }
        }
        /// <summary>
        /// 是否过期
        /// </summary>
        public bool IsExpire
        {
            get
            {
                if (this.IsForever) return false;
                if (this.IsTemporary)
                {
                    return DateTime.Now > this.Expire;
                }
                throw new BaseException("未知二维码类型");
            }
        }
        /// <summary>
        /// 过期日期
        /// </summary>
        public DateTime Expire
        {
            get
            {
                if (this.IsForever) return DateTime.MaxValue;
                if (this.IsTemporary)
                {
                    return this.CreatedDate.AddSeconds(this.ExpireSeconds.Value);
                }
                throw new BaseException("未知二维码类型");
            }
        }
    }
}