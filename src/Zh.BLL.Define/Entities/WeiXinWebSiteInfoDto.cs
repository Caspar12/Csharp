/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据契约实体模型文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
namespace Zh.BLL.Define.Entities
{
    public partial class WeiXinWebSiteInfoDto : WeiXin_WebSiteInfo
    {
        /// <summary>
        /// 微信调用凭证过期时间
        /// </summary>
        public DateTime AccessTokenExpire
        {
            get
            {
                return this.AccessTokenUpdateDateTime.HasValue ? this.AccessTokenUpdateDateTime.Value.AddSeconds(7200) : DateTime.MinValue;
            }
        }
        /// <summary>
        /// 微信调用凭证是否过期
        /// </summary>
        public bool IsAccessTokenExpire
        {
            get
            {
                return DateTime.Now >= this.AccessTokenExpire;
            }
        }
        /// <summary>
        /// 微信调用凭证剩余过期时间,单位秒
        /// </summary>
        public int AccessTokenExpireInSeconds
        {
            get
            {
                return (this.AccessTokenExpire - DateTime.Now).Seconds;
            }
        }
    }
}