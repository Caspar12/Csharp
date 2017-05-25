using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Zh.Framework.Helpers
{
    public class ExternDLLImportHelper
    {

        /// <summary>
        /// 装载动态库
        /// </summary>
        /// <param name="lpLibFileName">DLL 文件名</param>
        /// <returns>函数库模块的句柄 </returns>
        [DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
        public static extern int LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpLibFileName);

        /// <summary>
        /// 获取要引入的函数，将符号名或标识号转换为DLL内部地址。
        /// </summary>
        /// <param name="hModule">包含需调用函数的函数库模块的句柄</param>
        /// <param name="lpProcName">调用函数的名称</param>
        /// <returns>函数指针</returns>
        [DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
        public static extern IntPtr GetProcAddress(int hModule, [MarshalAs(UnmanagedType.LPStr)] string lpProcName);

        /// <summary>
        /// 释放动态链接库。
        /// </summary>
        /// <param name="hModule">需释放的函数库模块的句柄</param>
        /// <returns>是否已释放指定的 Dll</returns>
        [DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
        public static extern bool FreeLibrary(int hModule);

        public static void ExeDLLMethod(string dllFullName, string dllMethodName, Type delegateType, Action<Delegate> action)
        {
            var hModule = LoadLibrary(dllFullName);
            if (hModule == 0)
            {
                throw new Exception(string.Format("无法加载DLL:{0}", dllFullName));
            }
            IntPtr intPtr = GetProcAddress(hModule, dllMethodName);
            var method = Marshal.GetDelegateForFunctionPointer(intPtr, delegateType);
            action(method);
            FreeLibrary(hModule);
        }

        int hLib = 0;
        public ExternDLLImportHelper(String dllFullName)
        {
            hLib = LoadLibrary(dllFullName);
            if (hLib == 0)
            {
                throw new Exception(string.Format("无法加载DLL:{0}", dllFullName));
            }
        }

        ~ExternDLLImportHelper()
        {
            FreeLibrary(hLib);
        }

        //将要执行的函数转换为委托 
        public Delegate Invoke(String methodName, Type type)
        {
            IntPtr p_api = GetProcAddress(hLib, methodName);
            return (Delegate)Marshal.GetDelegateForFunctionPointer(p_api, type);
        }
    }
}
