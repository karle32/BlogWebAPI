using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BlogWebAPI.Data;

namespace BlogWebAPI.Data.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20170728204140_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogWebAPI.Domain.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImageName");

                    b.Property<string>("Name");

                    b.Property<string>("Summary");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BlogWebAPI.Domain.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<string>("HeroImage");

                    b.Property<int>("Readtime");

                    b.Property<string>("Status");

                    b.Property<string>("Title");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BlogWebAPI.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogPostId");

                    b.Property<string>("ImageName");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BlogPostId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BlogWebAPI.Domain.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Message");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("BlogWebAPI.Domain.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogPostId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BlogPostId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("BlogWebAPI.Domain.BlogPost", b =>
                {
                    b.HasOne("BlogWebAPI.Domain.Author", "Author")
                        .WithMany("BlogPosts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlogWebAPI.Domain.Category", b =>
                {
                    b.HasOne("BlogWebAPI.Domain.BlogPost", "BlogPost")
                        .WithMany("Categories")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlogWebAPI.Domain.Tag", b =>
                {
                    b.HasOne("BlogWebAPI.Domain.BlogPost", "BlogPost")
                        .WithMany("Tags")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
