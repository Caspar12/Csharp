namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IM_MsgImageElem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IM_MsgImageElem()
        {
            IM_MsgImageElemFileInfo = new HashSet<IM_MsgImageElemFileInfo>();
        }

        public int ID { get; set; }

        public int Sort { get; set; }

        public int MsgId { get; set; }

        [StringLength(128)]
        public string UUID { get; set; }

        public int? ImageFormat { get; set; }

        public virtual IM_Msg IM_Msg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IM_MsgImageElemFileInfo> IM_MsgImageElemFileInfo { get; set; }
    }
}
