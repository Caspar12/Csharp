using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zh.Window.Service.Timer.Tools.Entity;
using Zh.Framework.Tools.ConfigTool;
using Zh.Framework.Tools;
using Zh.Framework.Tools.SerializeTool.Imp;
using Zh.Framework.Tools.SerializeTool;
using System.IO;

namespace Zh.Window.Service.Timer.Tools
{
    public static class ConfigTool
    {
        public static TimerServiceConfig Get()
        {
            ISerializeTool tIXmlConfigTool = ToolFactory.Ioc.Get<IXmlSerializeTool>();
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, " /Config/TimerServiceConfig.xml");
            return tIXmlConfigTool.DeserializeFromFile<TimerServiceConfig>(path);

        }
    }
}
