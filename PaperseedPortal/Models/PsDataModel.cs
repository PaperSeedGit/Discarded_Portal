namespace PaperseedPortal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class PsDataModel : DbContext
    {
        public PsDataModel()
            : base("name=PsDataModelConnectionSettings")
        {
        }

        public virtual DbSet<tbltest> tbltests { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbltest>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<tbltest>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>().HasKey(p => p.PublisherId);
            modelBuilder.Entity<Publisher>().Property(c => c.PublisherId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Book>().HasKey(b => b.BookId);
            modelBuilder.Entity<Book>().Property(b => b.BookId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Book>().HasRequired(p => p.Publisher)
                .WithMany(b => b.Books).HasForeignKey(b => b.PublisherId);
            base.OnModelCreating(modelBuilder);
        }
    }


    //Sample classes
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string Address { get; set; }
        public ICollection<Book> Books { get; set; }
    }

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }

}
