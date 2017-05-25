namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IM_Msg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IM_Msg()
        {
            IM_MsgFileElem = new HashSet<IM_MsgFileElem>();
            IM_MsgCustomElem = new HashSet<IM_MsgCustomElem>();
            IM_MsgFaceElem = new HashSet<IM_MsgFaceElem>();
            IM_MsgImageElem = new HashSet<IM_MsgImageElem>();
            IM_MsgLocationElem = new HashSet<IM_MsgLocationElem>();
            IM_MsgSoundElem = new HashSet<IM_MsgSoundElem>();
            IM_MsgTextElem = new HashSet<IM_MsgTextElem>();
        }

        public int ID { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(32)]
        public string FromAccount { get; set; }

        [StringLength(32)]
        public string ToAccount { get; set; }

        [StringLength(32)]
        public string GroupId { get; set; }

        [StringLength(16)]
        public string ChatType { get; set; }

        [StringLength(32)]
        public string MsgSeq { get; set; }

        [StringLength(32)]
        public string MsgRandom { get; set; }

        public string MsgBody { get; set; }

        public int? LiveVideoId { get; set; }

        public DateTime MsgTimestamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IM_MsgFileElem> IM_MsgFileElem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IM_MsgCustomElem> IM_MsgCustomElem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IM_MsgFaceElem> IM_MsgFaceElem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IM_MsgImageElem> IM_MsgImageElem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IM_MsgLocationElem> IM_MsgLocationElem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IM_MsgSoundElem> IM_MsgSoundElem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IM_MsgTextElem> IM_MsgTextElem { get; set; }
    }
}
