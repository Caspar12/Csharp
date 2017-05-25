namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IM_MsgHistorySyncTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IM_MsgHistorySyncTask()
        {
            IM_MsgHistorySyncTaskFile = new HashSet<IM_MsgHistorySyncTaskFile>();
        }

        public int ID { get; set; }

        [StringLength(26)]
        public string QueryHistoryDateTime { get; set; }

        [Required]
        [StringLength(16)]
        public string ChatType { get; set; }

        public DateTime CreatedDate { get; set; }

        public int State { get; set; }

        [StringLength(16)]
        public string ActionStatus { get; set; }

        public string ErrorInfo { get; set; }

        public int ErrorCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IM_MsgHistorySyncTaskFile> IM_MsgHistorySyncTaskFile { get; set; }
    }
}
