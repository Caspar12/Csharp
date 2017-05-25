using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Helpers
{
    internal class ConstantConfigHelper
    {
        /// <summary>
        /// 默认框架应用IoC配置目录 ~/Config/Zh/Framework/ApplicationContext
        /// </summary>
        public const string DEFAULT_CONFIG_DIRECTORY_PATH = "~/Config/Zh/Framework/ApplicationContext";
        /// <summary>
        /// 默认框架应用IoC配置重写目录 ~/Config/Zh/Framework/ApplicationContext/Override
        /// </summary>
        public const string DEFAULT_CONFIG_OVERRIDE_DIRECTORY_PATH = "~/Config/Zh/Framework/ApplicationContext/Override";
        /// <summary>
        /// 默认Ioc框架IoC配置目录 ~/Config/Zh/Framework/ApplicationContextIocLoader
        /// </summary>
        public const string DEFAULT_CONFIG_IOC_LOADER_DIRECTORY_PATH = "~/Config/Zh/Framework/ApplicationContextIocLoader";
        /// <summary>
        /// 默认文件缓存文件 ~/Cache/Zh
        /// </summary>
        public const string DEFAULT_CACHE_FILE_FULL_NAME = "~/Cache/Zh";     
    }
}
