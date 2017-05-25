namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Follow
    {
        public long ID { get; set; }

        public int UserId { get; set; }

        public int FollowUserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual User_Main User_Main { get; set; }

        public virtual User_Main User_Main1 { get; set; }
    }
}
