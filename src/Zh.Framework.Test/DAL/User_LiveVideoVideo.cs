namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_LiveVideoVideo
    {
        public int ID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [Required]
        [StringLength(128)]
        public string VideoId { get; set; }

        [Required]
        public string VideoUrl { get; set; }

        [Required]
        [StringLength(64)]
        public string FileSize { get; set; }

        public int LiveVideoId { get; set; }

        [Required]
        [StringLength(64)]
        public string LiveVideoCode { get; set; }

        [StringLength(64)]
        public string FileId { get; set; }

        public string DownloadedVideoUrl { get; set; }

        public virtual User_LiveVideo User_LiveVideo { get; set; }
    }
}
