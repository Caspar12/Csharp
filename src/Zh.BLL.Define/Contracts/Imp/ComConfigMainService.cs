/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据接口契约文件 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.DAL.Base.Define;
using Zh.DAL.Base.Define.Query;
using Zh.BLL.Base.Define;
using Zh.BLL.Define.Entities;
using Zh.Framework.Tools;
using Zh.Framework.Entities;

namespace Zh.BLL.Define.Contracts.Imp
{
    public partial class ComConfigMainService : GenericContextService<ComConfigMainDto, Com_ConfigMain>, IComConfigMainService
    {
        public T GetOrCreate<T>(Guid configId, T defaultConfig)
        {
            var iJson = ToolFactory.CreateIJsonSerializeTool();
            var models = this.FindById(configId);
            if (models != null)
            {
                var result = iJson.DeserializeFromString<T>(models.ConfigContent);
                return result;
            }
            else
            {
                var configJsonString = iJson.SerializeToString(defaultConfig);
                this.Insert(new ComConfigMainDto()
                {
                    ID = configId,
                    ConfigContent = configJsonString
                });
                return defaultConfig;
            }
        }
    }
}
