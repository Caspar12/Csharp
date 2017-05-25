namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IM_MsgLocationElem
    {
        public int ID { get; set; }

        public int Sort { get; set; }

        public int MsgId { get; set; }

        public string Desc { get; set; }

        [StringLength(64)]
        public string Latitude { get; set; }

        [StringLength(64)]
        public string Longitude { get; set; }

        public virtual IM_Msg IM_Msg { get; set; }
    }
}
