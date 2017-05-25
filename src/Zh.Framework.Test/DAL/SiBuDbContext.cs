namespace Zh.Framework.Test.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SiBuDbContext : DbContext
    {
        public SiBuDbContext()
            : base("name=SiBuDbContext")
        {
        }

        public virtual DbSet<IM_Msg> IM_Msg { get; set; }
        public virtual DbSet<IM_MsgCustomElem> IM_MsgCustomElem { get; set; }
        public virtual DbSet<IM_MsgFaceElem> IM_MsgFaceElem { get; set; }
        public virtual DbSet<IM_MsgFileElem> IM_MsgFileElem { get; set; }
        public virtual DbSet<IM_MsgHistorySyncTask> IM_MsgHistorySyncTask { get; set; }
        public virtual DbSet<IM_MsgHistorySyncTaskFile> IM_MsgHistorySyncTaskFile { get; set; }
        public virtual DbSet<IM_MsgImageElem> IM_MsgImageElem { get; set; }
        public virtual DbSet<IM_MsgImageElemFileInfo> IM_MsgImageElemFileInfo { get; set; }
        public virtual DbSet<IM_MsgLocationElem> IM_MsgLocationElem { get; set; }
        public virtual DbSet<IM_MsgSoundElem> IM_MsgSoundElem { get; set; }
        public virtual DbSet<IM_MsgTextElem> IM_MsgTextElem { get; set; }
        public virtual DbSet<User_Follow> User_Follow { get; set; }
        public virtual DbSet<User_LiveVideo> User_LiveVideo { get; set; }
        public virtual DbSet<User_LiveVideoVideo> User_LiveVideoVideo { get; set; }
        public virtual DbSet<User_LiveVideoViewer> User_LiveVideoViewer { get; set; }
        public virtual DbSet<User_Main> User_Main { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IM_Msg>()
                .HasMany(e => e.IM_MsgFileElem)
                .WithRequired(e => e.IM_Msg)
                .HasForeignKey(e => e.MsgId);

            modelBuilder.Entity<IM_Msg>()
                .HasMany(e => e.IM_MsgCustomElem)
                .WithRequired(e => e.IM_Msg)
                .HasForeignKey(e => e.MsgId);

            modelBuilder.Entity<IM_Msg>()
                .HasMany(e => e.IM_MsgFaceElem)
                .WithRequired(e => e.IM_Msg)
                .HasForeignKey(e => e.MsgId);

            modelBuilder.Entity<IM_Msg>()
                .HasMany(e => e.IM_MsgImageElem)
                .WithRequired(e => e.IM_Msg)
                .HasForeignKey(e => e.MsgId);

            modelBuilder.Entity<IM_Msg>()
                .HasMany(e => e.IM_MsgLocationElem)
                .WithRequired(e => e.IM_Msg)
                .HasForeignKey(e => e.MsgId);

            modelBuilder.Entity<IM_Msg>()
                .HasMany(e => e.IM_MsgSoundElem)
                .WithRequired(e => e.IM_Msg)
                .HasForeignKey(e => e.MsgId);

            modelBuilder.Entity<IM_Msg>()
                .HasMany(e => e.IM_MsgTextElem)
                .WithRequired(e => e.IM_Msg)
                .HasForeignKey(e => e.MsgId);

            modelBuilder.Entity<IM_MsgHistorySyncTask>()
                .HasMany(e => e.IM_MsgHistorySyncTaskFile)
                .WithRequired(e => e.IM_MsgHistorySyncTask)
                .HasForeignKey(e => e.TaskId);

            modelBuilder.Entity<IM_MsgImageElem>()
                .HasMany(e => e.IM_MsgImageElemFileInfo)
                .WithRequired(e => e.IM_MsgImageElem)
                .HasForeignKey(e => e.ImageElemId);

            modelBuilder.Entity<User_LiveVideo>()
                .HasMany(e => e.User_LiveVideoVideo)
                .WithRequired(e => e.User_LiveVideo)
                .HasForeignKey(e => e.LiveVideoId);

            modelBuilder.Entity<User_LiveVideo>()
                .HasMany(e => e.User_LiveVideoViewer)
                .WithRequired(e => e.User_LiveVideo)
                .HasForeignKey(e => e.LiveVideoId);

            modelBuilder.Entity<User_Main>()
                .HasMany(e => e.User_Follow)
                .WithRequired(e => e.User_Main)
                .HasForeignKey(e => e.FollowUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User_Main>()
                .HasMany(e => e.User_Follow1)
                .WithRequired(e => e.User_Main1)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User_Main>()
                .HasMany(e => e.User_LiveVideo)
                .WithRequired(e => e.User_Main)
                .HasForeignKey(e => e.HostId);

            modelBuilder.Entity<User_Main>()
                .HasMany(e => e.User_LiveVideoViewer)
                .WithRequired(e => e.User_Main)
                .HasForeignKey(e => e.ViewerId)
                .WillCascadeOnDelete(false);
        }
    }
}
