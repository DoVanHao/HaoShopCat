namespace CatShop.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CatDbContext : DbContext
    {
        public CatDbContext()
            : base("name=CatDbContext")
        {
        }

        public virtual DbSet<C_Login> C_Login { get; set; }
        public virtual DbSet<BestCat> BestCats { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<CommentBlog> CommentBlogs { get; set; }
        public virtual DbSet<LastNew> LastNews { get; set; }
        public virtual DbSet<LoaiMeo> LoaiMeos { get; set; }
        public virtual DbSet<MaxMonneyCat> MaxMonneyCats { get; set; }
        public virtual DbSet<Meo> Meos { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<SellerCat> SellerCats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_Login>()
                .Property(e => e.Ma_NguoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<C_Login>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<C_Login>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<BestCat>()
                .Property(e => e.Id1)
                .IsUnicode(false);

            modelBuilder.Entity<BestCat>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.Ma_blog)
                .IsUnicode(false);

            modelBuilder.Entity<CommentBlog>()
                .Property(e => e.Ma_Comment)
                .IsUnicode(false);

            modelBuilder.Entity<CommentBlog>()
                .Property(e => e.Ma_blog)
                .IsUnicode(false);

            modelBuilder.Entity<LastNew>()
                .Property(e => e.Id1)
                .IsUnicode(false);

            modelBuilder.Entity<LastNew>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiMeo>()
                .Property(e => e.Ma_Loai)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiMeo>()
                .HasMany(e => e.Meos)
                .WithRequired(e => e.LoaiMeo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaxMonneyCat>()
                .Property(e => e.Id1)
                .IsUnicode(false);

            modelBuilder.Entity<MaxMonneyCat>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Meo>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Meo>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<Meo>()
                .Property(e => e.Ma_Loai)
                .IsUnicode(false);

            modelBuilder.Entity<Meo>()
                .Property(e => e.Ma_PerSon)
                .IsUnicode(false);

            modelBuilder.Entity<Meo>()
                .HasMany(e => e.BestCats)
                .WithRequired(e => e.Meo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Meo>()
                .HasMany(e => e.LastNews)
                .WithRequired(e => e.Meo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Meo>()
                .HasMany(e => e.MaxMonneyCats)
                .WithRequired(e => e.Meo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Meo>()
                .HasMany(e => e.SellerCats)
                .WithRequired(e => e.Meo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Ma_PerSon)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Meos)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SellerCat>()
                .Property(e => e.Id1)
                .IsUnicode(false);

            modelBuilder.Entity<SellerCat>()
                .Property(e => e.Id)
                .IsUnicode(false);
        }
    }
}
