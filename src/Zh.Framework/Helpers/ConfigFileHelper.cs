using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Zh.Framework.Tools;
using Zh.Framework.Tools.SerializeTool;

namespace Zh.Framework.Helpers
{
    public class ConfigFileHelper<T>
    {
        ISerializeTool ISerializeTool;
        public string AppSettingName { get; protected set; }
        string _ConfigFilePath;
        public string ConfigFilePath
        {
            get
            {
                if (_ConfigFilePath == null)
                {
                    _ConfigFilePath = System.Configuration.ConfigurationSettings.AppSettings[this.AppSettingName];
                    var appContextHelper = ToolFactory.CreateIAppContext();
                    _ConfigFilePath = appContextHelper.GetMapPath(_ConfigFilePath);
                }
                return _ConfigFilePath;
            }
        }
        public ConfigFileHelper(string appSettingName)
        {
            this.AppSettingName = appSettingName;
            ISerializeTool = ToolFactory.CreateIXmlSerializeTool();
        }

        public ConfigFileHelper(string name, ISerializeTool iSerializeTool) : this(name)
        {
            this.ISerializeTool = iSerializeTool;
        }

        public T Load()
        {
            if (File.Exists(this.ConfigFilePath) == false) return default(T);
            return this.ISerializeTool.DeserializeFromFile<T>(this.ConfigFilePath);
        }

        public void Save(T obj)
        {
            this.ISerializeTool.SerializeToFile(obj, this.ConfigFilePath);
        }
    }
}
