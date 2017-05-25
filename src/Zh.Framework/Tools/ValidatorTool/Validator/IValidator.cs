using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Entities;

namespace Zh.Framework.Tools.ValidatorTool.Validator
{
    public interface IValidator
    {
        ExecResult IsValid();

        object Value { get; set; }
    }
}
