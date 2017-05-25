/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;

using System.Text;
using Zh.Framework.Tools.MoneyTool;
using Zh.Framework.Tools.CalenderTool;
using Zh.Framework.Tools.ValidatorTool;
using Zh.Framework.Tools.LanguageTool;
using Zh.Framework.Tools.ProgramTool;
using Zh.Framework.Tools.EntityTool;
using Zh.Framework.Tools.FileTool;
using Zh.Framework.Tools.IocTool;
using Zh.Framework.Tools.IocTool.Imp;
using Zh.Framework.Tools.ProgramTool.Imp;
using Zh.Framework.Tools.SerializeTool;
using Zh.Framework.Tools.SerializeTool.Imp;
using Zh.Framework.Tools.AppContextTool;
using System.Threading;
using Zh.Framework.Tools.CryptogramTool.Imp;
using Zh.Framework.Tools.CryptogramTool;

namespace Zh.Framework.Tools
{
    public static class ToolFactory
    {
        /// <summary>
        /// 创建金钱工具类接口
        /// </summary>
        /// <returns>金钱工具类接口</returns>
        public static IMoneyTool CreateIMoneyTool()
        {
            return new MoneyToolImp();
        }
        /// <summary>
        /// 创建时间工具类接口
        /// </summary>
        /// <returns>时间工具类接口</returns>
        public static ICalenderTool CreateICalenderTool()
        {
            return new CalenderToolImp();
        }
        /// <summary>
        /// 创建验证工具类接口
        /// </summary>
        /// <returns>验证工具类接口</returns>
        public static IValidatorTool CreateIValidatorTool()
        {
            return new ValidatorToolImp();
        }
        /// <summary>
        /// 创建语言工具类接口
        /// </summary>
        /// <returns>语言工具类接口</returns>
        public static ILanguageTool CreateILanguageTool()
        {
            return new LanguageToolImp();
        }
        /// <summary>
        /// 创建编程工具类接口
        /// </summary>
        /// <returns>编程工具类接口</returns>
        public static IProgramTool CreateIProgramTool()
        {
            return new ProgramToolImp();
        }
        /// <summary>
        /// 创建编程工具类接口
        /// </summary>
        /// <returns>编程工具类接口</returns>
        public static IEntityTool CreateIEntityTool()
        {
            return new EntityToolImp();
        }
        /// <summary>
        /// 创建文件工具类接口
        /// </summary>
        /// <returns>文件工具类接口</returns>
        public static IFileTool CreateIFileTool()
        {
            return new FileToolImp();
        }
        /// <summary>
        /// 创建Xml序列化工具
        /// </summary>
        /// <returns></returns>
        public static ISerializeTool CreateIXmlSerializeTool()
        {
            return new XmlSerializeToolImp();
        }
        /// <summary>
        /// 创建Json序列化工具
        /// </summary>
        /// <returns></returns>
        public static ISerializeTool CreateIJsonSerializeTool()
        {
            return new JsonSerializeTool();
        }
        /// <summary>
        /// 创建运行环境帮助工具
        /// </summary>
        /// <returns></returns>
        public static IAppContext CreateIAppContext()
        {
            return new AppContextTool.Imp.AppContextImp();
        }
        /// <summary>
        /// 创建加密帮助工具
        /// </summary>
        /// <returns></returns>
        public static ICryptogramTool CreateICryptogramTool()
        {
            return new CryptogramToolImp();
        }
        /// <summary>
        /// 创建Ioc工具类接口
        /// </summary>
        /// <returns>Ioc工具类接口</returns>
        public static IIocTool CreateIIocTool()
        {
            return IocLoader.Get<IIocTool>("Zh.Framework.IocApplicationContext");
        }
        /// <summary>
        /// 创建DAL层Ioc工具类接口
        /// </summary>
        /// <returns>DAL层Ioc工具类接口</returns>
        public static IIocTool CreateDALIIocTool()
        {
            return CreateIIocTool();
        }
        static IocLoader _IocLoader;
        /// <summary>
        /// 用于启动Ioc入口的Ioc启动类
        /// </summary>
        static IIocTool IocLoader
        {
            get
            {
                if (_IocLoader == null)
                {
                    _IocLoader = new IocLoader();
                }

                return _IocLoader;
            }
        }

        static IIocTool _Ioc;
        /// <summary>
        /// 程序环境Ioc
        /// </summary>
        public static IIocTool Ioc
        {
            get
            {
                return CreateIIocTool();
            }
        }
        /// <summary>
        /// 程序环境数据访问Ioc
        /// </summary>
        public static IIocTool DALIoc
        {
            get
            {

                return Ioc;
            }
        }
        /// <summary>
        /// 程序环境服务接口Ioc
        /// </summary>
        public static IIocTool BLLIoc
        {
            get
            {

                return Ioc;
            }
        }
    }
}
