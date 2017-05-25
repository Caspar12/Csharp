using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Helpers;

namespace Zh.Framework.Tools.IocTool.Imp
{
    public class IocLoader : BaseIocSpringToolImp
    {
        public IocLoader()
        {
            InitContext(new string[]{
                ConstantConfigHelper.DEFAULT_CONFIG_IOC_LOADER_DIRECTORY_PATH
            });
        }
    }
}
