using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Zh.Framework.Tools;
using Zh.Framework.Tools.AppContextTool;

namespace Zh.Web.Mvc.Framework.Initializers.Impl
{
    /// <summary>
    /// log4net 初始化程序
    /// </summary>
    public class Log4netInitializerImpl : Initializer
    {
        public int Sort
        {
            get; set;
        } = 0;

        public void Init(HttpApplication application)
        {
            var iAppContext = ToolFactory.Ioc.Get<IAppContext>();
            var log4netConfigServerPath = GetLog4netConfigPath();
            var log4netConfigPath = iAppContext.GetMapPath(log4netConfigServerPath);
            FileInfo log4netFileInfo = new FileInfo(log4netConfigPath);
            if (log4netFileInfo.Exists)
            {
                log4net.Config.XmlConfigurator.ConfigureAndWatch(log4netFileInfo);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(string.Format("无法加载日志配置文件.{0}->{1}", log4netConfigPath));
            }
        }


        /// <summary>
        /// 默认"~/Config/Log4net.config"
        /// </summary>
        /// <returns></returns>
        protected string GetLog4netConfigPath()
        {
            return "~/bin/Config/Log4net.config";
        }
    }
}