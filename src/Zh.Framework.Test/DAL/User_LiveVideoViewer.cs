namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_LiveVideoViewer
    {
        public int ID { get; set; }

        public int LiveVideoId { get; set; }

        public int ViewerId { get; set; }

        public DateTime ViewDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastestHeartBeatTime { get; set; }

        public virtual User_LiveVideo User_LiveVideo { get; set; }

        public virtual User_Main User_Main { get; set; }
    }
}
