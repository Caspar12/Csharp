using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.AppContextTool
{
    public interface IAppContext
    {
        /// <summary>
        /// 获得当前绝对路径,支持Web与IO系统
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <returns>绝对路径</returns>
        string GetMapPath(string path);
        /// <summary>
        /// 获得相对于运行目录的当前绝对路径,支持Web与IO系统
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <returns>绝对路径</returns>
        string GetMapExecPath(string path);
        /// <summary>
        /// 获取运行目录绝对路径,支持Web与IO系统
        /// </summary>
        /// <returns>运行目录绝对路径</returns>
        string GetExecPath();


     
    }
}
