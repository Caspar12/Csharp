using System;
using System.Collections.Generic;
using System.Text;
using Topshelf;
using Zh.Window.Service.Timer.Tools.Entity;
using Zh.Window.Service.Timer.Tools;
using Zh.Window.Service.Services;
using System.IO;
using log4net;

namespace Zh.Window.Service.Timer
{
    class Program
    {
        static void Main(string[] args)
        {
          
            TimerServiceConfig timerServiceConfig = ConfigTool.Get();
           
            HostFactory.Run(x =>
            {
                x.UseLog4Net();
                x.Service<ServiceRunner>();
                x.SetDescription(timerServiceConfig.Description);
                x.SetDisplayName(timerServiceConfig.DisplayName);
                x.SetServiceName(timerServiceConfig.ServiceName);
                x.EnablePauseAndContinue();
                x.StartAutomatically();
                x.RunAsLocalSystem();
                
            });
        } 
    }
}
