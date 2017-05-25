namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IM_MsgHistorySyncTaskFile
    {
        public int ID { get; set; }

        public DateTime CreatedDate { get; set; }

        public int TaskId { get; set; }

        [Required]
        public string URL { get; set; }

        public DateTime ExpireTime { get; set; }

        public int FileSize { get; set; }

        [Required]
        [StringLength(40)]
        public string FileMD5 { get; set; }

        public int GzipSize { get; set; }

        [Required]
        [StringLength(40)]
        public string GzipMD5 { get; set; }

        public string LocalUrl { get; set; }

        public virtual IM_MsgHistorySyncTask IM_MsgHistorySyncTask { get; set; }
    }
}
