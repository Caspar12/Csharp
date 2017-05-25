using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;
using Zh.Comp.Router.ReflectorRouters.MethodRouters;
using Zh.Framework.Tools.AppContextTool;
using Zh.Framework.Tools;

namespace Zh.Comp.Router.ReflectorRouters.Searchers
{
    /// <summary>
    /// 类型方法正式表达式搜索器
    /// </summary>
    public abstract class AbstractMethodRegexSearcher : AbstractSearcher
    {

        protected Regex RegexAssemblyName
        {
            get
            {
                return new Regex(this.AssemblyName);
            }
        }

        public string Type { get; set; }
        protected Regex RegexType
        {
            get
            {
                return new Regex(this.Type);
            }
        }

        public string Method { get; set; }
        protected Regex RegexMethod
        {
            get
            {
                return new Regex(this.Method);
            }
        }
        IAppContext _AppContext;
        public IAppContext AppContext
        {
            get
            {
                if (_AppContext == null) _AppContext = ToolFactory.CreateIAppContext();
                return _AppContext;
            }
        }
        public override IList<AbstractRouteData> Search()
        {
            var result = new List<AbstractRouteData>();
            var execDirFilePaths = new List<string>();
            var execDirDLLFilePaths = Directory.GetFiles(this.AppContext.GetExecPath(), "*.dll");
            var execDirExeFilePaths = Directory.GetFiles(this.AppContext.GetExecPath(), "*.exe");
            execDirFilePaths.AddRange(execDirDLLFilePaths);
            execDirFilePaths.AddRange(execDirExeFilePaths);
            foreach (var execDirFilePath in execDirFilePaths)
            {
                FileInfo dLLFileInfo = new FileInfo(execDirFilePath);
                string dLLFileInfoName = dLLFileInfo.Name;
                if (RegexAssemblyName.IsMatch(dLLFileInfoName) == false) continue;
                var assembly = Assembly.LoadFile(execDirFilePath);
                var searchAssemblyResult = Search(assembly);
                result.AddRange(searchAssemblyResult);
            }
            return result;
        }
        IList<AbstractRouteData> Search(Assembly assembly)
        {
            List<AbstractRouteData> result = new List<AbstractRouteData>();
            var assemblyTypes = assembly.GetTypes();
            foreach (var assemblyType in assemblyTypes)
            {
                if (this.IsNotValidType(assemblyType))
                {
                    continue;
                }
                var searchTypeReslut = Search(assemblyType);
                result.AddRange(searchTypeReslut);
            }
            return result;
        }

        protected virtual bool IsNotValidType(System.Type assemblyType)
        {
            if (this.RegexType.IsMatch(assemblyType.FullName) == false)
            {
                return true;
            }
            return false;
        }
        IList<AbstractRouteData> Search(Type serviceType)
        {
            List<AbstractRouteData> result = new List<AbstractRouteData>();
            var bindingFlags = BindingFlags.Public | BindingFlags.Instance;
            var methods = serviceType.GetMethods(bindingFlags);
            foreach (var method in methods)
            {
                if (this.RegexMethod.IsMatch(method.Name) == false)
                {
                    continue;
                }
                AbstractMethodRouteData routeData = CreateRouteData();

                routeData.MethodInfo = method;
                routeData.ParameterInfos = method.GetParameters();
                routeData.RouteFilters = this.RouteFilters;
                routeData.RouteMappers = this.RouteMappers;
                routeData.IsOverrideTableRouteMappers = this.IsOverrideTableRouteMappers;
                routeData.ServiceType = serviceType;
                routeData.To = null;

                result.Add(routeData);
            }
            return result;
        }
        /// <summary>
        /// 创建目标路由数据
        /// </summary>
        /// <returns></returns>
        protected abstract AbstractMethodRouteData CreateRouteData();
    }
}
