using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.IocTool;

namespace Zh.WeiXin.BLL.API
{
    /// <summary>
    /// 微信API集合环境
    /// </summary>
    public class WeiXinAPIContext
    {
        /// <summary>
        /// 微信基础数据API
        /// </summary>
        public IBasicAPI IBasicAPI { get; set; }
        /// <summary>
        /// 微信用户基本信息API
        /// </summary>
        public IAccountAPI IAccountAPI { get; set; }
        /// <summary>
        /// 微信JSSDK API
        /// </summary>
        public IJSAPI IJSAPI { get; set; }
        /// <summary>
        /// 微信二维码API
        /// </summary>
        public IQRCodeAPI IQRCodeAPI { get; set; }
        /// <summary>
        /// 微信现金红包API
        /// </summary>
        public IPayCashRedPack IPayCashRedPack { get; set; }
    }
}
