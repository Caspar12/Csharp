using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topshelf;
using log4net;
using Zh.Framework.Tools;
using Zh.Framework.Tools.LogTool;
using Zh.Window.Service.Timer.Tools;
using Zh.Window.Service.Timer.Tools.Entity;
using Quartz;
using Quartz.Impl;
using System.IO;

namespace Zh.Window.Service.Services
{
    public class ServiceRunner : ServiceControl, ServiceSuspend
    {


        private readonly IScheduler scheduler;
        public ServiceRunner()
        {
            scheduler = StdSchedulerFactory.GetDefaultScheduler();
        }

        public bool Start(HostControl hostControl)
        {
            scheduler.Start();
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            scheduler.Shutdown(false);
            return true;
        }

        public bool Continue(HostControl hostControl)
        {
            scheduler.ResumeAll();
            return true;
        }

        public bool Pause(HostControl hostControl)
        {
            scheduler.PauseAll();
            return true;
        }
    }
}
