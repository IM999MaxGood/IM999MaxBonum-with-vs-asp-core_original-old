using IM999MaxBonum.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace IM999MaxBonum.Data
{
    public class IM999Max_DotNetCore : DbContext
    {
        public IM999Max_DotNetCore(DbContextOptions<IM999Max_DotNetCore> options) : base(options)
        {
        }

        public DbSet<Language> Language { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Page> Page { get; set; }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<vMenu> vMenu { get; set; }

        public DbSet<vPage> vPage { get; set; }

        public DbSet<PageGroup> PageGroup { get; set; }
        public DbSet<vPageGroup> vPageGroup { get; set; }

        public DbSet<LoginLog> LoginLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasKey(a => a.LangId);
            modelBuilder.Entity<vPage>().HasKey(a => a.PageId);
            modelBuilder.Entity<vMenu>().HasKey(a => a.MenuId);
            modelBuilder.Entity<vPageGroup>().HasKey(a => a.PageGroupId);
            modelBuilder.Entity<LoginLog>().HasKey(a => a.LLId);
           
            modelBuilder.Entity<Language>().ToTable("Language");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Page>().ToTable("Page");
            modelBuilder.Entity<Menu>().ToTable("Menu");
            modelBuilder.Entity<LoginLog>().ToTable("LoginLog");
            modelBuilder.Entity<PageGroup>().ToTable("PageGroup");
            modelBuilder.Entity<vMenu>().ToTable("vMenu");
            modelBuilder.Entity<vPage>().ToTable("vPage");
            modelBuilder.Entity<vPageGroup>().ToTable("vPageGroup");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=IM999MAXGOOD-W1\\SQLEXPRESS2012;Database=IM999MaxBonum_vs_Net_Core;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(builder);
        }
    }
}