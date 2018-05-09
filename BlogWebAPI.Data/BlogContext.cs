using BlogWebAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlogWebAPI.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }

        public BlogContext()
        {

        }

        public DbSet<BlogPost> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        //public DbSet<GetAllPosts> GetAllPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PostCategory>()
            //    .HasKey(t => new { t.BlogPostId, t.CategoryId });

            //modelBuilder.Entity<PostCategory>()
            // .HasOne(pt => pt.BlogPost)
            // .WithMany(p => p.CategoriesLink)
            // .HasForeignKey(pt => pt.BlogPostId);

            //modelBuilder.Entity<PostCategory>()
            //    .HasOne(pt => pt.Category)
            //    .WithMany(t => t.PostLink)
            //    .HasForeignKey(pt => pt.CategoryId);

            base.OnModelCreating(modelBuilder); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
