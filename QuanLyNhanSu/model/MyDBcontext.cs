namespace QuanLyNhanSu.model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDBcontext : DbContext
    {
        public MyDBcontext()
            : base("name=MyDBcontext")
        {
        }

        public virtual DbSet<DU_AN> DU_AN { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<PHONG_BAN> PHONG_BAN { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THAN_NHAN> THAN_NHAN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DU_AN>()
                .Property(e => e.MA_DA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DU_AN>()
                .Property(e => e.MA_PB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MA_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MA_NQL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.GIOI_TINH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MA_PB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.PHONG_BAN1)
                .WithOptional(e => e.NHAN_VIEN1)
                .HasForeignKey(e => e.MA_TP);

            modelBuilder.Entity<NHAN_VIEN>()
                .HasOptional(e => e.THAN_NHAN)
                .WithRequired(e => e.NHAN_VIEN);

            modelBuilder.Entity<PHONG_BAN>()
                .Property(e => e.MA_PB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONG_BAN>()
                .Property(e => e.MA_TP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONG_BAN>()
                .HasMany(e => e.NHAN_VIEN)
                .WithOptional(e => e.PHONG_BAN)
                .HasForeignKey(e => e.MA_PB);

            modelBuilder.Entity<THAN_NHAN>()
                .Property(e => e.MA_NV)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
