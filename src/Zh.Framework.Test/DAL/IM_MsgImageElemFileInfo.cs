namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IM_MsgImageElemFileInfo
    {
        public int ID { get; set; }

        public int ImageElemId { get; set; }

        public int? Type { get; set; }

        public int? Size { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public string URL { get; set; }

        public virtual IM_MsgImageElem IM_MsgImageElem { get; set; }
    }
}
