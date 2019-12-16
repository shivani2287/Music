using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PeriodCalculator.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PeriodCalculator.Data
{
    public partial class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {
        }
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "PocDb.db" };
        //    //var connectionString = connectionStringBuilder.ToString();
        //    //var connection = new SqliteConnection(connectionString);

        //    //optionsBuilder.UseSqlite(connection);

        //    base.OnConfiguring(optionsBuilder);
        //    var builder = new ConfigurationBuilder()
        //        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        //    IConfigurationRoot config = builder.Build();
        //    optionsBuilder.UseSqlServer(config.GetConnectionString("MusicConnection"));

        //    //optionsBuilder.Entity<Artists>(entity =>
        //    //{
        //    //    entity.HasKey(e => e.)
        //    //        .HasName("PK__Products__B40CC6CD2734EEA5");

        //    //    entity.Property(e => e.Category)
        //    //        .HasMaxLength(100)
        //    //        .IsUnicode(false);

        //    //    entity.Property(e => e.Color)
        //    //        .HasMaxLength(20)
        //    //        .IsUnicode(false);

        //    //    entity.Property(e => e.CratedDate)
        //    //        .HasColumnType("datetime")
        //    //        .HasDefaultValueSql("(getdate())");

        //    //    entity.Property(e => e.Name)
        //    //        .IsRequired()
        //    //        .HasMaxLength(100)
        //    //        .IsUnicode(false);

        //    //    entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
        //    //});

        //    //OnModelCreatingPartial(modelBuilder);

        //}

        public virtual DbSet<Genres> Genres { get; set; }

        public virtual DbSet<Artists> Artists { get; set; }

        public virtual DbSet<Albums> Albums { get; set; }
    }
}
