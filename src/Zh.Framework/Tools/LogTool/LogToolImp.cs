using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Zh.Framework.Tools.ProgramTool;

namespace Zh.Framework.Tools.LogTool
{
    public class LogToolImp : ILogTool
    {
        IProgramTool _IProgramTool;

        public void Info(string pMsg)
        {
            WriteToFile(pMsg);
        }

        public void Info(string pMsg, Exception pException)
        {
            StringBuilder msg = new StringBuilder();
            var errorMsg = _IProgramTool.ConvertExceptionToString(pException);
            msg.AppendLine(pMsg);
            msg.AppendLine(errorMsg);
            WriteToFile(msg.ToString());
        }

        private void WriteToFile(string pMsg)
        {
            var logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            var logFileName = DateTime.Now.ToString("yyyyMMdd.log");
            var logFileFullName = Path.Combine(logDir, logFileName);

            StringBuilder writeMsg = new StringBuilder();
            writeMsg.AppendLine(DateTime.Now.ToString("时间:yyyy-MM-dd HH:mm:ss"));
            writeMsg.AppendLine("描述:");
            writeMsg.AppendLine(pMsg);
            File.WriteAllText(writeMsg.ToString(), logFileFullName);
        }
    }
}
