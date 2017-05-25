namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IM_MsgSoundElem
    {
        public int ID { get; set; }

        public int Sort { get; set; }

        public int MsgId { get; set; }

        [StringLength(128)]
        public string UUID { get; set; }

        public int? Size { get; set; }

        public int? Second { get; set; }

        public virtual IM_Msg IM_Msg { get; set; }
    }
}
