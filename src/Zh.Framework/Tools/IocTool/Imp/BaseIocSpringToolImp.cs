using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context.Support;
using Spring.Objects.Factory;
using Spring.Context;
using System.IO;
using Zh.Framework.Tools.AppContextTool;
using Zh.Framework.Helpers;
using Zh.Framework.Tools.ProgramTool.Imp;

namespace Zh.Framework.Tools.IocTool.Imp
{
    public class BaseIocSpringToolImp : IIocTool
    {
        protected IApplicationContext _Context;
        public IList<string> ConfigDirPaths { get; set; }
        protected IApplicationContext Context
        {
            get
            {
                if (_Context == null && ToolFactory.CreateIValidatorTool().IsNotEmpty(ConfigDirPaths))
                {
                    InitContext(ConfigDirPaths);
                }
                return _Context;
            }
        }
        protected void InitContext(IList<string> dirPaths)
        {
            IAppContext iAppContext = new AppContextTool.Imp.AppContextImp();
            List<string> xmlFiles = new List<string>();
            foreach (var dirPath in dirPaths)
            {
                var realDirPath = iAppContext.GetMapExecPath(dirPath);
                if (!Directory.Exists(realDirPath))
                {
                    continue;
                }
                var files = Directory.GetFiles(realDirPath);
                if (files.Length > 0)
                {
                    xmlFiles.AddRange(files);
                }
            }

            _Context = new XmlApplicationContext(xmlFiles.ToArray());
        }
        public BaseIocSpringToolImp(IApplicationContext context)
        {
            _Context = context;
        }

        public BaseIocSpringToolImp(string[] dirPaths)
        {
            InitContext(dirPaths);
        }

        public BaseIocSpringToolImp() { }


        public T Get<T>(string pIName = null) where T : class
        {

            var isIName = !string.IsNullOrEmpty(pIName);
            if (!isIName)
            {
                pIName = typeof(T).FullName;
            }
            object r = null;
            try
            {
                r = Context.GetObject(pIName);
            }
            catch (NoSuchObjectDefinitionException ex)
            {

            }
            if (r == null && !isIName)
            {
                var arr = Context.GetObjectsOfType(typeof(T));

                if (arr.Count > 0)
                {
                    foreach (System.Collections.DictionaryEntry i in arr)
                    {
                        return i.Value as T;
                    }
                }
            }

            return (T)r;

        }


        public T GetIfNullThrowException<T>() where T : class
        {
            T instance = Get<T>();
            if (instance == null)
            {
                throw new Exception(string.Format(ConstantLangHelper.ERROR_NO_THAT_PARAM_TYPE, typeof(T).FullName));
            }
            return instance;
        }

        public T Get<T>() where T : class
        {
            return Get<T>(null);
        }


        public object Get(Type type)
        {

            var pIName = type.FullName;

            object r = null;
            try
            {
                r = Context.GetObject(pIName);
            }
            catch (NoSuchObjectDefinitionException ex)
            {

            }
            if (r == null)
            {
                var arr = Context.GetObjectsOfType(type);

                if (arr.Count > 0)
                {
                    foreach (System.Collections.DictionaryEntry i in arr)
                    {
                        return i.Value;
                    }
                }
            }

            if (r == null)
            {
                throw new Exception(string.Format(ConstantLangHelper.ERROR_NO_THAT_PARAM_TYPE, type.FullName));
            }

            return r;

        }
        public string Name { get; set; }
    }
}
