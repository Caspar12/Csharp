using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Zh.Framework.Tools.LogTool;
using System.IO;
using log4net;

namespace Zh.Window.Service.Timer.Jobs
{
    public class TestJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            LogManager.GetLogger("root").Info("TestJob Execute"); 
        }
    }
}
