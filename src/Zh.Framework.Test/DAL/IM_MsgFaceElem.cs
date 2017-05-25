namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IM_MsgFaceElem
    {
        public int ID { get; set; }

        public int Sort { get; set; }

        public int MsgId { get; set; }

        public int? Index { get; set; }

        public string Data { get; set; }

        public virtual IM_Msg IM_Msg { get; set; }
    }
}
