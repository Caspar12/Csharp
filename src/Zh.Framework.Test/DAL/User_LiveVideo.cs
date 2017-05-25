namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_LiveVideo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_LiveVideo()
        {
            User_LiveVideoVideo = new HashSet<User_LiveVideoVideo>();
            User_LiveVideoViewer = new HashSet<User_LiveVideoViewer>();
        }

        public int ID { get; set; }

        public int HostId { get; set; }

        [Required]
        [StringLength(64)]
        public string LiveVideoCode { get; set; }

        public string CoversImgUrl { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public bool IsLive { get; set; }

        public DateTime LastestHeartBeatTime { get; set; }

        [StringLength(32)]
        public string HostNickName { get; set; }

        public string HostHeadImgUrl { get; set; }

        public int ViewerCount { get; set; }

        public int ViewCount { get; set; }

        [StringLength(30)]
        public string HostPersonalSignature { get; set; }

        public virtual User_Main User_Main { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_LiveVideoVideo> User_LiveVideoVideo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_LiveVideoViewer> User_LiveVideoViewer { get; set; }
    }
}
