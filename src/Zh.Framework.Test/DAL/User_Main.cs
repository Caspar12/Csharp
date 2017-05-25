namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Main
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Main()
        {
            User_Follow = new HashSet<User_Follow>();
            User_Follow1 = new HashSet<User_Follow>();
            User_LiveVideo = new HashSet<User_LiveVideo>();
            User_LiveVideoViewer = new HashSet<User_LiveVideoViewer>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(36)]
        public string Account { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }

        public string HeadImgUrl { get; set; }

        [StringLength(32)]
        public string NickName { get; set; }

        public bool IsHost { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? LastestLoginDate { get; set; }

        public string OnlineVideoAppToken { get; set; }

        public bool? Sex { get; set; }

        [StringLength(30)]
        public string PersonalSignature { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Follow> User_Follow { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Follow> User_Follow1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_LiveVideo> User_LiveVideo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_LiveVideoViewer> User_LiveVideoViewer { get; set; }
    }
}
