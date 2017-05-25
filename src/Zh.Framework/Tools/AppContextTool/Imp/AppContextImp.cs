using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.IO;

namespace Zh.Framework.Tools.AppContextTool.Imp
{
    public class AppContextImp : IAppContext
    {
        public string GetMapPath(string path)
        {
            if (path.ToLower().StartsWith("http://"))
            {
                return path;
            }
            if (HttpContext.Current != null)
            {
                return HttpContext.Current.Server.MapPath(path);
            }
            else
            {
                if (path.StartsWith("~"))
                {
                    if (path.StartsWith("~"))
                    {
                        path = path.Substring(1);
                    }
                    path = path.Replace('/', Path.DirectorySeparatorChar);
                    if (path.StartsWith(Path.DirectorySeparatorChar.ToString()))
                    {
                        path = path.TrimStart(Path.DirectorySeparatorChar);
                    }
                    return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
                }
                else
                {
                    return path;
                }
            }
        }
        public string GetMapExecPath(string path)
        {
            if (HttpContext.Current != null)
            {
                if (path.StartsWith("~"))
                {
                    path = path.Substring(1);
                    if (path.StartsWith("/"))
                    {
                        path = path.Substring(1);
                    }
                    path = "~" + "/bin/" + path;
                }

                return HttpContext.Current.Server.MapPath(path);
            }
            else
            {
                return GetMapPath(path);
            }
        }


        public string GetExecPath()
        {
            return this.GetMapExecPath("~/");
        }
 
    }
}
